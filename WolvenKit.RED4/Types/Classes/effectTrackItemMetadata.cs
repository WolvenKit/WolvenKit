
namespace WolvenKit.RED4.Types
{
	public abstract partial class effectTrackItemMetadata : effectTrackItem
	{
		public effectTrackItemMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
