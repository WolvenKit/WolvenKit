using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeMenuController : gameuiWidgetGameController
	{
		private gameuiSetPhotoModeKeyEnabledCallback _setAttributeOptionEnabled;
		private gameuiSetPhotoModeKeyEnabledCallback _setCategoryEnabled;
		private gameuiStickerImageCallback _setStickerImage;
		private inkWidgetReference _menuListRoot;
		private inkWidgetReference _additionalListRoot;
		private inkCompoundWidgetReference _radioButtons;
		private CName _listContainerId;
		private inkWidgetReference _menuArea;
		private inkWidgetReference _additionalMenuArea;
		private inkWidgetReference _inputCameraKbd;
		private inkWidgetReference _inputCameraPad;
		private inkWidgetReference _inputStickersKbd;
		private inkWidgetReference _inputStickersPad;
		private inkWidgetReference _inputSaveLoadKbd;
		private inkWidgetReference _inputSaveLoadPad;
		private inkWidgetReference _inputExit;
		private inkWidgetReference _inputScreenshot;
		private inkWidgetReference _cameraLocation;
		private inkHorizontalPanelWidgetReference _inputBottomRoot;
		private CName _ps4InputLibraryId;
		private CName _xboxInputLibraryId;
		private wCHandle<inkWidget> _ps4InputWidget;
		private wCHandle<inkWidget> _xboxInputWidget;
		private CArray<wCHandle<inkWidget>> _menuPages;
		private wCHandle<PhotoModeTopBarController> _topButtonsController;
		private wCHandle<PhotoModeCameraLocation> _cameraLocationController;
		private CUInt32 _currentPage;
		private CBool _isHoverOver;
		private CBool _holdSafeguard;
		private CHandle<inkGameNotificationData> _notificationUserData;
		private CHandle<inkGameNotificationToken> _notificationToken;
		private CHandle<inkanimProxy> _loopAnimproxy;
		private CHandle<inkanimProxy> _uiVisiblityFadeAnim;

		[Ordinal(2)] 
		[RED("SetAttributeOptionEnabled")] 
		public gameuiSetPhotoModeKeyEnabledCallback SetAttributeOptionEnabled
		{
			get => GetProperty(ref _setAttributeOptionEnabled);
			set => SetProperty(ref _setAttributeOptionEnabled, value);
		}

		[Ordinal(3)] 
		[RED("SetCategoryEnabled")] 
		public gameuiSetPhotoModeKeyEnabledCallback SetCategoryEnabled
		{
			get => GetProperty(ref _setCategoryEnabled);
			set => SetProperty(ref _setCategoryEnabled, value);
		}

		[Ordinal(4)] 
		[RED("SetStickerImage")] 
		public gameuiStickerImageCallback SetStickerImage
		{
			get => GetProperty(ref _setStickerImage);
			set => SetProperty(ref _setStickerImage, value);
		}

		[Ordinal(5)] 
		[RED("menuListRoot")] 
		public inkWidgetReference MenuListRoot
		{
			get => GetProperty(ref _menuListRoot);
			set => SetProperty(ref _menuListRoot, value);
		}

		[Ordinal(6)] 
		[RED("additionalListRoot")] 
		public inkWidgetReference AdditionalListRoot
		{
			get => GetProperty(ref _additionalListRoot);
			set => SetProperty(ref _additionalListRoot, value);
		}

		[Ordinal(7)] 
		[RED("radioButtons")] 
		public inkCompoundWidgetReference RadioButtons
		{
			get => GetProperty(ref _radioButtons);
			set => SetProperty(ref _radioButtons, value);
		}

		[Ordinal(8)] 
		[RED("listContainerId")] 
		public CName ListContainerId
		{
			get => GetProperty(ref _listContainerId);
			set => SetProperty(ref _listContainerId, value);
		}

		[Ordinal(9)] 
		[RED("menuArea")] 
		public inkWidgetReference MenuArea
		{
			get => GetProperty(ref _menuArea);
			set => SetProperty(ref _menuArea, value);
		}

		[Ordinal(10)] 
		[RED("additionalMenuArea")] 
		public inkWidgetReference AdditionalMenuArea
		{
			get => GetProperty(ref _additionalMenuArea);
			set => SetProperty(ref _additionalMenuArea, value);
		}

		[Ordinal(11)] 
		[RED("inputCameraKbd")] 
		public inkWidgetReference InputCameraKbd
		{
			get => GetProperty(ref _inputCameraKbd);
			set => SetProperty(ref _inputCameraKbd, value);
		}

		[Ordinal(12)] 
		[RED("inputCameraPad")] 
		public inkWidgetReference InputCameraPad
		{
			get => GetProperty(ref _inputCameraPad);
			set => SetProperty(ref _inputCameraPad, value);
		}

		[Ordinal(13)] 
		[RED("inputStickersKbd")] 
		public inkWidgetReference InputStickersKbd
		{
			get => GetProperty(ref _inputStickersKbd);
			set => SetProperty(ref _inputStickersKbd, value);
		}

		[Ordinal(14)] 
		[RED("inputStickersPad")] 
		public inkWidgetReference InputStickersPad
		{
			get => GetProperty(ref _inputStickersPad);
			set => SetProperty(ref _inputStickersPad, value);
		}

		[Ordinal(15)] 
		[RED("inputSaveLoadKbd")] 
		public inkWidgetReference InputSaveLoadKbd
		{
			get => GetProperty(ref _inputSaveLoadKbd);
			set => SetProperty(ref _inputSaveLoadKbd, value);
		}

		[Ordinal(16)] 
		[RED("inputSaveLoadPad")] 
		public inkWidgetReference InputSaveLoadPad
		{
			get => GetProperty(ref _inputSaveLoadPad);
			set => SetProperty(ref _inputSaveLoadPad, value);
		}

		[Ordinal(17)] 
		[RED("inputExit")] 
		public inkWidgetReference InputExit
		{
			get => GetProperty(ref _inputExit);
			set => SetProperty(ref _inputExit, value);
		}

		[Ordinal(18)] 
		[RED("inputScreenshot")] 
		public inkWidgetReference InputScreenshot
		{
			get => GetProperty(ref _inputScreenshot);
			set => SetProperty(ref _inputScreenshot, value);
		}

		[Ordinal(19)] 
		[RED("cameraLocation")] 
		public inkWidgetReference CameraLocation
		{
			get => GetProperty(ref _cameraLocation);
			set => SetProperty(ref _cameraLocation, value);
		}

		[Ordinal(20)] 
		[RED("inputBottomRoot")] 
		public inkHorizontalPanelWidgetReference InputBottomRoot
		{
			get => GetProperty(ref _inputBottomRoot);
			set => SetProperty(ref _inputBottomRoot, value);
		}

		[Ordinal(21)] 
		[RED("ps4InputLibraryId")] 
		public CName Ps4InputLibraryId
		{
			get => GetProperty(ref _ps4InputLibraryId);
			set => SetProperty(ref _ps4InputLibraryId, value);
		}

		[Ordinal(22)] 
		[RED("xboxInputLibraryId")] 
		public CName XboxInputLibraryId
		{
			get => GetProperty(ref _xboxInputLibraryId);
			set => SetProperty(ref _xboxInputLibraryId, value);
		}

		[Ordinal(23)] 
		[RED("ps4InputWidget")] 
		public wCHandle<inkWidget> Ps4InputWidget
		{
			get => GetProperty(ref _ps4InputWidget);
			set => SetProperty(ref _ps4InputWidget, value);
		}

		[Ordinal(24)] 
		[RED("xboxInputWidget")] 
		public wCHandle<inkWidget> XboxInputWidget
		{
			get => GetProperty(ref _xboxInputWidget);
			set => SetProperty(ref _xboxInputWidget, value);
		}

		[Ordinal(25)] 
		[RED("menuPages")] 
		public CArray<wCHandle<inkWidget>> MenuPages
		{
			get => GetProperty(ref _menuPages);
			set => SetProperty(ref _menuPages, value);
		}

		[Ordinal(26)] 
		[RED("topButtonsController")] 
		public wCHandle<PhotoModeTopBarController> TopButtonsController
		{
			get => GetProperty(ref _topButtonsController);
			set => SetProperty(ref _topButtonsController, value);
		}

		[Ordinal(27)] 
		[RED("cameraLocationController")] 
		public wCHandle<PhotoModeCameraLocation> CameraLocationController
		{
			get => GetProperty(ref _cameraLocationController);
			set => SetProperty(ref _cameraLocationController, value);
		}

		[Ordinal(28)] 
		[RED("currentPage")] 
		public CUInt32 CurrentPage
		{
			get => GetProperty(ref _currentPage);
			set => SetProperty(ref _currentPage, value);
		}

		[Ordinal(29)] 
		[RED("IsHoverOver")] 
		public CBool IsHoverOver
		{
			get => GetProperty(ref _isHoverOver);
			set => SetProperty(ref _isHoverOver, value);
		}

		[Ordinal(30)] 
		[RED("holdSafeguard")] 
		public CBool HoldSafeguard
		{
			get => GetProperty(ref _holdSafeguard);
			set => SetProperty(ref _holdSafeguard, value);
		}

		[Ordinal(31)] 
		[RED("notificationUserData")] 
		public CHandle<inkGameNotificationData> NotificationUserData
		{
			get => GetProperty(ref _notificationUserData);
			set => SetProperty(ref _notificationUserData, value);
		}

		[Ordinal(32)] 
		[RED("notificationToken")] 
		public CHandle<inkGameNotificationToken> NotificationToken
		{
			get => GetProperty(ref _notificationToken);
			set => SetProperty(ref _notificationToken, value);
		}

		[Ordinal(33)] 
		[RED("loopAnimproxy")] 
		public CHandle<inkanimProxy> LoopAnimproxy
		{
			get => GetProperty(ref _loopAnimproxy);
			set => SetProperty(ref _loopAnimproxy, value);
		}

		[Ordinal(34)] 
		[RED("uiVisiblityFadeAnim")] 
		public CHandle<inkanimProxy> UiVisiblityFadeAnim
		{
			get => GetProperty(ref _uiVisiblityFadeAnim);
			set => SetProperty(ref _uiVisiblityFadeAnim, value);
		}

		public gameuiPhotoModeMenuController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
