using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIScriptActionDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] [RED("actionPackageType")] public CEnum<AIactionParamsPackageTypes> ActionPackageType { get; set; }

		public AIScriptActionDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
