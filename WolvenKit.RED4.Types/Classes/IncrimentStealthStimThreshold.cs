using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IncrimentStealthStimThreshold : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("thresholdTimeout")] 
		public CFloat ThresholdTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public IncrimentStealthStimThreshold()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
