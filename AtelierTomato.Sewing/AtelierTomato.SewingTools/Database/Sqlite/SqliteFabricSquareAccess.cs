using Dapper;
using Microsoft.Data.Sqlite;
using SewingTools.Database.Model;

namespace AtelierTomato.SewingTools.Database.Sqlite
{
	public class SqliteFabricSquareAccess : IFabricSquareAccess
	{
		private string connectionString = "Data Source=K:\\Projects\\Programming\\,Databases";

		public async Task<FabricSquare> ReadFabricSquare(ulong fabricID, int length, int width)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QuerySingleAsync<FabricSquare>($@"
select * from {nameof(FabricSquare)}
where
{nameof(FabricSquare.FabricID)} = @fabricID and {nameof(FabricSquare.Length)} = @length and {nameof(FabricSquare.Width)} = @width
",
			new
			{
				fabricID,
				length,
				width
			});

			connection.Close();

			return result;
		}

		public async Task<IEnumerable<FabricSquare>> ReadFabricSquareRangeInOneID(ulong fabricID)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QueryAsync<FabricSquare>($@"select * from {nameof(FabricSquare)} where {nameof(FabricSquare.FabricID)} = @fabricID",
			new { fabricID });

			connection.Close();

			return result;
		}

		public async Task WriteFabricSquare(FabricSquare fabricSquare) => await WriteFabricSquareRange([fabricSquare]);

		public async Task WriteFabricSquareRange(IEnumerable<FabricSquare> fabricSquares)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();
			foreach (FabricSquare fabricSquare in fabricSquares)
			{
				await WriteFabricSquareCore(fabricSquare, connection);
			}

			connection.Close();
		}
		private static async Task WriteFabricSquareCore(FabricSquare fabricSquare, SqliteConnection connection)
		{
			await connection.ExecuteAsync($@"
insert into {nameof(FabricSquare)} ( {nameof(FabricSquare.FabricID)}, {nameof(FabricSquare.Length)}, {nameof(FabricSquare.Width)}, {nameof(FabricSquare.Amount)})
Values ( @fabricID, @length, @width, @amount )
on conflict ({nameof(FabricSquare.FabricID)}, {nameof(FabricSquare.Length)}, {nameof(FabricSquare.Width)}) do update set
{nameof(FabricSquare.Amount)} = excluded.{nameof(FabricSquare.Amount)}
",
			new
			{
				fabricID = fabricSquare.FabricID,
				length = fabricSquare.Length,
				width = fabricSquare.Width,
				amount = fabricSquare.Amount
			});
		}
	}
}
