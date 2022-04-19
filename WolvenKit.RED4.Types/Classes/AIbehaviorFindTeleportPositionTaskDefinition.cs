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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
