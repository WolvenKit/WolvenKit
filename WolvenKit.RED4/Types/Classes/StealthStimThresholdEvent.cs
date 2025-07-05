using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StealthStimThresholdEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("timeThreshold")] 
		public CFloat TimeThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public StealthStimThresholdEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
