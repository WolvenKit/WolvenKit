using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_StreamingCullingFlag : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("cullableColor")] 
		public CColor CullableColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("forceCulledAlwaysColor")] 
		public CColor ForceCulledAlwaysColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("forceCulledPeripheralColor")] 
		public CColor ForceCulledPeripheralColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(3)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_StreamingCullingFlag()
		{
			CullableColor = new CColor { Red = 127, Green = 127, Blue = 255, Alpha = 255 };
			ForceCulledAlwaysColor = new CColor { Red = 255, Alpha = 255 };
			ForceCulledPeripheralColor = new CColor { Red = 255, Green = 255, Alpha = 255 };
			DefaultColor = new CColor { Red = 255, Green = 255, Blue = 255, Alpha = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
