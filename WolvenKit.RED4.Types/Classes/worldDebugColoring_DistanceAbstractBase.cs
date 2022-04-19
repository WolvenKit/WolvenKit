using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_DistanceAbstractBase : worldEditorDebugColoringSettings
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
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldDebugColoring_DistanceAbstractBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
