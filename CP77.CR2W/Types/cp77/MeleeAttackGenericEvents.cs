using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MeleeAttackGenericEvents : MeleeEventsTransition
	{
		[Ordinal(0)]  [RED("attackCreated")] public CBool AttackCreated { get; set; }
		[Ordinal(1)]  [RED("blockImpulseCreation")] public CBool BlockImpulseCreation { get; set; }
		[Ordinal(2)]  [RED("effect")] public CHandle<gameEffectInstance> Effect { get; set; }
		[Ordinal(3)]  [RED("rumblePlayed")] public CBool RumblePlayed { get; set; }
		[Ordinal(4)]  [RED("shouldBlockImpulseUpdate")] public CBool ShouldBlockImpulseUpdate { get; set; }
		[Ordinal(5)]  [RED("standUpSend")] public CBool StandUpSend { get; set; }
		[Ordinal(6)]  [RED("textLayer")] public CUInt32 TextLayer { get; set; }
		[Ordinal(7)]  [RED("trailCreated")] public CBool TrailCreated { get; set; }

		public MeleeAttackGenericEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
