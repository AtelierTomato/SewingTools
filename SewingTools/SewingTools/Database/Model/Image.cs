namespace SewingTools.Database.Model
{
	public record Image(
		ulong ID,
		string FileExtension,
		string Title,
		string Description
	);
}
