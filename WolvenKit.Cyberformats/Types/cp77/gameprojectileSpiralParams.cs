using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpiralParams : IScriptable
	{
		[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(2)] [RED("cycleTimeMin")] public CFloat CycleTimeMin { get; set; }
		[Ordinal(3)] [RED("cycleTimeMax")] public CFloat CycleTimeMax { get; set; }
		[Ordinal(4)] [RED("rampUpDistanceStart")] public CFloat RampUpDistanceStart { get; set; }
		[Ordinal(5)] [RED("rampUpDistanceEnd")] public CFloat RampUpDistanceEnd { get; set; }
		[Ordinal(6)] [RED("rampDownDistanceStart")] public CFloat RampDownDistanceStart { get; set; }
		[Ordinal(7)] [RED("rampDownDistanceEnd")] public CFloat RampDownDistanceEnd { get; set; }
		[Ordinal(8)] [RED("rampDownFactor")] public CFloat RampDownFactor { get; set; }
		[Ordinal(9)] [RED("randomizePhase")] public CBool RandomizePhase { get; set; }
		[Ordinal(10)] [RED("randomizeDirection")] public CBool RandomizeDirection { get; set; }

		public gameprojectileSpiralParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
