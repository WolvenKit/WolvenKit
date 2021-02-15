using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnOverrideReturnConditions_Operation : scnIInterruptManager_Operation
	{
		[Ordinal(0)] [RED("returnConditions")] public CArray<CHandle<scnIReturnCondition>> ReturnConditions { get; set; }

		public scnOverrideReturnConditions_Operation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
