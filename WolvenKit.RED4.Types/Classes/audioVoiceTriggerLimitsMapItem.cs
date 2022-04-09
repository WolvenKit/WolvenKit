using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceTriggerLimitsMapItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("limits")] 
		public audioVoiceTriggerLimits Limits
		{
			get => GetPropertyValue<audioVoiceTriggerLimits>();
			set => SetPropertyValue<audioVoiceTriggerLimits>(value);
		}

		public audioVoiceTriggerLimitsMapItem()
		{
			Limits = new() { Probability = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
