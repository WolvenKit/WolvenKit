using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRoadEditorDecorationSettings : RedBaseClass
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
		[RED("repeatPatternDensity")] 
		public CUInt32 RepeatPatternDensity
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("repeatPatternStartOffset")] 
		public CUInt32 RepeatPatternStartOffset
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiRoadEditorDecorationSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
