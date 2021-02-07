using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioBreathingTemporaryStateMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("inhaleSound")] public CName InhaleSound { get; set; }
		[Ordinal(1)]  [RED("exhaleSound")] public CName ExhaleSound { get; set; }
		[Ordinal(2)]  [RED("paramChangeSpeed")] public CFloat ParamChangeSpeed { get; set; }
		[Ordinal(3)]  [RED("targetBpm")] public CFloat TargetBpm { get; set; }
		[Ordinal(4)]  [RED("targetTimeDistortion")] public CFloat TargetTimeDistortion { get; set; }
		[Ordinal(5)]  [RED("time")] public CFloat Time { get; set; }
		[Ordinal(6)]  [RED("exhaustionChangeSpeed")] public CFloat ExhaustionChangeSpeed { get; set; }
		[Ordinal(7)]  [RED("targetExhaustion")] public CFloat TargetExhaustion { get; set; }
		[Ordinal(8)]  [RED("loopBehavior")] public CEnum<audiobreathingLoopBehavior> LoopBehavior { get; set; }
		[Ordinal(9)]  [RED("startStateFromBreath")] public CBool StartStateFromBreath { get; set; }

		public audioBreathingTemporaryStateMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
