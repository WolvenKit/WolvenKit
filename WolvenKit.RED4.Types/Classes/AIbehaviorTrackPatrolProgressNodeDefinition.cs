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
		[RED("teleportPositionAfterTimeSkipping")] 
		public CHandle<AIArgumentMapping> TeleportPositionAfterTimeSkipping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("teleportRotationAfterTimeSkipping")] 
		public CHandle<AIArgumentMapping> TeleportRotationAfterTimeSkipping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("handleTeleportRequest")] 
		public CHandle<AIArgumentMapping> HandleTeleportRequest
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorTrackPatrolProgressNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
