namespace SewingTools.Database.Model
{
	public class FabricTriangle
	{
		public ulong FabricID { get; }
		public int ShortestLength { get; }
		public int MiddleLength { get; }
		public int LongestLength { get; }
		public int Amount { get; }
		public FabricTriangle(ulong FabricID, int ShortestLength, int MiddleLength, int LongestLength, int Amount = 1)
		{
			int[] unorderedLengths = [ShortestLength, MiddleLength, LongestLength];
			var orderedLengths = unorderedLengths.OrderBy(i => i).ToList();

			this.FabricID = FabricID;
			this.ShortestLength = orderedLengths[0];
			this.MiddleLength = orderedLengths[1];
			this.LongestLength = orderedLengths[2];
			this.Amount = Amount;
		}
	}
}