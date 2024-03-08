namespace SewingTools.Database.Model
{
	public record FabricSquare(
		ulong FabricID,
		int Length,
		int Width,
		int Amount = 1
	);
}