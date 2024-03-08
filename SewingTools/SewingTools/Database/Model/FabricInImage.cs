namespace SewingTools.Database.Model
{
	public record FabricInImage(
		ulong ImageID,
		ulong FabricID,
		bool IsInImage = true
	);
}
