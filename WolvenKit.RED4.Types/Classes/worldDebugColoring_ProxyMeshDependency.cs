using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_ProxyMeshDependency : worldEditorDebugColoringSettings
	{
		private CColor _autoColor;
		private CColor _discardColor;

		[Ordinal(0)] 
		[RED("autoColor")] 
		public CColor AutoColor
		{
			get => GetProperty(ref _autoColor);
			set => SetProperty(ref _autoColor, value);
		}

		[Ordinal(1)] 
		[RED("discardColor")] 
		public CColor DiscardColor
		{
			get => GetProperty(ref _discardColor);
			set => SetProperty(ref _discardColor, value);
		}
	}
}
