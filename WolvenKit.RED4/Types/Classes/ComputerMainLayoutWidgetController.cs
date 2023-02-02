using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerMainLayoutWidgetController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("screenSaverSlot")] 
		public inkWidgetReference ScreenSaverSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("wallpaperSlot")] 
		public inkWidgetReference WallpaperSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("menuButtonList")] 
		public inkWidgetReference MenuButtonList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("menuContainer")] 
		public inkWidgetReference MenuContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("internetContainer")] 
		public inkWidgetReference InternetContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("offButton")] 
		public inkWidgetReference OffButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("windowCloseButton")] 
		public inkWidgetReference WindowCloseButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("windowContainer")] 
		public inkWidgetReference WindowContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("windowHeader")] 
		public inkTextWidgetReference WindowHeader
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("menuMailsID")] 
		public TweakDBID MenuMailsID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(11)] 
		[RED("menuFilesID")] 
		public TweakDBID MenuFilesID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(12)] 
		[RED("menuNewsFeedID")] 
		public TweakDBID MenuNewsFeedID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(13)] 
		[RED("menuMainID")] 
		public TweakDBID MenuMainID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(14)] 
		[RED("internetBrowserID")] 
		public TweakDBID InternetBrowserID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(15)] 
		[RED("screenSaverID")] 
		public TweakDBID ScreenSaverID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(16)] 
		[RED("wallpaperID")] 
		public TweakDBID WallpaperID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(17)] 
		[RED("windowCloseAanimation")] 
		public CName WindowCloseAanimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("windowOpenAanimation")] 
		public CName WindowOpenAanimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("currentScreenSaverLibraryID")] 
		public CName CurrentScreenSaverLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("currentWallpaperLibraryID")] 
		public CName CurrentWallpaperLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("computerMenuButtonWidgetsData")] 
		public CArray<SComputerMenuButtonWidgetPackage> ComputerMenuButtonWidgetsData
		{
			get => GetPropertyValue<CArray<SComputerMenuButtonWidgetPackage>>();
			set => SetPropertyValue<CArray<SComputerMenuButtonWidgetPackage>>(value);
		}

		[Ordinal(22)] 
		[RED("mailsMenu")] 
		public CWeakHandle<inkWidget> MailsMenu
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(23)] 
		[RED("filesMenu")] 
		public CWeakHandle<inkWidget> FilesMenu
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(24)] 
		[RED("devicesMenu")] 
		public CWeakHandle<inkWidget> DevicesMenu
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(25)] 
		[RED("newsFeedMenu")] 
		public CWeakHandle<inkWidget> NewsFeedMenu
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(26)] 
		[RED("internetData")] 
		public CWeakHandle<inkWidget> InternetData
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("mainMenu")] 
		public CWeakHandle<inkWidget> MainMenu
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(28)] 
		[RED("screenSaver")] 
		public CWeakHandle<inkWidget> ScreenSaver
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(29)] 
		[RED("wallpaper")] 
		public CWeakHandle<inkWidget> Wallpaper
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(30)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("devicesMenuInitialized")] 
		public CBool DevicesMenuInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("isWindowOpened")] 
		public CBool IsWindowOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("activeWindowID")] 
		public CString ActiveWindowID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(34)] 
		[RED("menuToOpen")] 
		public CEnum<EComputerMenuType> MenuToOpen
		{
			get => GetPropertyValue<CEnum<EComputerMenuType>>();
			set => SetPropertyValue<CEnum<EComputerMenuType>>(value);
		}

		public ComputerMainLayoutWidgetController()
		{
			ScreenSaverSlot = new();
			WallpaperSlot = new();
			MenuButtonList = new();
			MenuContainer = new();
			InternetContainer = new();
			OffButton = new();
			WindowCloseButton = new();
			WindowContainer = new();
			WindowHeader = new();
			WindowCloseAanimation = "windowClose_16x9";
			WindowOpenAanimation = "windowOpen_16x9";
			ComputerMenuButtonWidgetsData = new();
			MenuToOpen = Enums.EComputerMenuType.INVALID;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
