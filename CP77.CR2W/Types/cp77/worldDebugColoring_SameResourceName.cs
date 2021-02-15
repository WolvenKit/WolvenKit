using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_SameResourceName : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] [RED("alpha")] public CUInt8 Alpha { get; set; }

		public worldDebugColoring_SameResourceName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
