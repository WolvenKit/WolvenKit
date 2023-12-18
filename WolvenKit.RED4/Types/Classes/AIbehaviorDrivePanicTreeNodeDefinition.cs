using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDrivePanicTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("allowSimplifiedMovement")] 
		public CHandle<AIArgumentMapping> AllowSimplifiedMovement
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("ignoreTickets")] 
		public CHandle<AIArgumentMapping> IgnoreTickets
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("disableStuckDetection")] 
		public CHandle<AIArgumentMapping> DisableStuckDetection
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("useSpeedBasedLookupRange")] 
		public CHandle<AIArgumentMapping> UseSpeedBasedLookupRange
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("tryDriveAwayFromPlayer")] 
		public CHandle<AIArgumentMapping> TryDriveAwayFromPlayer
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("needDriver")] 
		public CHandle<AIArgumentMapping> NeedDriver
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorDrivePanicTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
