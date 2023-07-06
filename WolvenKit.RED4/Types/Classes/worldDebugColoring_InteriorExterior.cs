using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_InteriorExterior : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("interiorColor")] 
		public CColor InteriorColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("openInteriorColor")] 
		public CColor OpenInteriorColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("exteriorColor")] 
		public CColor ExteriorColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_InteriorExterior()
		{
			InteriorColor = new CColor();
			OpenInteriorColor = new CColor();
			ExteriorColor = new CColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
