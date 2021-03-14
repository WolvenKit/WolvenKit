using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workConditionalSequence : workSequence
	{
		[Ordinal(7)] [RED("multipleConditionOperator")] public CEnum<workLogicalOperation> MultipleConditionOperator { get; set; }
		[Ordinal(8)] [RED("conditionList")] public CArray<CHandle<workIWorkspotCondition>> ConditionList { get; set; }

		public workConditionalSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
