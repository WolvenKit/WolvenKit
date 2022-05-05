using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_MetricsUsageAbstractBase : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("maxColor")] 
		public CColor MaxColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("minColor")] 
		public CColor MinColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("minSize")] 
		public CUInt32 MinSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("maxSize")] 
		public CUInt32 MaxSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldDebugColoring_MetricsUsageAbstractBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
