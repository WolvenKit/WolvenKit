using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCheckDistanceToCompanionConditionDefinition : AIbehaviorCompanionConditionDefinition
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

		public AIbehaviorCheckDistanceToCompanionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
