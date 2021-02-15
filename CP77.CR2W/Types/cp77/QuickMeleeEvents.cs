using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickMeleeEvents : WeaponEventsTransition
	{
		[Ordinal(0)] [RED("gameEffect")] public CHandle<gameEffectInstance> GameEffect { get; set; }
		[Ordinal(1)] [RED("targetObject")] public wCHandle<gameObject> TargetObject { get; set; }
		[Ordinal(2)] [RED("targetComponent")] public CHandle<entIPlacedComponent> TargetComponent { get; set; }
		[Ordinal(3)] [RED("quickMeleeAttackCreated")] public CBool QuickMeleeAttackCreated { get; set; }
		[Ordinal(4)] [RED("quickMeleeAttackData")] public QuickMeleeAttackData QuickMeleeAttackData { get; set; }

		public QuickMeleeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
