using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InitializationSoundController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("soundControlName")] 
		public CName SoundControlName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("initializeSoundName")] 
		public CName InitializeSoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("unitializeSoundName")] 
		public CName UnitializeSoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public InitializationSoundController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
