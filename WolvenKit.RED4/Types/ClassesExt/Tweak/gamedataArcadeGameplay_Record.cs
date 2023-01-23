
namespace WolvenKit.RED4.Types
{
	public partial class gamedataArcadeGameplay_Record
	{
		[RED("arcadeGameplayPausedSFX")]
		[REDProperty(IsIgnored = true)]
		public CName ArcadeGameplayPausedSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("arcadeGameplaySilentBackgroundMusic")]
		[REDProperty(IsIgnored = true)]
		public CName ArcadeGameplaySilentBackgroundMusic
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
