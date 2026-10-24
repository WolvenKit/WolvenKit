using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorInstantRunAwayConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("destination")] 
		public CHandle<AIArgumentMapping> Destination
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("runOnNavmesh")] 
		public CHandle<AIArgumentMapping> RunOnNavmesh
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorInstantRunAwayConditionDefinition()
		{
			Destination = new AIArgumentMapping { Type = Enums.AIArgumentType.Vector, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Vector3" };
			RunOnNavmesh = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
