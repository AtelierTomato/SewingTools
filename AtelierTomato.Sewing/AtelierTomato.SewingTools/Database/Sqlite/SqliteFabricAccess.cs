using Dapper;
using Microsoft.Data.Sqlite;
using SewingTools.Database.Model;

namespace AtelierTomato.SewingTools.Database.Sqlite
{
	public class SqliteFabricAccess : IFabricAccess
	{
		private string connectionString = "Data Source=K:\\Projects\\Programming\\,Databases";

		public async Task<IEnumerable<Fabric>> ReadAllFabrics()
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QueryAsync<Fabric>($@"select * from {nameof(Fabric)}");

			connection.Close();

			return result;
		}

		public async Task<Fabric> ReadFabric(ulong ID)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QuerySingleAsync<Fabric>($@"select * from {nameof(Fabric)} where {nameof(Fabric.ID)} = @ID", new { ID });

			connection.Close();

			return result;
		}

		public async Task<IEnumerable<Fabric>> ReadFabricRange(IEnumerable<ulong> IDs)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var result = await connection.QueryAsync<Fabric>($@"select * from {nameof(Fabric)} where {nameof(Fabric.ID)} IN @IDs", new { IDs });

			connection.Close();

			return result;
		}

		public async Task AddNewFabric(string name, string material)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();

			await connection.ExecuteAsync($@"insert into {nameof(Fabric)} ({nameof(Fabric.Name)}, {nameof(Fabric.Material)}) values ( @name, @material",
				new
				{
					name,
					material
				});

			connection.Close();
		}

		public async Task WriteFabric(Fabric fabric) => await WriteFabricRange([fabric]);

		public async Task WriteFabricRange(IEnumerable<Fabric> fabrics)
		{
			await using var connection = new SqliteConnection(connectionString);
			connection.Open();
			foreach (Fabric fabric in fabrics)
			{
				await WriteFabricCore(fabric, connection);
			}

			connection.Close();
		}

		private static async Task WriteFabricCore(Fabric fabric, SqliteConnection connection)
		{
			await connection.ExecuteAsync($@"
insert into {nameof(Fabric)} ( {nameof(Fabric.ID)}, {nameof(Fabric.Name)}, {nameof(Fabric.Material)})
Values ( @ID, @name, @material )
on conflict ({nameof(Fabric.ID)}) do update set
{nameof(Fabric.Name)} = excluded.{nameof(Fabric.Name)},
{nameof(Fabric.Material)} = excluded.{nameof(Fabric.Material)}
",
			new
			{
				ID = fabric.ID,
				name = fabric.Name,
				material = fabric.Material
			});
		}
	}
}
