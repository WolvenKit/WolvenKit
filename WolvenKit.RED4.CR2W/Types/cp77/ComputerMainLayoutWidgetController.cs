using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerMainLayoutWidgetController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("screenSaverSlot")] public inkWidgetReference ScreenSaverSlot { get; set; }
		[Ordinal(2)] [RED("wallpaperSlot")] public inkWidgetReference WallpaperSlot { get; set; }
		[Ordinal(3)] [RED("menuButtonList")] public inkWidgetReference MenuButtonList { get; set; }
		[Ordinal(4)] [RED("menuContainer")] public inkWidgetReference MenuContainer { get; set; }
		[Ordinal(5)] [RED("internetContainer")] public inkWidgetReference InternetContainer { get; set; }
		[Ordinal(6)] [RED("offButton")] public inkWidgetReference OffButton { get; set; }
		[Ordinal(7)] [RED("windowCloseButton")] public inkWidgetReference WindowCloseButton { get; set; }
		[Ordinal(8)] [RED("windowContainer")] public inkWidgetReference WindowContainer { get; set; }
		[Ordinal(9)] [RED("windowHeader")] public inkTextWidgetReference WindowHeader { get; set; }
		[Ordinal(10)] [RED("menuMailsID")] public TweakDBID MenuMailsID { get; set; }
		[Ordinal(11)] [RED("menuFilesID")] public TweakDBID MenuFilesID { get; set; }
		[Ordinal(12)] [RED("menuNewsFeedID")] public TweakDBID MenuNewsFeedID { get; set; }
		[Ordinal(13)] [RED("menuMainID")] public TweakDBID MenuMainID { get; set; }
		[Ordinal(14)] [RED("internetBrowserID")] public TweakDBID InternetBrowserID { get; set; }
		[Ordinal(15)] [RED("screenSaverID")] public TweakDBID ScreenSaverID { get; set; }
		[Ordinal(16)] [RED("wallpaperID")] public TweakDBID WallpaperID { get; set; }
		[Ordinal(17)] [RED("windowCloseAanimation")] public CName WindowCloseAanimation { get; set; }
		[Ordinal(18)] [RED("windowOpenAanimation")] public CName WindowOpenAanimation { get; set; }
		[Ordinal(19)] [RED("currentScreenSaverLibraryID")] public CName CurrentScreenSaverLibraryID { get; set; }
		[Ordinal(20)] [RED("currentWallpaperLibraryID")] public CName CurrentWallpaperLibraryID { get; set; }
		[Ordinal(21)] [RED("computerMenuButtonWidgetsData")] public CArray<SComputerMenuButtonWidgetPackage> ComputerMenuButtonWidgetsData { get; set; }
		[Ordinal(22)] [RED("mailsMenu")] public wCHandle<inkWidget> MailsMenu { get; set; }
		[Ordinal(23)] [RED("filesMenu")] public wCHandle<inkWidget> FilesMenu { get; set; }
		[Ordinal(24)] [RED("devicesMenu")] public wCHandle<inkWidget> DevicesMenu { get; set; }
		[Ordinal(25)] [RED("newsFeedMenu")] public wCHandle<inkWidget> NewsFeedMenu { get; set; }
		[Ordinal(26)] [RED("internetData")] public wCHandle<inkWidget> InternetData { get; set; }
		[Ordinal(27)] [RED("mainMenu")] public wCHandle<inkWidget> MainMenu { get; set; }
		[Ordinal(28)] [RED("screenSaver")] public wCHandle<inkWidget> ScreenSaver { get; set; }
		[Ordinal(29)] [RED("wallpaper")] public wCHandle<inkWidget> Wallpaper { get; set; }
		[Ordinal(30)] [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(31)] [RED("devicesMenuInitialized")] public CBool DevicesMenuInitialized { get; set; }
		[Ordinal(32)] [RED("isWindowOpened")] public CBool IsWindowOpened { get; set; }
		[Ordinal(33)] [RED("activeWindowID")] public CString ActiveWindowID { get; set; }
		[Ordinal(34)] [RED("menuToOpen")] public CEnum<EComputerMenuType> MenuToOpen { get; set; }

		public ComputerMainLayoutWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
