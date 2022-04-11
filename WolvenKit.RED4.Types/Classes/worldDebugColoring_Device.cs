using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_Device : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_Device()
		{
			DefaultColor = new();
		}
	}
}
