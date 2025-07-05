using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entInjectVoiceTagEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("voiceTagName")] 
		public CName VoiceTagName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("forceInjection")] 
		public CBool ForceInjection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entInjectVoiceTagEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
