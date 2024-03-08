using Dapper;
using Microsoft.Data.Sqlite;
using SewingTools.Database.Model;

namespace AtelierTomato.SewingTools.Database.Sqlite
{
	public class SqliteImageAccess : IImageAccess
	{
		private string connectionString = "Data Source=K:\\Projects\\Programming\\,Databases";

		public async Task<IEnumerable<Image>> ReadAllImages()
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QueryAsync<Image>($@"select * from {nameof(Image)}");

			connection.Close();

			return result;
		}

		public async Task<Image> ReadImage(ulong ID)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QuerySingleAsync<Image>($@"select * from {nameof(Image)} where {nameof(Image.ID)} = @ID", new { ID });

			connection.Close();

			return result;
		}

		public async Task<IEnumerable<Image>> ReadImageRange(IEnumerable<ulong> IDs)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QueryAsync<Image>($@"select * from {nameof(Image)} where {nameof(Image.ID)} IN @IDs", new { IDs });

			connection.Close();

			return result;
		}

		public async Task WriteImage(Image image) => await WriteImageRange([image]);

		public async Task WriteImageRange(IEnumerable<Image> images)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();
			foreach (Image image in images)
			{
				await WriteImageCore(image, connection);
			}

			connection.Close();
		}

		private static async Task WriteImageCore(Image image, SqliteConnection connection)
		{
			await connection.ExecuteAsync($@"
insert into {nameof(Image)} ( {nameof(Image.ID)}, {nameof(Image.FileExtension)}, {nameof(Image.Title)}, {nameof(Image.Description)})
Values ( @ID, @fileExtension, @title, @description )
on conflict ({nameof(Image.ID)}) do update set
{nameof(Image.FileExtension)} = excluded.{nameof(Image.FileExtension)},
{nameof(Image.Title)} = excluded.{nameof(Image.Title)},
{nameof(Image.Description)} = excluded.{nameof(Image.Description)}
",
			new
			{
				ID = image.ID,
				fileExtension = image.FileExtension,
				title = image.Title,
				description = image.Description,
			});
		}
	}
}
