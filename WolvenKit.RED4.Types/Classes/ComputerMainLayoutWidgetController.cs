using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ComputerMainLayoutWidgetController : inkWidgetLogicController
	{
		private inkWidgetReference _screenSaverSlot;
		private inkWidgetReference _wallpaperSlot;
		private inkWidgetReference _menuButtonList;
		private inkWidgetReference _menuContainer;
		private inkWidgetReference _internetContainer;
		private inkWidgetReference _offButton;
		private inkWidgetReference _windowCloseButton;
		private inkWidgetReference _windowContainer;
		private inkTextWidgetReference _windowHeader;
		private TweakDBID _menuMailsID;
		private TweakDBID _menuFilesID;
		private TweakDBID _menuNewsFeedID;
		private TweakDBID _menuMainID;
		private TweakDBID _internetBrowserID;
		private TweakDBID _screenSaverID;
		private TweakDBID _wallpaperID;
		private CName _windowCloseAanimation;
		private CName _windowOpenAanimation;
		private CName _currentScreenSaverLibraryID;
		private CName _currentWallpaperLibraryID;
		private CArray<SComputerMenuButtonWidgetPackage> _computerMenuButtonWidgetsData;
		private CWeakHandle<inkWidget> _mailsMenu;
		private CWeakHandle<inkWidget> _filesMenu;
		private CWeakHandle<inkWidget> _devicesMenu;
		private CWeakHandle<inkWidget> _newsFeedMenu;
		private CWeakHandle<inkWidget> _internetData;
		private CWeakHandle<inkWidget> _mainMenu;
		private CWeakHandle<inkWidget> _screenSaver;
		private CWeakHandle<inkWidget> _wallpaper;
		private CBool _isInitialized;
		private CBool _devicesMenuInitialized;
		private CBool _isWindowOpened;
		private CString _activeWindowID;
		private CEnum<EComputerMenuType> _menuToOpen;

		[Ordinal(1)] 
		[RED("screenSaverSlot")] 
		public inkWidgetReference ScreenSaverSlot
		{
			get => GetProperty(ref _screenSaverSlot);
			set => SetProperty(ref _screenSaverSlot, value);
		}

		[Ordinal(2)] 
		[RED("wallpaperSlot")] 
		public inkWidgetReference WallpaperSlot
		{
			get => GetProperty(ref _wallpaperSlot);
			set => SetProperty(ref _wallpaperSlot, value);
		}

		[Ordinal(3)] 
		[RED("menuButtonList")] 
		public inkWidgetReference MenuButtonList
		{
			get => GetProperty(ref _menuButtonList);
			set => SetProperty(ref _menuButtonList, value);
		}

		[Ordinal(4)] 
		[RED("menuContainer")] 
		public inkWidgetReference MenuContainer
		{
			get => GetProperty(ref _menuContainer);
			set => SetProperty(ref _menuContainer, value);
		}

		[Ordinal(5)] 
		[RED("internetContainer")] 
		public inkWidgetReference InternetContainer
		{
			get => GetProperty(ref _internetContainer);
			set => SetProperty(ref _internetContainer, value);
		}

		[Ordinal(6)] 
		[RED("offButton")] 
		public inkWidgetReference OffButton
		{
			get => GetProperty(ref _offButton);
			set => SetProperty(ref _offButton, value);
		}

		[Ordinal(7)] 
		[RED("windowCloseButton")] 
		public inkWidgetReference WindowCloseButton
		{
			get => GetProperty(ref _windowCloseButton);
			set => SetProperty(ref _windowCloseButton, value);
		}

		[Ordinal(8)] 
		[RED("windowContainer")] 
		public inkWidgetReference WindowContainer
		{
			get => GetProperty(ref _windowContainer);
			set => SetProperty(ref _windowContainer, value);
		}

		[Ordinal(9)] 
		[RED("windowHeader")] 
		public inkTextWidgetReference WindowHeader
		{
			get => GetProperty(ref _windowHeader);
			set => SetProperty(ref _windowHeader, value);
		}

		[Ordinal(10)] 
		[RED("menuMailsID")] 
		public TweakDBID MenuMailsID
		{
			get => GetProperty(ref _menuMailsID);
			set => SetProperty(ref _menuMailsID, value);
		}

		[Ordinal(11)] 
		[RED("menuFilesID")] 
		public TweakDBID MenuFilesID
		{
			get => GetProperty(ref _menuFilesID);
			set => SetProperty(ref _menuFilesID, value);
		}

		[Ordinal(12)] 
		[RED("menuNewsFeedID")] 
		public TweakDBID MenuNewsFeedID
		{
			get => GetProperty(ref _menuNewsFeedID);
			set => SetProperty(ref _menuNewsFeedID, value);
		}

		[Ordinal(13)] 
		[RED("menuMainID")] 
		public TweakDBID MenuMainID
		{
			get => GetProperty(ref _menuMainID);
			set => SetProperty(ref _menuMainID, value);
		}

		[Ordinal(14)] 
		[RED("internetBrowserID")] 
		public TweakDBID InternetBrowserID
		{
			get => GetProperty(ref _internetBrowserID);
			set => SetProperty(ref _internetBrowserID, value);
		}

		[Ordinal(15)] 
		[RED("screenSaverID")] 
		public TweakDBID ScreenSaverID
		{
			get => GetProperty(ref _screenSaverID);
			set => SetProperty(ref _screenSaverID, value);
		}

		[Ordinal(16)] 
		[RED("wallpaperID")] 
		public TweakDBID WallpaperID
		{
			get => GetProperty(ref _wallpaperID);
			set => SetProperty(ref _wallpaperID, value);
		}

		[Ordinal(17)] 
		[RED("windowCloseAanimation")] 
		public CName WindowCloseAanimation
		{
			get => GetProperty(ref _windowCloseAanimation);
			set => SetProperty(ref _windowCloseAanimation, value);
		}

		[Ordinal(18)] 
		[RED("windowOpenAanimation")] 
		public CName WindowOpenAanimation
		{
			get => GetProperty(ref _windowOpenAanimation);
			set => SetProperty(ref _windowOpenAanimation, value);
		}

		[Ordinal(19)] 
		[RED("currentScreenSaverLibraryID")] 
		public CName CurrentScreenSaverLibraryID
		{
			get => GetProperty(ref _currentScreenSaverLibraryID);
			set => SetProperty(ref _currentScreenSaverLibraryID, value);
		}

		[Ordinal(20)] 
		[RED("currentWallpaperLibraryID")] 
		public CName CurrentWallpaperLibraryID
		{
			get => GetProperty(ref _currentWallpaperLibraryID);
			set => SetProperty(ref _currentWallpaperLibraryID, value);
		}

		[Ordinal(21)] 
		[RED("computerMenuButtonWidgetsData")] 
		public CArray<SComputerMenuButtonWidgetPackage> ComputerMenuButtonWidgetsData
		{
			get => GetProperty(ref _computerMenuButtonWidgetsData);
			set => SetProperty(ref _computerMenuButtonWidgetsData, value);
		}

		[Ordinal(22)] 
		[RED("mailsMenu")] 
		public CWeakHandle<inkWidget> MailsMenu
		{
			get => GetProperty(ref _mailsMenu);
			set => SetProperty(ref _mailsMenu, value);
		}

		[Ordinal(23)] 
		[RED("filesMenu")] 
		public CWeakHandle<inkWidget> FilesMenu
		{
			get => GetProperty(ref _filesMenu);
			set => SetProperty(ref _filesMenu, value);
		}

		[Ordinal(24)] 
		[RED("devicesMenu")] 
		public CWeakHandle<inkWidget> DevicesMenu
		{
			get => GetProperty(ref _devicesMenu);
			set => SetProperty(ref _devicesMenu, value);
		}

		[Ordinal(25)] 
		[RED("newsFeedMenu")] 
		public CWeakHandle<inkWidget> NewsFeedMenu
		{
			get => GetProperty(ref _newsFeedMenu);
			set => SetProperty(ref _newsFeedMenu, value);
		}

		[Ordinal(26)] 
		[RED("internetData")] 
		public CWeakHandle<inkWidget> InternetData
		{
			get => GetProperty(ref _internetData);
			set => SetProperty(ref _internetData, value);
		}

		[Ordinal(27)] 
		[RED("mainMenu")] 
		public CWeakHandle<inkWidget> MainMenu
		{
			get => GetProperty(ref _mainMenu);
			set => SetProperty(ref _mainMenu, value);
		}

		[Ordinal(28)] 
		[RED("screenSaver")] 
		public CWeakHandle<inkWidget> ScreenSaver
		{
			get => GetProperty(ref _screenSaver);
			set => SetProperty(ref _screenSaver, value);
		}

		[Ordinal(29)] 
		[RED("wallpaper")] 
		public CWeakHandle<inkWidget> Wallpaper
		{
			get => GetProperty(ref _wallpaper);
			set => SetProperty(ref _wallpaper, value);
		}

		[Ordinal(30)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(31)] 
		[RED("devicesMenuInitialized")] 
		public CBool DevicesMenuInitialized
		{
			get => GetProperty(ref _devicesMenuInitialized);
			set => SetProperty(ref _devicesMenuInitialized, value);
		}

		[Ordinal(32)] 
		[RED("isWindowOpened")] 
		public CBool IsWindowOpened
		{
			get => GetProperty(ref _isWindowOpened);
			set => SetProperty(ref _isWindowOpened, value);
		}

		[Ordinal(33)] 
		[RED("activeWindowID")] 
		public CString ActiveWindowID
		{
			get => GetProperty(ref _activeWindowID);
			set => SetProperty(ref _activeWindowID, value);
		}

		[Ordinal(34)] 
		[RED("menuToOpen")] 
		public CEnum<EComputerMenuType> MenuToOpen
		{
			get => GetProperty(ref _menuToOpen);
			set => SetProperty(ref _menuToOpen, value);
		}

		public ComputerMainLayoutWidgetController()
		{
			_windowCloseAanimation = "windowClose_16x9";
			_windowOpenAanimation = "windowOpen_16x9";
			_menuToOpen = new() { Value = Enums.EComputerMenuType.INVALID };
		}
	}
}
