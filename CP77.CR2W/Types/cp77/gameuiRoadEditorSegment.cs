using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRoadEditorSegment : CVariable
	{
		[Ordinal(0)]  [RED("length")] public CUInt32 Length { get; set; }
		[Ordinal(1)]  [RED("curve")] public CFloat Curve { get; set; }
		[Ordinal(2)]  [RED("decorationSettings")] public CArray<gameuiRoadEditorDecorationSettings> DecorationSettings { get; set; }
		[Ordinal(3)]  [RED("obstacleSettings")] public CArray<gameuiRoadEditorObstacleSettings> ObstacleSettings { get; set; }
		[Ordinal(4)]  [RED("hasCheckpoint")] public CBool HasCheckpoint { get; set; }

		public gameuiRoadEditorSegment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
