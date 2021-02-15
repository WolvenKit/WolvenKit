using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_InteriorExterior : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] [RED("interiorColor")] public CColor InteriorColor { get; set; }
		[Ordinal(1)] [RED("openInteriorColor")] public CColor OpenInteriorColor { get; set; }
		[Ordinal(2)] [RED("exteriorColor")] public CColor ExteriorColor { get; set; }

		public worldDebugColoring_InteriorExterior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
