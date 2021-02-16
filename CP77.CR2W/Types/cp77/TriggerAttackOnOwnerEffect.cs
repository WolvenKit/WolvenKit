using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackOnOwnerEffect : gameEffector
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)] [RED("attackTDBID")] public TweakDBID AttackTDBID { get; set; }
		[Ordinal(2)] [RED("playerAsInstigator")] public CBool PlayerAsInstigator { get; set; }
		[Ordinal(3)] [RED("triggerHitReaction")] public CBool TriggerHitReaction { get; set; }
		[Ordinal(4)] [RED("attackPositionSlotName")] public CName AttackPositionSlotName { get; set; }

		public TriggerAttackOnOwnerEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
