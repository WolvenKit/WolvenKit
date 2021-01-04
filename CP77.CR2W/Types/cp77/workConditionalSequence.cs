using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workConditionalSequence : workSequence
	{
		[Ordinal(0)]  [RED("conditionList")] public CArray<CHandle<workIWorkspotCondition>> ConditionList { get; set; }
		[Ordinal(1)]  [RED("multipleConditionOperator")] public CEnum<workLogicalOperation> MultipleConditionOperator { get; set; }

		public workConditionalSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
