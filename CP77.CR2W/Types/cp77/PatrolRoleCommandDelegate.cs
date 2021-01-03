using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PatrolRoleCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)]  [RED("forceAlerted")] public CBool ForceAlerted { get; set; }
		[Ordinal(1)]  [RED("patrolWithWeapon")] public CBool PatrolWithWeapon { get; set; }

		public PatrolRoleCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
