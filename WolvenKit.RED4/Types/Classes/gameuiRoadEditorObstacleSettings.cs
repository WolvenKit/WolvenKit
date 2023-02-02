using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRoadEditorObstacleSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("segmentOffset")] 
		public CUInt32 SegmentOffset
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiRoadEditorObstacleSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
