using SewingTools.Database.Model;

namespace AtelierTomato.SewingTools.Database
{
	public interface IFabricTriangleAccess
	{
		Task<FabricTriangle> ReadFabricTriangle(ulong FabricID, int shortestLength, int middleLength, int longestLength);
		Task<IEnumerable<FabricTriangle>> ReadFabricTriangleRangeInOneID(ulong fabricID);
		Task WriteFabricTriangle(FabricTriangle fabricTriangle);
		Task WriteFabricTriangleRange(IEnumerable<FabricTriangle> fabricTriangles);
	}
}
