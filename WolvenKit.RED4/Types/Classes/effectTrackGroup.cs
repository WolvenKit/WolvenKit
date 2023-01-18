using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackGroup : effectTrackBase
	{
		[Ordinal(0)] 
		[RED("tracks")] 
		public CArray<CHandle<effectTrackBase>> Tracks
		{
			get => GetPropertyValue<CArray<CHandle<effectTrackBase>>>();
			set => SetPropertyValue<CArray<CHandle<effectTrackBase>>>(value);
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public effectTrackGroup()
		{
			Tracks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
