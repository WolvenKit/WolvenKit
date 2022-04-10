using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_GIDebug : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("GIVisibleColor")] 
		public CColor GIVisibleColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("GITransparentColor")] 
		public CColor GITransparentColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_GIDebug()
		{
			GIVisibleColor = new();
			GITransparentColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
