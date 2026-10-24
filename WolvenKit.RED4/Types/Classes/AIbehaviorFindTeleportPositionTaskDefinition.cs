using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorFindTeleportPositionTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("patrolPath")] 
		public CHandle<AIArgumentMapping> PatrolPath
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("teleportPosition")] 
		public CHandle<AIArgumentMapping> TeleportPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("teleportRotation")] 
		public CHandle<AIArgumentMapping> TeleportRotation
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorFindTeleportPositionTaskDefinition()
		{
			PatrolPath = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, DefaultValue = new CVariant(), CustomTypeName = "AIPatrolPathParameters" };
			TeleportPosition = new AIArgumentMapping { Type = Enums.AIArgumentType.Vector, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Vector3" };
			TeleportRotation = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
