using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIScriptActionDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] [RED("actionPackageType")] public CEnum<AIactionParamsPackageTypes> ActionPackageType { get; set; }

		public AIScriptActionDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
