using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_GIDebug : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] [RED("GIVisibleColor")] public CColor GIVisibleColor { get; set; }
		[Ordinal(1)] [RED("GITransparentColor")] public CColor GITransparentColor { get; set; }

		public worldDebugColoring_GIDebug(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
