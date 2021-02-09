using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MeleeHitEvent : redEvent
	{
		[Ordinal(0)]  [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(1)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(2)]  [RED("isStrongAttack")] public CBool IsStrongAttack { get; set; }
		[Ordinal(3)]  [RED("hitBlocked")] public CBool HitBlocked { get; set; }

		public MeleeHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
