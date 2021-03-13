using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConditionData : CVariable
	{
		[Ordinal(0)] [RED("conditionOperator")] public CEnum<ELogicOperator> ConditionOperator { get; set; }
		[Ordinal(1)] [RED("requirementList")] public CArray<Condition> RequirementList { get; set; }

		public ConditionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
