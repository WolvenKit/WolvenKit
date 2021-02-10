using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeMenuController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("ps4InputLibraryId")] public CName Ps4InputLibraryId { get; set; }
		[Ordinal(1)]  [RED("xboxInputLibraryId")] public CName XboxInputLibraryId { get; set; }
		[Ordinal(2)]  [RED("ps4InputWidget")] public wCHandle<inkWidget> Ps4InputWidget { get; set; }
		[Ordinal(3)]  [RED("xboxInputWidget")] public wCHandle<inkWidget> XboxInputWidget { get; set; }
		[Ordinal(4)]  [RED("SetAttributeOptionEnabled")] public gameuiSetPhotoModeKeyEnabledCallback SetAttributeOptionEnabled { get; set; }
		[Ordinal(5)]  [RED("SetCategoryEnabled")] public gameuiSetPhotoModeKeyEnabledCallback SetCategoryEnabled { get; set; }
		[Ordinal(6)]  [RED("menuListRoot")] public inkWidgetReference MenuListRoot { get; set; }
		[Ordinal(7)]  [RED("radioButtons")] public inkCompoundWidgetReference RadioButtons { get; set; }
		[Ordinal(8)]  [RED("listContainerId")] public CName ListContainerId { get; set; }
		[Ordinal(9)]  [RED("menuArea")] public inkWidgetReference MenuArea { get; set; }
		[Ordinal(10)]  [RED("inputCameraKbd")] public inkWidgetReference InputCameraKbd { get; set; }
		[Ordinal(11)]  [RED("inputCameraPad")] public inkWidgetReference InputCameraPad { get; set; }
		[Ordinal(12)]  [RED("inputStickersKbd")] public inkWidgetReference InputStickersKbd { get; set; }
		[Ordinal(13)]  [RED("inputStickersPad")] public inkWidgetReference InputStickersPad { get; set; }
		[Ordinal(14)]  [RED("inputSaveLoadKbd")] public inkWidgetReference InputSaveLoadKbd { get; set; }
		[Ordinal(15)]  [RED("inputSaveLoadPad")] public inkWidgetReference InputSaveLoadPad { get; set; }
		[Ordinal(16)]  [RED("inputExit")] public inkWidgetReference InputExit { get; set; }
		[Ordinal(17)]  [RED("inputScreenshot")] public inkWidgetReference InputScreenshot { get; set; }
		[Ordinal(18)]  [RED("cameraLocation")] public inkWidgetReference CameraLocation { get; set; }
		[Ordinal(19)]  [RED("inputBottomRoot")] public inkHorizontalPanelWidgetReference InputBottomRoot { get; set; }
		[Ordinal(20)]  [RED("menuPages")] public CArray<wCHandle<inkWidget>> MenuPages { get; set; }
		[Ordinal(21)]  [RED("topButtonsController")] public wCHandle<PhotoModeTopBarController> TopButtonsController { get; set; }
		[Ordinal(22)]  [RED("cameraLocationController")] public wCHandle<PhotoModeCameraLocation> CameraLocationController { get; set; }
		[Ordinal(23)]  [RED("currentPage")] public CUInt32 CurrentPage { get; set; }
		[Ordinal(24)]  [RED("IsHoverOver")] public CBool IsHoverOver { get; set; }
		[Ordinal(25)]  [RED("holdSafeguard")] public CBool HoldSafeguard { get; set; }
		[Ordinal(26)]  [RED("notificationUserData")] public CHandle<inkGameNotificationData> NotificationUserData { get; set; }
		[Ordinal(27)]  [RED("notificationToken")] public CHandle<inkGameNotificationToken> NotificationToken { get; set; }
		[Ordinal(28)]  [RED("loopAnimproxy")] public CHandle<inkanimProxy> LoopAnimproxy { get; set; }

		public gameuiPhotoModeMenuController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
