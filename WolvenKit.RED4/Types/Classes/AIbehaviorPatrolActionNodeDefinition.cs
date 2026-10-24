using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorPatrolActionNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("path")] 
		public CHandle<AIArgumentMapping> Path
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
		[RED("playStartAnimation")] 
		public CHandle<AIArgumentMapping> PlayStartAnimation
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(8)] 
		[RED("dependentWorkspotData")] 
		public CHandle<AIArgumentMapping> DependentWorkspotData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(9)] 
		[RED("lookAtTarget")] 
		public CHandle<AIArgumentMapping> LookAtTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(10)] 
		[RED("usePathContext")] 
		public CHandle<AIArgumentMapping> UsePathContext
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(11)] 
		[RED("useOffMeshLinkReservation")] 
		public CHandle<AIArgumentMapping> UseOffMeshLinkReservation
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorPatrolActionNodeDefinition()
		{
			Command = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "handle:ISerializable" };
			Path = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, DefaultValue = new CVariant(), CustomTypeName = "AIPatrolPathParameters" };
			PatrolProgress = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, DefaultValue = new CVariant(), CustomTypeName = "gamePatrolSplineProgress" };
			StartFromClosestPoint = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			PatrolContinuationPolicy = new AIArgumentMapping { Type = Enums.AIArgumentType.Enum, DefaultValue = new CVariant(), CustomTypeName = "AIPatrolContinuationPolicy" };
			PlayStartAnimation = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			FastForwardAfterTeleport = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			WorkspotData = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, DefaultValue = new CVariant(), CustomTypeName = "gameSetupWorkspotActionEvent" };
			DependentWorkspotData = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, DefaultValue = new CVariant(), CustomTypeName = "gameDependentWorkspotData" };
			UsePathContext = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			UseOffMeshLinkReservation = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
