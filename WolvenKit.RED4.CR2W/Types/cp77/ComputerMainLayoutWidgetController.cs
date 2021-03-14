using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerMainLayoutWidgetController : inkWidgetLogicController
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
		private wCHandle<inkWidget> _mailsMenu;
		private wCHandle<inkWidget> _filesMenu;
		private wCHandle<inkWidget> _devicesMenu;
		private wCHandle<inkWidget> _newsFeedMenu;
		private wCHandle<inkWidget> _internetData;
		private wCHandle<inkWidget> _mainMenu;
		private wCHandle<inkWidget> _screenSaver;
		private wCHandle<inkWidget> _wallpaper;
		private CBool _isInitialized;
		private CBool _devicesMenuInitialized;
		private CBool _isWindowOpened;
		private CString _activeWindowID;
		private CEnum<EComputerMenuType> _menuToOpen;

		[Ordinal(1)] 
		[RED("screenSaverSlot")] 
		public inkWidgetReference ScreenSaverSlot
		{
			get
			{
				if (_screenSaverSlot == null)
				{
					_screenSaverSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "screenSaverSlot", cr2w, this);
				}
				return _screenSaverSlot;
			}
			set
			{
				if (_screenSaverSlot == value)
				{
					return;
				}
				_screenSaverSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("wallpaperSlot")] 
		public inkWidgetReference WallpaperSlot
		{
			get
			{
				if (_wallpaperSlot == null)
				{
					_wallpaperSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "wallpaperSlot", cr2w, this);
				}
				return _wallpaperSlot;
			}
			set
			{
				if (_wallpaperSlot == value)
				{
					return;
				}
				_wallpaperSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("menuButtonList")] 
		public inkWidgetReference MenuButtonList
		{
			get
			{
				if (_menuButtonList == null)
				{
					_menuButtonList = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuButtonList", cr2w, this);
				}
				return _menuButtonList;
			}
			set
			{
				if (_menuButtonList == value)
				{
					return;
				}
				_menuButtonList = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("menuContainer")] 
		public inkWidgetReference MenuContainer
		{
			get
			{
				if (_menuContainer == null)
				{
					_menuContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuContainer", cr2w, this);
				}
				return _menuContainer;
			}
			set
			{
				if (_menuContainer == value)
				{
					return;
				}
				_menuContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("internetContainer")] 
		public inkWidgetReference InternetContainer
		{
			get
			{
				if (_internetContainer == null)
				{
					_internetContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "internetContainer", cr2w, this);
				}
				return _internetContainer;
			}
			set
			{
				if (_internetContainer == value)
				{
					return;
				}
				_internetContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("offButton")] 
		public inkWidgetReference OffButton
		{
			get
			{
				if (_offButton == null)
				{
					_offButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "offButton", cr2w, this);
				}
				return _offButton;
			}
			set
			{
				if (_offButton == value)
				{
					return;
				}
				_offButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("windowCloseButton")] 
		public inkWidgetReference WindowCloseButton
		{
			get
			{
				if (_windowCloseButton == null)
				{
					_windowCloseButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "windowCloseButton", cr2w, this);
				}
				return _windowCloseButton;
			}
			set
			{
				if (_windowCloseButton == value)
				{
					return;
				}
				_windowCloseButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("windowContainer")] 
		public inkWidgetReference WindowContainer
		{
			get
			{
				if (_windowContainer == null)
				{
					_windowContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "windowContainer", cr2w, this);
				}
				return _windowContainer;
			}
			set
			{
				if (_windowContainer == value)
				{
					return;
				}
				_windowContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("windowHeader")] 
		public inkTextWidgetReference WindowHeader
		{
			get
			{
				if (_windowHeader == null)
				{
					_windowHeader = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "windowHeader", cr2w, this);
				}
				return _windowHeader;
			}
			set
			{
				if (_windowHeader == value)
				{
					return;
				}
				_windowHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("menuMailsID")] 
		public TweakDBID MenuMailsID
		{
			get
			{
				if (_menuMailsID == null)
				{
					_menuMailsID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "menuMailsID", cr2w, this);
				}
				return _menuMailsID;
			}
			set
			{
				if (_menuMailsID == value)
				{
					return;
				}
				_menuMailsID = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("menuFilesID")] 
		public TweakDBID MenuFilesID
		{
			get
			{
				if (_menuFilesID == null)
				{
					_menuFilesID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "menuFilesID", cr2w, this);
				}
				return _menuFilesID;
			}
			set
			{
				if (_menuFilesID == value)
				{
					return;
				}
				_menuFilesID = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("menuNewsFeedID")] 
		public TweakDBID MenuNewsFeedID
		{
			get
			{
				if (_menuNewsFeedID == null)
				{
					_menuNewsFeedID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "menuNewsFeedID", cr2w, this);
				}
				return _menuNewsFeedID;
			}
			set
			{
				if (_menuNewsFeedID == value)
				{
					return;
				}
				_menuNewsFeedID = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("menuMainID")] 
		public TweakDBID MenuMainID
		{
			get
			{
				if (_menuMainID == null)
				{
					_menuMainID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "menuMainID", cr2w, this);
				}
				return _menuMainID;
			}
			set
			{
				if (_menuMainID == value)
				{
					return;
				}
				_menuMainID = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("internetBrowserID")] 
		public TweakDBID InternetBrowserID
		{
			get
			{
				if (_internetBrowserID == null)
				{
					_internetBrowserID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "internetBrowserID", cr2w, this);
				}
				return _internetBrowserID;
			}
			set
			{
				if (_internetBrowserID == value)
				{
					return;
				}
				_internetBrowserID = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("screenSaverID")] 
		public TweakDBID ScreenSaverID
		{
			get
			{
				if (_screenSaverID == null)
				{
					_screenSaverID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "screenSaverID", cr2w, this);
				}
				return _screenSaverID;
			}
			set
			{
				if (_screenSaverID == value)
				{
					return;
				}
				_screenSaverID = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("wallpaperID")] 
		public TweakDBID WallpaperID
		{
			get
			{
				if (_wallpaperID == null)
				{
					_wallpaperID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "wallpaperID", cr2w, this);
				}
				return _wallpaperID;
			}
			set
			{
				if (_wallpaperID == value)
				{
					return;
				}
				_wallpaperID = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("windowCloseAanimation")] 
		public CName WindowCloseAanimation
		{
			get
			{
				if (_windowCloseAanimation == null)
				{
					_windowCloseAanimation = (CName) CR2WTypeManager.Create("CName", "windowCloseAanimation", cr2w, this);
				}
				return _windowCloseAanimation;
			}
			set
			{
				if (_windowCloseAanimation == value)
				{
					return;
				}
				_windowCloseAanimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("windowOpenAanimation")] 
		public CName WindowOpenAanimation
		{
			get
			{
				if (_windowOpenAanimation == null)
				{
					_windowOpenAanimation = (CName) CR2WTypeManager.Create("CName", "windowOpenAanimation", cr2w, this);
				}
				return _windowOpenAanimation;
			}
			set
			{
				if (_windowOpenAanimation == value)
				{
					return;
				}
				_windowOpenAanimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("currentScreenSaverLibraryID")] 
		public CName CurrentScreenSaverLibraryID
		{
			get
			{
				if (_currentScreenSaverLibraryID == null)
				{
					_currentScreenSaverLibraryID = (CName) CR2WTypeManager.Create("CName", "currentScreenSaverLibraryID", cr2w, this);
				}
				return _currentScreenSaverLibraryID;
			}
			set
			{
				if (_currentScreenSaverLibraryID == value)
				{
					return;
				}
				_currentScreenSaverLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("currentWallpaperLibraryID")] 
		public CName CurrentWallpaperLibraryID
		{
			get
			{
				if (_currentWallpaperLibraryID == null)
				{
					_currentWallpaperLibraryID = (CName) CR2WTypeManager.Create("CName", "currentWallpaperLibraryID", cr2w, this);
				}
				return _currentWallpaperLibraryID;
			}
			set
			{
				if (_currentWallpaperLibraryID == value)
				{
					return;
				}
				_currentWallpaperLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("computerMenuButtonWidgetsData")] 
		public CArray<SComputerMenuButtonWidgetPackage> ComputerMenuButtonWidgetsData
		{
			get
			{
				if (_computerMenuButtonWidgetsData == null)
				{
					_computerMenuButtonWidgetsData = (CArray<SComputerMenuButtonWidgetPackage>) CR2WTypeManager.Create("array:SComputerMenuButtonWidgetPackage", "computerMenuButtonWidgetsData", cr2w, this);
				}
				return _computerMenuButtonWidgetsData;
			}
			set
			{
				if (_computerMenuButtonWidgetsData == value)
				{
					return;
				}
				_computerMenuButtonWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("mailsMenu")] 
		public wCHandle<inkWidget> MailsMenu
		{
			get
			{
				if (_mailsMenu == null)
				{
					_mailsMenu = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "mailsMenu", cr2w, this);
				}
				return _mailsMenu;
			}
			set
			{
				if (_mailsMenu == value)
				{
					return;
				}
				_mailsMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("filesMenu")] 
		public wCHandle<inkWidget> FilesMenu
		{
			get
			{
				if (_filesMenu == null)
				{
					_filesMenu = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "filesMenu", cr2w, this);
				}
				return _filesMenu;
			}
			set
			{
				if (_filesMenu == value)
				{
					return;
				}
				_filesMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("devicesMenu")] 
		public wCHandle<inkWidget> DevicesMenu
		{
			get
			{
				if (_devicesMenu == null)
				{
					_devicesMenu = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "devicesMenu", cr2w, this);
				}
				return _devicesMenu;
			}
			set
			{
				if (_devicesMenu == value)
				{
					return;
				}
				_devicesMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("newsFeedMenu")] 
		public wCHandle<inkWidget> NewsFeedMenu
		{
			get
			{
				if (_newsFeedMenu == null)
				{
					_newsFeedMenu = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "newsFeedMenu", cr2w, this);
				}
				return _newsFeedMenu;
			}
			set
			{
				if (_newsFeedMenu == value)
				{
					return;
				}
				_newsFeedMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("internetData")] 
		public wCHandle<inkWidget> InternetData
		{
			get
			{
				if (_internetData == null)
				{
					_internetData = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "internetData", cr2w, this);
				}
				return _internetData;
			}
			set
			{
				if (_internetData == value)
				{
					return;
				}
				_internetData = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("mainMenu")] 
		public wCHandle<inkWidget> MainMenu
		{
			get
			{
				if (_mainMenu == null)
				{
					_mainMenu = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "mainMenu", cr2w, this);
				}
				return _mainMenu;
			}
			set
			{
				if (_mainMenu == value)
				{
					return;
				}
				_mainMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("screenSaver")] 
		public wCHandle<inkWidget> ScreenSaver
		{
			get
			{
				if (_screenSaver == null)
				{
					_screenSaver = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "screenSaver", cr2w, this);
				}
				return _screenSaver;
			}
			set
			{
				if (_screenSaver == value)
				{
					return;
				}
				_screenSaver = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("wallpaper")] 
		public wCHandle<inkWidget> Wallpaper
		{
			get
			{
				if (_wallpaper == null)
				{
					_wallpaper = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "wallpaper", cr2w, this);
				}
				return _wallpaper;
			}
			set
			{
				if (_wallpaper == value)
				{
					return;
				}
				_wallpaper = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("devicesMenuInitialized")] 
		public CBool DevicesMenuInitialized
		{
			get
			{
				if (_devicesMenuInitialized == null)
				{
					_devicesMenuInitialized = (CBool) CR2WTypeManager.Create("Bool", "devicesMenuInitialized", cr2w, this);
				}
				return _devicesMenuInitialized;
			}
			set
			{
				if (_devicesMenuInitialized == value)
				{
					return;
				}
				_devicesMenuInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("isWindowOpened")] 
		public CBool IsWindowOpened
		{
			get
			{
				if (_isWindowOpened == null)
				{
					_isWindowOpened = (CBool) CR2WTypeManager.Create("Bool", "isWindowOpened", cr2w, this);
				}
				return _isWindowOpened;
			}
			set
			{
				if (_isWindowOpened == value)
				{
					return;
				}
				_isWindowOpened = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("activeWindowID")] 
		public CString ActiveWindowID
		{
			get
			{
				if (_activeWindowID == null)
				{
					_activeWindowID = (CString) CR2WTypeManager.Create("String", "activeWindowID", cr2w, this);
				}
				return _activeWindowID;
			}
			set
			{
				if (_activeWindowID == value)
				{
					return;
				}
				_activeWindowID = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("menuToOpen")] 
		public CEnum<EComputerMenuType> MenuToOpen
		{
			get
			{
				if (_menuToOpen == null)
				{
					_menuToOpen = (CEnum<EComputerMenuType>) CR2WTypeManager.Create("EComputerMenuType", "menuToOpen", cr2w, this);
				}
				return _menuToOpen;
			}
			set
			{
				if (_menuToOpen == value)
				{
					return;
				}
				_menuToOpen = value;
				PropertySet(this);
			}
		}

		public ComputerMainLayoutWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
