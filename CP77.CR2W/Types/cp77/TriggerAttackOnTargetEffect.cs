using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackOnTargetEffect : gameEffector
	{
		[Ordinal(0)]  [RED("applicationChance")] public CFloat ApplicationChance { get; set; }
		[Ordinal(1)]  [RED("attack")] public CHandle<gameAttack_GameEffect> Attack { get; set; }
		[Ordinal(2)]  [RED("attackTDBID")] public TweakDBID AttackTDBID { get; set; }
		[Ordinal(3)]  [RED("isRandom")] public CBool IsRandom { get; set; }
		[Ordinal(4)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public TriggerAttackOnTargetEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
