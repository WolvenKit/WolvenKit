using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorCheckDistanceToCompanionConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		private CHandle<AIArgumentMapping> _distance;
		private CEnum<EComparisonType> _comparisonOperator;

		[Ordinal(3)] 
		[RED("distance")] 
		public CHandle<AIArgumentMapping> Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(4)] 
		[RED("comparisonOperator")] 
		public CEnum<EComparisonType> ComparisonOperator
		{
			get => GetProperty(ref _comparisonOperator);
			set => SetProperty(ref _comparisonOperator, value);
		}

		public AIbehaviorCheckDistanceToCompanionConditionDefinition()
		{
			_comparisonOperator = new() { Value = Enums.EComparisonType.Less };
		}
	}
}
