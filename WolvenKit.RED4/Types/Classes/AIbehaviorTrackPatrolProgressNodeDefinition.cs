using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorTrackPatrolProgressNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("pathParameters")] 
		public CHandle<AIArgumentMapping> PathParameters
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("startFromClosestPoint")] 
		public CHandle<AIArgumentMapping> StartFromClosestPoint
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("patrolContinuationPolicy")] 
		public CHandle<AIArgumentMapping> PatrolContinuationPolicy
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("teleportPositionAfterTimeSkipping")] 
		public CHandle<AIArgumentMapping> TeleportPositionAfterTimeSkipping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("teleportRotationAfterTimeSkipping")] 
		public CHandle<AIArgumentMapping> TeleportRotationAfterTimeSkipping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("handleTeleportRequest")] 
		public CHandle<AIArgumentMapping> HandleTeleportRequest
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(8)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorTrackPatrolProgressNodeDefinition()
		{
			PathParameters = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, DefaultValue = new CVariant(), CustomTypeName = "AIPatrolPathParameters" };
			PatrolProgress = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, DefaultValue = new CVariant(), CustomTypeName = "gamePatrolSplineProgress" };
			StartFromClosestPoint = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			PatrolContinuationPolicy = new AIArgumentMapping { Type = Enums.AIArgumentType.Enum, DefaultValue = new CVariant(), CustomTypeName = "AIPatrolContinuationPolicy" };
			TeleportPositionAfterTimeSkipping = new AIArgumentMapping { Type = Enums.AIArgumentType.Vector, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Vector3" };
			TeleportRotationAfterTimeSkipping = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			HandleTeleportRequest = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			FastForwardAfterTeleport = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
