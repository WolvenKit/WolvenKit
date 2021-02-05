using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MeleeThrowAttackEvents : MeleeAttackGenericEvents
	{
		[Ordinal(8)]  [RED("projectileThrown")] public CBool ProjectileThrown { get; set; }
		[Ordinal(9)]  [RED("targetObject")] public wCHandle<gameObject> TargetObject { get; set; }

		public MeleeThrowAttackEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
