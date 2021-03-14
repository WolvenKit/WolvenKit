using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckFactInterruptCondition : scnIInterruptCondition
	{
		[Ordinal(0)] [RED("params")] public scnCheckFactInterruptConditionParams Params { get; set; }

		public scnCheckFactInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
