using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiRoadEditorSegment : CVariable
	{
		[Ordinal(0)]  [RED("curve")] public CFloat Curve { get; set; }
		[Ordinal(1)]  [RED("decorationSettings")] public CArray<gameuiRoadEditorDecorationSettings> DecorationSettings { get; set; }
		[Ordinal(2)]  [RED("hasCheckpoint")] public CBool HasCheckpoint { get; set; }
		[Ordinal(3)]  [RED("length")] public CUInt32 Length { get; set; }
		[Ordinal(4)]  [RED("obstacleSettings")] public CArray<gameuiRoadEditorObstacleSettings> ObstacleSettings { get; set; }

		public gameuiRoadEditorSegment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
