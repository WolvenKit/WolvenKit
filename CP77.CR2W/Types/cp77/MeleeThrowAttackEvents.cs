using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MeleeThrowAttackEvents : MeleeAttackGenericEvents
	{
		[Ordinal(0)]  [RED("projectileThrown")] public CBool ProjectileThrown { get; set; }
		[Ordinal(1)]  [RED("targetObject")] public wCHandle<gameObject> TargetObject { get; set; }

		public MeleeThrowAttackEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
