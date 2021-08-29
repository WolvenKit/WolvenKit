using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_Duplicates : worldEditorDebugColoringSettings
	{
		private CColor _defaultColor;
		private CColor _duplicateColor;
		private CResourceReference<worldPrefab> _refreshPrefab;
		private CBool _refresh;

		[Ordinal(0)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetProperty(ref _defaultColor);
			set => SetProperty(ref _defaultColor, value);
		}

		[Ordinal(1)] 
		[RED("duplicateColor")] 
		public CColor DuplicateColor
		{
			get => GetProperty(ref _duplicateColor);
			set => SetProperty(ref _duplicateColor, value);
		}

		[Ordinal(2)] 
		[RED("refreshPrefab")] 
		public CResourceReference<worldPrefab> RefreshPrefab
		{
			get => GetProperty(ref _refreshPrefab);
			set => SetProperty(ref _refreshPrefab, value);
		}

		[Ordinal(3)] 
		[RED("refresh")] 
		public CBool Refresh
		{
			get => GetProperty(ref _refresh);
			set => SetProperty(ref _refresh, value);
		}
	}
}
