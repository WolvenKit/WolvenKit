
namespace WolvenKit.RED4.Types
{
	public partial class gamedataArcadeMinigameData_Record
	{
		[RED("arcadeGameplayScreenTDBID")]
		[REDProperty(IsIgnored = true)]
		public CName ArcadeGameplayScreenTDBID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("arcadeMenuScreenTDBID")]
		[REDProperty(IsIgnored = true)]
		public CName ArcadeMenuScreenTDBID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("arcadePermanentResourceList")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> ArcadePermanentResourceList
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("arcadeScoreboardScreenTDBID")]
		[REDProperty(IsIgnored = true)]
		public CName ArcadeScoreboardScreenTDBID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("arcadeStartBackgroundMusic")]
		[REDProperty(IsIgnored = true)]
		public CName ArcadeStartBackgroundMusic
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("arcadeStopBackgroundMusic")]
		[REDProperty(IsIgnored = true)]
		public CName ArcadeStopBackgroundMusic
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("arcadeStopSFXs")]
		[REDProperty(IsIgnored = true)]
		public CName ArcadeStopSFXs
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
