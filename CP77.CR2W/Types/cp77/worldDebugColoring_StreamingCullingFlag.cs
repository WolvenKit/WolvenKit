using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_StreamingCullingFlag : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] [RED("cullableColor")] public CColor CullableColor { get; set; }
		[Ordinal(1)] [RED("forceCulledAlwaysColor")] public CColor ForceCulledAlwaysColor { get; set; }
		[Ordinal(2)] [RED("forceCulledPeripheralColor")] public CColor ForceCulledPeripheralColor { get; set; }
		[Ordinal(3)] [RED("defaultColor")] public CColor DefaultColor { get; set; }

		public worldDebugColoring_StreamingCullingFlag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
