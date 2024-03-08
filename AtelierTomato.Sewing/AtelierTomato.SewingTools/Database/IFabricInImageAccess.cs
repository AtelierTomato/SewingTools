using SewingTools.Database.Model;

namespace AtelierTomato.SewingTools.Database
{
	public interface IFabricInImageAccess
	{
		Task<IEnumerable<FabricInImage>> ReadFabricsInImage(ulong imageID);
		Task<IEnumerable<FabricInImage>> ReadImagesWithFabric(ulong fabricID);
		Task WriteFabricInImage(FabricInImage fabricInImage);
		Task WriteFabricInImageRange(IEnumerable<FabricInImage> fabricInImages);
	}
}
