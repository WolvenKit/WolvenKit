using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioContextualVoiceGrunt : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("regularGrunt")] 
		public CName RegularGrunt
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("stealthGrunt")] 
		public CName StealthGrunt
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioContextualVoiceGrunt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
