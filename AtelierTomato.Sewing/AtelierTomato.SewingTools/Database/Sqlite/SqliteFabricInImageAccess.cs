using Dapper;
using Microsoft.Data.Sqlite;
using SewingTools.Database.Model;

namespace AtelierTomato.SewingTools.Database.Sqlite
{
	public class SqliteFabricInImageAccess : IFabricInImageAccess
	{
		private string connectionString = "Data Source=K:\\Projects\\Programming\\,Databases";

		public async Task<IEnumerable<Fabric>> ReadFabricsInImage(ulong imageID)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QueryAsync<Fabric>($@"select * from {nameof(Fabric)} where {nameof(Fabric.ID)} in 
(select {nameof(FabricInImage.FabricID)} from {nameof(FabricInImage)} where {nameof(FabricInImage.ImageID)} = @imageID)", new { imageID });

			connection.Close();

			return result;
		}

		public async Task<IEnumerable<Image>> ReadImagesWithFabric(ulong fabricID)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QueryAsync<Image>($@"select * from {nameof(Image)} where {nameof(Image.ID)} in 
(select {nameof(FabricInImage.ImageID)} from {nameof(FabricInImage)} where {nameof(FabricInImage.FabricID)} = @fabricID)", new { fabricID });

			connection.Close();

			return result;
		}

		public async Task WriteFabricInImage(FabricInImage fabricInImage) => await WriteFabricInImageRange([fabricInImage]);

		public async Task WriteFabricInImageRange(IEnumerable<FabricInImage> fabricInImages)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();
			foreach (FabricInImage fabricInImage in fabricInImages)
			{
				await WriteFabricInImageCore(fabricInImage, connection);
			}

			connection.Close();
		}

		private static async Task WriteFabricInImageCore(FabricInImage fabricInImage, SqliteConnection connection)
		{
			await connection.ExecuteAsync($@"
insert into {nameof(FabricInImage)} ( {nameof(FabricInImage.ImageID)}, {nameof(FabricInImage.FabricID)}, {nameof(FabricInImage.IsInImage)})
Values ( @imageID, @fabricID, @isInImage )
on conflict ({nameof(FabricInImage.ImageID)}, {nameof(FabricInImage.FabricID)}) do update set
{nameof(FabricInImage.IsInImage)} = excluded.{nameof(FabricInImage.IsInImage)}
",
			new
			{
				imageID = fabricInImage.ImageID,
				fabricID = fabricInImage.FabricID,
				isInImage = fabricInImage.IsInImage
			});
		}
	}
}
