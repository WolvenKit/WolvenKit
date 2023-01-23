using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HearStimThreshold : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("thresholdNumber")] 
		public CInt32 ThresholdNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public HearStimThreshold()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
