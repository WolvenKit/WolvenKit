using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communityVoiceTagInitializer : communitySpawnInitializer
	{
		[Ordinal(0)] 
		[RED("voiceTagName")] 
		public CName VoiceTagName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public communityVoiceTagInitializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
