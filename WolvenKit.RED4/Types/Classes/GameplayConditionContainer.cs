using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplayConditionContainer : IScriptable
	{
		[Ordinal(0)] 
		[RED("logicOperator")] 
		public CEnum<ELogicOperator> LogicOperator
		{
			get => GetPropertyValue<CEnum<ELogicOperator>>();
			set => SetPropertyValue<CEnum<ELogicOperator>>(value);
		}

		[Ordinal(1)] 
		[RED("conditionGroups")] 
		public CArray<ConditionGroupData> ConditionGroups
		{
			get => GetPropertyValue<CArray<ConditionGroupData>>();
			set => SetPropertyValue<CArray<ConditionGroupData>>(value);
		}

		public GameplayConditionContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
