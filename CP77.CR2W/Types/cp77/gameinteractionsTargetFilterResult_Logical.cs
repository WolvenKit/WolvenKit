using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsTargetFilterResult_Logical : gametargetingSystemTargetFilterResult
	{
		public gameinteractionsTargetFilterResult_Logical(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
