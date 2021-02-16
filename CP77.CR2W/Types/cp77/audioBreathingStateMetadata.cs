using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioBreathingStateMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("inhaleSound")] public CName InhaleSound { get; set; }
		[Ordinal(2)] [RED("exhaleSound")] public CName ExhaleSound { get; set; }
		[Ordinal(3)] [RED("paramChangeSpeed")] public CFloat ParamChangeSpeed { get; set; }
		[Ordinal(4)] [RED("targetBpm")] public CFloat TargetBpm { get; set; }
		[Ordinal(5)] [RED("targetTimeDistortion")] public CFloat TargetTimeDistortion { get; set; }
		[Ordinal(6)] [RED("stateMinimalTime")] public CFloat StateMinimalTime { get; set; }
		[Ordinal(7)] [RED("exhaustionChangeSpeed")] public CFloat ExhaustionChangeSpeed { get; set; }
		[Ordinal(8)] [RED("targetExhaustion")] public CFloat TargetExhaustion { get; set; }
		[Ordinal(9)] [RED("loopBehavior")] public CEnum<audiobreathingLoopBehavior> LoopBehavior { get; set; }
		[Ordinal(10)] [RED("startStateFromBreath")] public CBool StartStateFromBreath { get; set; }

		public audioBreathingStateMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
