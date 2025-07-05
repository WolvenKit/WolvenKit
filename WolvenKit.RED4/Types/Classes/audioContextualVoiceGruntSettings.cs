using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioContextualVoiceGruntSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("painShort")] 
		public audioContextualVoiceGrunt PainShort
		{
			get => GetPropertyValue<audioContextualVoiceGrunt>();
			set => SetPropertyValue<audioContextualVoiceGrunt>(value);
		}

		[Ordinal(1)] 
		[RED("effort")] 
		public audioContextualVoiceGrunt Effort
		{
			get => GetPropertyValue<audioContextualVoiceGrunt>();
			set => SetPropertyValue<audioContextualVoiceGrunt>(value);
		}

		public audioContextualVoiceGruntSettings()
		{
			PainShort = new audioContextualVoiceGrunt();
			Effort = new audioContextualVoiceGrunt();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
