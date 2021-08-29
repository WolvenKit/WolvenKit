using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConditionGroupData : RedBaseClass
	{
		private CArray<CHandle<GameplayConditionBase>> _conditions;
		private CEnum<ELogicOperator> _logicOperator;

		[Ordinal(0)] 
		[RED("conditions")] 
		public CArray<CHandle<GameplayConditionBase>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}

		[Ordinal(1)] 
		[RED("logicOperator")] 
		public CEnum<ELogicOperator> LogicOperator
		{
			get => GetProperty(ref _logicOperator);
			set => SetProperty(ref _logicOperator, value);
		}
	}
}
