using Dapper;
using Microsoft.Data.Sqlite;
using SewingTools.Database.Model;

namespace AtelierTomato.SewingTools.Database.Sqlite
{
	public class SqliteFabricTriangleAccess : IFabricTriangleAccess
	{
		private string connectionString = "Data Source=K:\\Projects\\Programming\\,Databases";

		public async Task<FabricTriangle> ReadFabricTriangle(ulong fabricID, int shortestLength, int middleLength, int longestLength)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QuerySingleAsync<FabricTriangle>($@"
select * from {nameof(FabricTriangle)}
where
{nameof(FabricTriangle.FabricID)} = @fabricID and
{nameof(FabricTriangle.ShortestLength)} = @shortestLength and
{nameof(FabricTriangle.MiddleLength)} = @middleLength and
{nameof(FabricTriangle.LongestLength)} = @longestLength
",
			new
			{
				fabricID,
				shortestLength,
				middleLength,
				longestLength
			});

			connection.Close();

			return result;
		}

		public async Task<IEnumerable<FabricTriangle>> ReadFabricTriangleRangeInOneID(ulong fabricID)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QueryAsync<FabricTriangle>($@"select * from {nameof(FabricTriangle)} where {nameof(FabricTriangle.FabricID)} = @fabricID",
			new { fabricID });

			connection.Close();

			return result;
		}

		public async Task WriteFabricTriangle(FabricTriangle fabricTriangle) => await WriteFabricTriangleRange([fabricTriangle]);

		public async Task WriteFabricTriangleRange(IEnumerable<FabricTriangle> fabricTriangles)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();
			foreach (FabricTriangle fabricTriangle in fabricTriangles)
			{
				await WriteFabricTriangleCore(fabricTriangle, connection);
			}

			connection.Close();
		}

		private static async Task WriteFabricTriangleCore(FabricTriangle fabricTriangle, SqliteConnection connection)
		{
			await connection.ExecuteAsync($@"
insert into {nameof(FabricTriangle)} ( 
{nameof(FabricTriangle.FabricID)}, {nameof(FabricTriangle.ShortestLength)}, {nameof(FabricTriangle.MiddleLength)}, {nameof(FabricTriangle.LongestLength)}, {nameof(FabricTriangle.Amount)} )
Values ( @fabricID, @shortestLength, @middleLength, @longestLength, @amount )
on conflict ({nameof(FabricTriangle.FabricID)}, {nameof(FabricTriangle.ShortestLength)}, {nameof(FabricTriangle.MiddleLength)}, {nameof(FabricTriangle.LongestLength)})
do update set {nameof(FabricTriangle.Amount)} = excluded.{nameof(FabricTriangle.Amount)}
",
			new
			{
				fabricID = fabricTriangle.FabricID,
				shortestLength = fabricTriangle.ShortestLength,
				middleLength = fabricTriangle.MiddleLength,
				longestLength = fabricTriangle.LongestLength,
				amount = fabricTriangle.Amount
			});
		}
	}
}
