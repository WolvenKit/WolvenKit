using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorFindLaneTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("pointOnLane")] 
		public CHandle<AIArgumentMapping> PointOnLane
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("filter")] 
		public CEnum<worldFindLaneFilter> Filter
		{
			get => GetPropertyValue<CEnum<worldFindLaneFilter>>();
			set => SetPropertyValue<CEnum<worldFindLaneFilter>>(value);
		}

		public AIbehaviorFindLaneTaskDefinition()
		{
			PointOnLane = new AIArgumentMapping { Type = Enums.AIArgumentType.Vector, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Vector3" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
