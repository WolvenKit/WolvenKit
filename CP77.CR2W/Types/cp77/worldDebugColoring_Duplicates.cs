using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_Duplicates : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("defaultColor")] public CColor DefaultColor { get; set; }
		[Ordinal(1)]  [RED("duplicateColor")] public CColor DuplicateColor { get; set; }
		[Ordinal(2)]  [RED("refresh")] public CBool Refresh { get; set; }
		[Ordinal(3)]  [RED("refreshPrefab")] public rRef<worldPrefab> RefreshPrefab { get; set; }

		public worldDebugColoring_Duplicates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
