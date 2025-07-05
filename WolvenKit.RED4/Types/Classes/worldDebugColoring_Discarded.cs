using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_Discarded : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_Discarded()
		{
			Color = new CColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
