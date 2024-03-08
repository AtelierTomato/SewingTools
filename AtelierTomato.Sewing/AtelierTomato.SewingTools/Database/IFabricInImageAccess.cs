using SewingTools.Database.Model;

namespace AtelierTomato.SewingTools.Database
{
	public interface IFabricInImageAccess
	{
		Task<IEnumerable<Fabric>> ReadFabricsInImage(ulong imageID);
		Task<IEnumerable<Image>> ReadImagesWithFabric(ulong fabricID);
		Task WriteFabricInImage(FabricInImage fabricInImage);
		Task WriteFabricInImageRange(IEnumerable<FabricInImage> fabricInImages);
	}
}
