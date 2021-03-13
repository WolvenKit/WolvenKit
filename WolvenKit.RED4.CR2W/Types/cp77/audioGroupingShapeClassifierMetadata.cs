using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGroupingShapeClassifierMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("useAngle")] public CBool UseAngle { get; set; }
		[Ordinal(2)] [RED("minGroupSize")] public CFloat MinGroupSize { get; set; }
		[Ordinal(3)] [RED("maxGroupSize")] public CFloat MaxGroupSize { get; set; }
		[Ordinal(4)] [RED("minGroupAngleSpread")] public CFloat MinGroupAngleSpread { get; set; }
		[Ordinal(5)] [RED("maxGroupAngleSpread")] public CFloat MaxGroupAngleSpread { get; set; }
		[Ordinal(6)] [RED("floorLimit")] public CBool FloorLimit { get; set; }
		[Ordinal(7)] [RED("ceilingLimit")] public CBool CeilingLimit { get; set; }
		[Ordinal(8)] [RED("minDistanceLimit")] public CName MinDistanceLimit { get; set; }
		[Ordinal(9)] [RED("maxDistanceLimit")] public CName MaxDistanceLimit { get; set; }

		public audioGroupingShapeClassifierMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
