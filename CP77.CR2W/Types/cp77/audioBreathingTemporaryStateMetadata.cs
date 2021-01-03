using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioBreathingTemporaryStateMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("exhaleSound")] public CName ExhaleSound { get; set; }
		[Ordinal(1)]  [RED("exhaustionChangeSpeed")] public CFloat ExhaustionChangeSpeed { get; set; }
		[Ordinal(2)]  [RED("inhaleSound")] public CName InhaleSound { get; set; }
		[Ordinal(3)]  [RED("loopBehavior")] public CEnum<audiobreathingLoopBehavior> LoopBehavior { get; set; }
		[Ordinal(4)]  [RED("paramChangeSpeed")] public CFloat ParamChangeSpeed { get; set; }
		[Ordinal(5)]  [RED("startStateFromBreath")] public CBool StartStateFromBreath { get; set; }
		[Ordinal(6)]  [RED("targetBpm")] public CFloat TargetBpm { get; set; }
		[Ordinal(7)]  [RED("targetExhaustion")] public CFloat TargetExhaustion { get; set; }
		[Ordinal(8)]  [RED("targetTimeDistortion")] public CFloat TargetTimeDistortion { get; set; }
		[Ordinal(9)]  [RED("time")] public CFloat Time { get; set; }

		public audioBreathingTemporaryStateMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
