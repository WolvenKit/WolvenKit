using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MeleeAttackGenericEvents : MeleeEventsTransition
	{
		[Ordinal(0)] [RED("effect")] public CHandle<gameEffectInstance> Effect { get; set; }
		[Ordinal(1)] [RED("attackCreated")] public CBool AttackCreated { get; set; }
		[Ordinal(2)] [RED("blockImpulseCreation")] public CBool BlockImpulseCreation { get; set; }
		[Ordinal(3)] [RED("standUpSend")] public CBool StandUpSend { get; set; }
		[Ordinal(4)] [RED("trailCreated")] public CBool TrailCreated { get; set; }
		[Ordinal(5)] [RED("textLayer")] public CUInt32 TextLayer { get; set; }
		[Ordinal(6)] [RED("rumblePlayed")] public CBool RumblePlayed { get; set; }
		[Ordinal(7)] [RED("shouldBlockImpulseUpdate")] public CBool ShouldBlockImpulseUpdate { get; set; }

		public MeleeAttackGenericEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
