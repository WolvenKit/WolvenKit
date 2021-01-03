using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workConditionalSequence : workSequence
	{
		[Ordinal(0)]  [RED("conditionList")] public CArray<CHandle<workIWorkspotCondition>> ConditionList { get; set; }
		[Ordinal(1)]  [RED("multipleConditionOperator")] public CEnum<workLogicalOperation> MultipleConditionOperator { get; set; }

		public workConditionalSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
