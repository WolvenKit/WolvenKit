using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDriveAvSimpleTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("timeToTravel")] 
		public CHandle<AIArgumentMapping> TimeToTravel
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("distanceToTravel")] 
		public CHandle<AIArgumentMapping> DistanceToTravel
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("useEaseInFunction")] 
		public CHandle<AIArgumentMapping> UseEaseInFunction
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("useEaseOutFunction")] 
		public CHandle<AIArgumentMapping> UseEaseOutFunction
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("movementDirection")] 
		public CHandle<AIArgumentMapping> MovementDirection
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("useForwardDirection")] 
		public CHandle<AIArgumentMapping> UseForwardDirection
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("easeBounceMultiplier")] 
		public CHandle<AIArgumentMapping> EaseBounceMultiplier
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(8)] 
		[RED("despawnAtTheEnd")] 
		public CHandle<AIArgumentMapping> DespawnAtTheEnd
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(9)] 
		[RED("disableVFXs")] 
		public CHandle<AIArgumentMapping> DisableVFXs
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(10)] 
		[RED("facePlayer")] 
		public CHandle<AIArgumentMapping> FacePlayer
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(11)] 
		[RED("doLandingRotation")] 
		public CHandle<AIArgumentMapping> DoLandingRotation
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(12)] 
		[RED("interruptTaskOnLandingFound")] 
		public CHandle<AIArgumentMapping> InterruptTaskOnLandingFound
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(13)] 
		[RED("attemptToSendEarlyDismountCommand")] 
		public CHandle<AIArgumentMapping> AttemptToSendEarlyDismountCommand
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorDriveAvSimpleTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
