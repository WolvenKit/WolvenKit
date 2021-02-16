using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackByChanceEffector : gameEffector
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)] [RED("attackTDBID")] public TweakDBID AttackTDBID { get; set; }
		[Ordinal(2)] [RED("chance")] public CFloat Chance { get; set; }

		public TriggerAttackByChanceEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
