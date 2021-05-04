using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workConditionalSequence : workSequence
	{
		private CEnum<workLogicalOperation> _multipleConditionOperator;
		private CArray<CHandle<workIWorkspotCondition>> _conditionList;

		[Ordinal(7)] 
		[RED("multipleConditionOperator")] 
		public CEnum<workLogicalOperation> MultipleConditionOperator
		{
			get => GetProperty(ref _multipleConditionOperator);
			set => SetProperty(ref _multipleConditionOperator, value);
		}

		[Ordinal(8)] 
		[RED("conditionList")] 
		public CArray<CHandle<workIWorkspotCondition>> ConditionList
		{
			get => GetProperty(ref _conditionList);
			set => SetProperty(ref _conditionList, value);
		}

		public workConditionalSequence(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
