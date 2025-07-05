using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceTriggerLimits : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("singleNpcMinRepeatTime")] 
		public CFloat SingleNpcMinRepeatTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("allNpcsMinRepeatTime")] 
		public CFloat AllNpcsMinRepeatTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("allNpcsSharingVoicesetMinRepeatTime")] 
		public CFloat AllNpcsSharingVoicesetMinRepeatTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("combatVolume")] 
		public CFloat CombatVolume
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioVoiceTriggerLimits()
		{
			Probability = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
