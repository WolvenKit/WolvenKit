using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_GIDebug : worldEditorDebugColoringSettings
	{
		private CColor _gIVisibleColor;
		private CColor _gITransparentColor;

		[Ordinal(0)] 
		[RED("GIVisibleColor")] 
		public CColor GIVisibleColor
		{
			get => GetProperty(ref _gIVisibleColor);
			set => SetProperty(ref _gIVisibleColor, value);
		}

		[Ordinal(1)] 
		[RED("GITransparentColor")] 
		public CColor GITransparentColor
		{
			get => GetProperty(ref _gITransparentColor);
			set => SetProperty(ref _gITransparentColor, value);
		}
	}
}
