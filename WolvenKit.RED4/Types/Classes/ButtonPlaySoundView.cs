using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ButtonPlaySoundView : BaseButtonView
	{
		[Ordinal(2)] 
		[RED("SoundPrefix")] 
		public CName SoundPrefix
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("PressSoundName")] 
		public CName PressSoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("HoverSoundName")] 
		public CName HoverSoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ButtonPlaySoundView()
		{
			SoundPrefix = "Button";
			PressSoundName = "OnPress";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
