using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerCombatReturnCondition : scnIReturnCondition
	{
		[Ordinal(0)] [RED("params")] public scnCheckPlayerCombatReturnConditionParams Params { get; set; }

		public scnCheckPlayerCombatReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
