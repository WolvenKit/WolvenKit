using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnCheckFactReturnConditionParams : CVariable
	{
		[Ordinal(0)] [RED("factCondition")] public CHandle<scnInterruptFactConditionType> FactCondition { get; set; }

		public scnCheckFactReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
