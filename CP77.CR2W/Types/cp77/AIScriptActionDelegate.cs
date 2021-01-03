using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIScriptActionDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)]  [RED("actionPackageType")] public CEnum<AIactionParamsPackageTypes> ActionPackageType { get; set; }

		public AIScriptActionDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
