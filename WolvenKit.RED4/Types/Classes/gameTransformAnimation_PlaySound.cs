using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_PlaySound : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("unique")] 
		public CBool Unique
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameTransformAnimation_PlaySound()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
