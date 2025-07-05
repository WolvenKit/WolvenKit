
namespace WolvenKit.RED4.Types
{
	public partial class gamedataInitLoadingScreen_Record
	{
		[RED("firstAnimLibraryName")]
		[REDProperty(IsIgnored = true)]
		public CName FirstAnimLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("firstAnimName")]
		[REDProperty(IsIgnored = true)]
		public CName FirstAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("isBase")]
		[REDProperty(IsIgnored = true)]
		public CBool IsBase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("loadingScreenResource")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> LoadingScreenResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("loopAnimName")]
		[REDProperty(IsIgnored = true)]
		public CName LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("mainMenuAnimName")]
		[REDProperty(IsIgnored = true)]
		public CName MainMenuAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("mainMenuLibraryName")]
		[REDProperty(IsIgnored = true)]
		public CName MainMenuLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("mainMenuLoopAnimName")]
		[REDProperty(IsIgnored = true)]
		public CName MainMenuLoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("mainMenuResource")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> MainMenuResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("secondAnimLibraryName")]
		[REDProperty(IsIgnored = true)]
		public CName SecondAnimLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("secondAnimName")]
		[REDProperty(IsIgnored = true)]
		public CName SecondAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("thirdAnimLibraryName")]
		[REDProperty(IsIgnored = true)]
		public CName ThirdAnimLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("thirdAnimName")]
		[REDProperty(IsIgnored = true)]
		public CName ThirdAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("voTrackAnimName")]
		[REDProperty(IsIgnored = true)]
		public CName VoTrackAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
