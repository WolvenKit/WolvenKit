using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhotoModeMenuController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("SetAttributeOptionEnabled")] 
		public gameuiSetPhotoModeKeyEnabledCallback SetAttributeOptionEnabled
		{
			get => GetPropertyValue<gameuiSetPhotoModeKeyEnabledCallback>();
			set => SetPropertyValue<gameuiSetPhotoModeKeyEnabledCallback>(value);
		}

		[Ordinal(4)] 
		[RED("SetCategoryEnabled")] 
		public gameuiSetPhotoModeKeyEnabledCallback SetCategoryEnabled
		{
			get => GetPropertyValue<gameuiSetPhotoModeKeyEnabledCallback>();
			set => SetPropertyValue<gameuiSetPhotoModeKeyEnabledCallback>(value);
		}

		[Ordinal(5)] 
		[RED("SetStickerImage")] 
		public gameuiStickerImageCallback SetStickerImage
		{
			get => GetPropertyValue<gameuiStickerImageCallback>();
			set => SetPropertyValue<gameuiStickerImageCallback>(value);
		}

		[Ordinal(6)] 
		[RED("SetNpcImage")] 
		public gameuiNpcImageCallback SetNpcImage
		{
			get => GetPropertyValue<gameuiNpcImageCallback>();
			set => SetPropertyValue<gameuiNpcImageCallback>(value);
		}

		[Ordinal(7)] 
		[RED("ChangeAspectRatio")] 
		public gameuiChangeAspectRatioCallback ChangeAspectRatio
		{
			get => GetPropertyValue<gameuiChangeAspectRatioCallback>();
			set => SetPropertyValue<gameuiChangeAspectRatioCallback>(value);
		}

		[Ordinal(8)] 
		[RED("menuListRoot")] 
		public inkWidgetReference MenuListRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("additionalListRoot")] 
		public inkWidgetReference AdditionalListRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("radioButtons")] 
		public inkCompoundWidgetReference RadioButtons
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("listContainerId")] 
		public CName ListContainerId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("addtionalContainerID")] 
		public CName AddtionalContainerID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("menuArea")] 
		public inkWidgetReference MenuArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("additionalMenuArea")] 
		public inkWidgetReference AdditionalMenuArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("inputCameraGlobalControlKbd")] 
		public inkWidgetReference InputCameraGlobalControlKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("inputCameraMovementControlKbd")] 
		public inkWidgetReference InputCameraMovementControlKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("inputCameraZoomControlKbd")] 
		public inkWidgetReference InputCameraZoomControlKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("inputCameraKbd")] 
		public inkWidgetReference InputCameraKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("inputCameraGlobalControlPad")] 
		public inkWidgetReference InputCameraGlobalControlPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("inputCameraMovementControlPad")] 
		public inkWidgetReference InputCameraMovementControlPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("inputCameraZoomControlPad")] 
		public inkWidgetReference InputCameraZoomControlPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("inputCameraPad")] 
		public inkWidgetReference InputCameraPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("inputLightControlKbd")] 
		public inkWidgetReference InputLightControlKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("inputLightKbd")] 
		public inkWidgetReference InputLightKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("inputLightControlPad")] 
		public inkWidgetReference InputLightControlPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("inputLightPad")] 
		public inkWidgetReference InputLightPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("inputStickersKbd")] 
		public inkWidgetReference InputStickersKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("inputStickersPad")] 
		public inkWidgetReference InputStickersPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("inputSaveLoadKbd")] 
		public inkWidgetReference InputSaveLoadKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("inputSaveLoadPad")] 
		public inkWidgetReference InputSaveLoadPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("inputExit")] 
		public inkWidgetReference InputExit
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("inputScreenshot")] 
		public inkWidgetReference InputScreenshot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("cameraLocation")] 
		public inkWidgetReference CameraLocation
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("inputBottomRoot")] 
		public inkHorizontalPanelWidgetReference InputBottomRoot
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("lightIndicator")] 
		public inkWidgetReference LightIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("tabTitleText")] 
		public inkRichTextBoxWidgetReference TabTitleText
		{
			get => GetPropertyValue<inkRichTextBoxWidgetReference>();
			set => SetPropertyValue<inkRichTextBoxWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("tabTitleIcon")] 
		public inkImageWidgetReference TabTitleIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("aspectRatioPanel")] 
		public inkWidgetReference AspectRatioPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("LeftBlackBar")] 
		public inkWidgetReference LeftBlackBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("RightBlackBar")] 
		public inkWidgetReference RightBlackBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("TopBlackBar")] 
		public inkWidgetReference TopBlackBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("BottomBlackBar")] 
		public inkWidgetReference BottomBlackBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("ps4InputLibraryId")] 
		public CName Ps4InputLibraryId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(44)] 
		[RED("xboxInputLibraryId")] 
		public CName XboxInputLibraryId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(45)] 
		[RED("stadiaInputLibraryId")] 
		public CName StadiaInputLibraryId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(46)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(47)] 
		[RED("ps4InputWidget")] 
		public CWeakHandle<inkWidget> Ps4InputWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(48)] 
		[RED("xboxInputWidget")] 
		public CWeakHandle<inkWidget> XboxInputWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(49)] 
		[RED("stadiaInputWidget")] 
		public CWeakHandle<inkWidget> StadiaInputWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(50)] 
		[RED("menuPages")] 
		public CArray<CWeakHandle<inkWidget>> MenuPages
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(51)] 
		[RED("topButtonsController")] 
		public CWeakHandle<PhotoModeTopBarController> TopButtonsController
		{
			get => GetPropertyValue<CWeakHandle<PhotoModeTopBarController>>();
			set => SetPropertyValue<CWeakHandle<PhotoModeTopBarController>>(value);
		}

		[Ordinal(52)] 
		[RED("cameraLocationController")] 
		public CWeakHandle<PhotoModeCameraLocation> CameraLocationController
		{
			get => GetPropertyValue<CWeakHandle<PhotoModeCameraLocation>>();
			set => SetPropertyValue<CWeakHandle<PhotoModeCameraLocation>>(value);
		}

		[Ordinal(53)] 
		[RED("currentPage")] 
		public CUInt32 CurrentPage
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(54)] 
		[RED("IsHoverOver")] 
		public CBool IsHoverOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("holdSafeguard")] 
		public CBool HoldSafeguard
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("notificationUserData")] 
		public CHandle<inkGameNotificationData> NotificationUserData
		{
			get => GetPropertyValue<CHandle<inkGameNotificationData>>();
			set => SetPropertyValue<CHandle<inkGameNotificationData>>(value);
		}

		[Ordinal(57)] 
		[RED("notificationToken")] 
		public CHandle<inkGameNotificationToken> NotificationToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(58)] 
		[RED("loopAnimproxy")] 
		public CHandle<inkanimProxy> LoopAnimproxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(59)] 
		[RED("uiVisiblityFadeAnim")] 
		public CHandle<inkanimProxy> UiVisiblityFadeAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(60)] 
		[RED("currentNpc")] 
		public CInt32 CurrentNpc
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(61)] 
		[RED("exitConfirmationToken")] 
		public CHandle<inkGameNotificationToken> ExitConfirmationToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(62)] 
		[RED("horizontalLineUp")] 
		public inkWidgetReference HorizontalLineUp
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(63)] 
		[RED("horizontalLineDown")] 
		public inkWidgetReference HorizontalLineDown
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(64)] 
		[RED("verticalLineLeft")] 
		public inkWidgetReference VerticalLineLeft
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(65)] 
		[RED("verticalLineRight")] 
		public inkWidgetReference VerticalLineRight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(66)] 
		[RED("fakePlayer")] 
		public CWeakHandle<PlayerPuppet> FakePlayer
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(67)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(68)] 
		[RED("anyOptionChanged")] 
		public CBool AnyOptionChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiPhotoModeMenuController()
		{
			SetAttributeOptionEnabled = new gameuiSetPhotoModeKeyEnabledCallback();
			SetCategoryEnabled = new gameuiSetPhotoModeKeyEnabledCallback();
			SetStickerImage = new gameuiStickerImageCallback();
			SetNpcImage = new gameuiNpcImageCallback();
			ChangeAspectRatio = new gameuiChangeAspectRatioCallback();
			MenuListRoot = new inkWidgetReference();
			AdditionalListRoot = new inkWidgetReference();
			RadioButtons = new inkCompoundWidgetReference();
			MenuArea = new inkWidgetReference();
			AdditionalMenuArea = new inkWidgetReference();
			InputCameraGlobalControlKbd = new inkWidgetReference();
			InputCameraMovementControlKbd = new inkWidgetReference();
			InputCameraZoomControlKbd = new inkWidgetReference();
			InputCameraKbd = new inkWidgetReference();
			InputCameraGlobalControlPad = new inkWidgetReference();
			InputCameraMovementControlPad = new inkWidgetReference();
			InputCameraZoomControlPad = new inkWidgetReference();
			InputCameraPad = new inkWidgetReference();
			InputLightControlKbd = new inkWidgetReference();
			InputLightKbd = new inkWidgetReference();
			InputLightControlPad = new inkWidgetReference();
			InputLightPad = new inkWidgetReference();
			InputStickersKbd = new inkWidgetReference();
			InputStickersPad = new inkWidgetReference();
			InputSaveLoadKbd = new inkWidgetReference();
			InputSaveLoadPad = new inkWidgetReference();
			InputExit = new inkWidgetReference();
			InputScreenshot = new inkWidgetReference();
			CameraLocation = new inkWidgetReference();
			InputBottomRoot = new inkHorizontalPanelWidgetReference();
			LightIndicator = new inkWidgetReference();
			TabTitleText = new inkRichTextBoxWidgetReference();
			TabTitleIcon = new inkImageWidgetReference();
			AspectRatioPanel = new inkWidgetReference();
			LeftBlackBar = new inkWidgetReference();
			RightBlackBar = new inkWidgetReference();
			TopBlackBar = new inkWidgetReference();
			BottomBlackBar = new inkWidgetReference();
			MenuPages = new();
			HorizontalLineUp = new inkWidgetReference();
			HorizontalLineDown = new inkWidgetReference();
			VerticalLineLeft = new inkWidgetReference();
			VerticalLineRight = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
