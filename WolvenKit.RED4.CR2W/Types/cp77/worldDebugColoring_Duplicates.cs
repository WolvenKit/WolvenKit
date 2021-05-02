using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_Duplicates : worldEditorDebugColoringSettings
	{
		private CColor _defaultColor;
		private CColor _duplicateColor;
		private rRef<worldPrefab> _refreshPrefab;
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
		public rRef<worldPrefab> RefreshPrefab
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

		public worldDebugColoring_Duplicates(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
