using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrack : effectTrackBase
	{
		[Ordinal(0)] 
		[RED("items")] 
		public CArray<CHandle<effectTrackItem>> Items
		{
			get => GetPropertyValue<CArray<CHandle<effectTrackItem>>>();
			set => SetPropertyValue<CArray<CHandle<effectTrackItem>>>(value);
		}

		public effectTrack()
		{
			Items = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
