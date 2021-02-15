using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_Duplicates : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] [RED("defaultColor")] public CColor DefaultColor { get; set; }
		[Ordinal(1)] [RED("duplicateColor")] public CColor DuplicateColor { get; set; }
		[Ordinal(2)] [RED("refreshPrefab")] public rRef<worldPrefab> RefreshPrefab { get; set; }
		[Ordinal(3)] [RED("refresh")] public CBool Refresh { get; set; }

		public worldDebugColoring_Duplicates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
