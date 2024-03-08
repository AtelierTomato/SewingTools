using SewingTools.Database.Model;

namespace AtelierTomato.SewingTools.Database
{
	public interface IImageAccess
	{
		Task<Image> ReadImage(ulong ID);
		Task<IEnumerable<Image>> ReadImageRange(IEnumerable<ulong> ID);
		Task<IEnumerable<Image>> ReadAllImages();
		Task WriteImage(Image image);
		Task WriteImageRange(IEnumerable<Image> images);
	}
}
