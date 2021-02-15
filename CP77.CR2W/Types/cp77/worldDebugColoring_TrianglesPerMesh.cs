using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_TrianglesPerMesh : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] [RED("maxColor")] public CColor MaxColor { get; set; }
		[Ordinal(1)] [RED("minColor")] public CColor MinColor { get; set; }
		[Ordinal(2)] [RED("minCount")] public CUInt32 MinCount { get; set; }
		[Ordinal(3)] [RED("maxCount")] public CUInt32 MaxCount { get; set; }

		public worldDebugColoring_TrianglesPerMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
