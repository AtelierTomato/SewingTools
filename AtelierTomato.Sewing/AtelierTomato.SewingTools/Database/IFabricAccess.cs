using SewingTools.Database.Model;

namespace AtelierTomato.SewingTools.Database
{
	public interface IFabricAccess
	{
		Task<Fabric> ReadFabric(ulong ID);
		Task<IEnumerable<Fabric>> ReadFabricRange(IEnumerable<ulong> IDs);
		Task<IEnumerable<Fabric>> ReadAllFabrics();
		Task WriteFabric(Fabric fabric);
		Task WriteFabricRange(IEnumerable<Fabric> fabrics);
	}
}
