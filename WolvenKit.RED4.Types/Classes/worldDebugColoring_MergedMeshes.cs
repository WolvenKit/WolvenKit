using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_MergedMeshes : worldEditorDebugColoringSettings
	{
		private CColor _defaultColor;
		private CColor _mergedMeshColor;

		[Ordinal(0)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetProperty(ref _defaultColor);
			set => SetProperty(ref _defaultColor, value);
		}

		[Ordinal(1)] 
		[RED("mergedMeshColor")] 
		public CColor MergedMeshColor
		{
			get => GetProperty(ref _mergedMeshColor);
			set => SetProperty(ref _mergedMeshColor, value);
		}
	}
}
