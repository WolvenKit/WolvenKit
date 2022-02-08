using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConditionGroupData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("conditions")] 
		public CArray<CHandle<GameplayConditionBase>> Conditions
		{
			get => GetPropertyValue<CArray<CHandle<GameplayConditionBase>>>();
			set => SetPropertyValue<CArray<CHandle<GameplayConditionBase>>>(value);
		}

		[Ordinal(1)] 
		[RED("logicOperator")] 
		public CEnum<ELogicOperator> LogicOperator
		{
			get => GetPropertyValue<CEnum<ELogicOperator>>();
			set => SetPropertyValue<CEnum<ELogicOperator>>(value);
		}

		public ConditionGroupData()
		{
			Conditions = new();
		}
	}
}
