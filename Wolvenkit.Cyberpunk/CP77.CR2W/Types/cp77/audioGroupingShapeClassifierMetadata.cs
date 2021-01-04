using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioGroupingShapeClassifierMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("ceilingLimit")] public CBool CeilingLimit { get; set; }
		[Ordinal(1)]  [RED("floorLimit")] public CBool FloorLimit { get; set; }
		[Ordinal(2)]  [RED("maxDistanceLimit")] public CName MaxDistanceLimit { get; set; }
		[Ordinal(3)]  [RED("maxGroupAngleSpread")] public CFloat MaxGroupAngleSpread { get; set; }
		[Ordinal(4)]  [RED("maxGroupSize")] public CFloat MaxGroupSize { get; set; }
		[Ordinal(5)]  [RED("minDistanceLimit")] public CName MinDistanceLimit { get; set; }
		[Ordinal(6)]  [RED("minGroupAngleSpread")] public CFloat MinGroupAngleSpread { get; set; }
		[Ordinal(7)]  [RED("minGroupSize")] public CFloat MinGroupSize { get; set; }
		[Ordinal(8)]  [RED("useAngle")] public CBool UseAngle { get; set; }

		public audioGroupingShapeClassifierMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
