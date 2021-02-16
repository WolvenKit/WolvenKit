using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckPathToCombatTarget : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("path")] public CHandle<worldNavigationScriptPath> Path { get; set; }

		public CheckPathToCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
