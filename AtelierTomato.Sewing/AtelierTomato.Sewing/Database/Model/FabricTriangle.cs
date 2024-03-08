namespace SewingTools.Database.Model
{
	public record FabricTriangle(
		ulong FabricID,
		int ShortestLength,
		int MiddleLength,
		int LongestLength,
		int Amount = 1
	);
}