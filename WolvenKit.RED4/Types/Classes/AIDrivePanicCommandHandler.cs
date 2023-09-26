using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIDrivePanicCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] 
		[RED("outAllowSimplifiedMovement")] 
		public CHandle<AIArgumentMapping> OutAllowSimplifiedMovement
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("outIgnoreTickets")] 
		public CHandle<AIArgumentMapping> OutIgnoreTickets
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("outDisableStuckDetection")] 
		public CHandle<AIArgumentMapping> OutDisableStuckDetection
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("outUseSpeedBasedLookupRange")] 
		public CHandle<AIArgumentMapping> OutUseSpeedBasedLookupRange
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("outTryDriveAwayFromPlayer")] 
		public CHandle<AIArgumentMapping> OutTryDriveAwayFromPlayer
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIDrivePanicCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
