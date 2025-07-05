using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioSoundBankStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("soundBank")] 
		public CName SoundBank
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioSoundBankStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
