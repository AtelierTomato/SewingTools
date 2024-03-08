using AtelierTomato.SewingTools.Database.Sqlite;

namespace AtelierTomato.Sewing
{
	public class Program
	{
		public async void Main()
		{
			Console.WriteLine("This program will allow you to manage a database centered around sewing.");
			Console.WriteLine();
			bool loop = true;
			while (loop)
			{
				Console.WriteLine("Please select an option:");
				Console.WriteLine("	 1 - Add a fabric to the database");
				Console.WriteLine("	 2 - Edit an existing fabric in the database");
				Console.WriteLine("	 3 - Add a square of fabric to the database");
				Console.WriteLine("	 4 - Remove a square of fabric from the database");
				Console.WriteLine("	 5 - Add a triangle of fabric to the database");
				Console.WriteLine("	 6 - Remove a triangle of fabric from the database");
				Console.WriteLine("	 q - Close the program");
				Console.WriteLine();
				var selection = Console.ReadLine();
				switch (selection)
				{
					case "1":
						await addFabric();
						break;
					case "2":
						await editFabric();
						break;
					case "3":
						await addSquare();
						break;
					case "4":
						await removeSquare();
						break;
					case "5":
						await addTriangle();
						break;
					case "6":
						await removeTriangle();
						break;
					case "q":
						loop = false;
						break;
					default:
						Console.WriteLine("Please insert a valid option.");
						break;
				}
				Console.WriteLine();
			}
		}

		private async Task addFabric()
		{
			Console.WriteLine("Please enter the name of the fabric:");
			var name = Console.ReadLine();
			Console.WriteLine("Please enter the material of the fabric:");
			var material = Console.ReadLine();
			SqliteFabricAccess sqliteFabricAccess = new();

			await sqliteFabricAccess.AddNewFabric(name, material);
		}
		private async Task editFabric()
		{

		}
		private async Task addSquare()
		{

		}
		private async Task removeSquare()
		{

		}
		private async Task addTriangle()
		{

		}
		private async Task removeTriangle()
		{

		}
	}
}