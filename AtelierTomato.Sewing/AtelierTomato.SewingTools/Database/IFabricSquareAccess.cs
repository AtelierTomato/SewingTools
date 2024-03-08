using SewingTools.Database.Model;

namespace AtelierTomato.SewingTools.Database
{
	public interface IFabricSquareAccess
	{
		Task<FabricSquare> ReadFabricSquare(ulong FabricID, int length, int width);
		Task<IEnumerable<FabricSquare>> ReadFabricSquareRangeInOneID(ulong fabricID);
		Task WriteFabricSquare(FabricSquare fabricSquare);
		Task WriteFabricSquareRange(IEnumerable<FabricSquare> fabricSquares);
	}
}
