using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayConditionContainer : IScriptable
	{
		private CEnum<ELogicOperator> _logicOperator;
		private CArray<ConditionGroupData> _conditionGroups;

		[Ordinal(0)] 
		[RED("logicOperator")] 
		public CEnum<ELogicOperator> LogicOperator
		{
			get => GetProperty(ref _logicOperator);
			set => SetProperty(ref _logicOperator, value);
		}

		[Ordinal(1)] 
		[RED("conditionGroups")] 
		public CArray<ConditionGroupData> ConditionGroups
		{
			get => GetProperty(ref _conditionGroups);
			set => SetProperty(ref _conditionGroups, value);
		}
	}
}
