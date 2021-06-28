using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDistanceToTargetConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _distance;
		private CEnum<EComparisonType> _comparisonOperator;

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("distance")] 
		public CHandle<AIArgumentMapping> Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(3)] 
		[RED("comparisonOperator")] 
		public CEnum<EComparisonType> ComparisonOperator
		{
			get => GetProperty(ref _comparisonOperator);
			set => SetProperty(ref _comparisonOperator, value);
		}

		public AIbehaviorDistanceToTargetConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
