using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhotoModeMenuController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("SetAttributeOptionEnabled")] 
		public gameuiSetPhotoModeKeyEnabledCallback SetAttributeOptionEnabled
		{
			get => GetPropertyValue<gameuiSetPhotoModeKeyEnabledCallback>();
			set => SetPropertyValue<gameuiSetPhotoModeKeyEnabledCallback>(value);
		}

		[Ordinal(3)] 
		[RED("SetCategoryEnabled")] 
		public gameuiSetPhotoModeKeyEnabledCallback SetCategoryEnabled
		{
			get => GetPropertyValue<gameuiSetPhotoModeKeyEnabledCallback>();
			set => SetPropertyValue<gameuiSetPhotoModeKeyEnabledCallback>(value);
		}

		[Ordinal(4)] 
		[RED("SetStickerImage")] 
		public gameuiStickerImageCallback SetStickerImage
		{
			get => GetPropertyValue<gameuiStickerImageCallback>();
			set => SetPropertyValue<gameuiStickerImageCallback>(value);
		}

		[Ordinal(5)] 
		[RED("SetNpcImage")] 
		public gameuiNpcImageCallback SetNpcImage
		{
			get => GetPropertyValue<gameuiNpcImageCallback>();
			set => SetPropertyValue<gameuiNpcImageCallback>(value);
		}

		[Ordinal(6)] 
		[RED("ChangeAspectRatio")] 
		public gameuiChangeAspectRatioCallback ChangeAspectRatio
		{
			get => GetPropertyValue<gameuiChangeAspectRatioCallback>();
			set => SetPropertyValue<gameuiChangeAspectRatioCallback>(value);
		}

		[Ordinal(7)] 
		[RED("menuListRoot")] 
		public inkWidgetReference MenuListRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("additionalListRoot")] 
		public inkWidgetReference AdditionalListRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("radioButtons")] 
		public inkCompoundWidgetReference RadioButtons
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("listContainerId")] 
		public CName ListContainerId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("menuArea")] 
		public inkWidgetReference MenuArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("additionalMenuArea")] 
		public inkWidgetReference AdditionalMenuArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("inputCameraControlKbd")] 
		public inkWidgetReference InputCameraControlKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("inputCameraKbd")] 
		public inkWidgetReference InputCameraKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("inputCameraControlPad")] 
		public inkWidgetReference InputCameraControlPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("inputCameraPad")] 
		public inkWidgetReference InputCameraPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("inputLightControlKbd")] 
		public inkWidgetReference InputLightControlKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("inputLightKbd")] 
		public inkWidgetReference InputLightKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("inputLightControlPad")] 
		public inkWidgetReference InputLightControlPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("inputLightPad")] 
		public inkWidgetReference InputLightPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("inputStickersKbd")] 
		public inkWidgetReference InputStickersKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("inputStickersPad")] 
		public inkWidgetReference InputStickersPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("inputSaveLoadKbd")] 
		public inkWidgetReference InputSaveLoadKbd
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("inputSaveLoadPad")] 
		public inkWidgetReference InputSaveLoadPad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("inputExit")] 
		public inkWidgetReference InputExit
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("inputScreenshot")] 
		public inkWidgetReference InputScreenshot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("cameraLocation")] 
		public inkWidgetReference CameraLocation
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("inputBottomRoot")] 
		public inkHorizontalPanelWidgetReference InputBottomRoot
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("tabTitleText")] 
		public inkRichTextBoxWidgetReference TabTitleText
		{
			get => GetPropertyValue<inkRichTextBoxWidgetReference>();
			set => SetPropertyValue<inkRichTextBoxWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("tabTitleIcon")] 
		public inkImageWidgetReference TabTitleIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("aspectRatioPanel")] 
		public inkWidgetReference AspectRatioPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("ps4InputLibraryId")] 
		public CName Ps4InputLibraryId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("xboxInputLibraryId")] 
		public CName XboxInputLibraryId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("stadiaInputLibraryId")] 
		public CName StadiaInputLibraryId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(36)] 
		[RED("ps4InputWidget")] 
		public CWeakHandle<inkWidget> Ps4InputWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(37)] 
		[RED("xboxInputWidget")] 
		public CWeakHandle<inkWidget> XboxInputWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(38)] 
		[RED("stadiaInputWidget")] 
		public CWeakHandle<inkWidget> StadiaInputWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(39)] 
		[RED("menuPages")] 
		public CArray<CWeakHandle<inkWidget>> MenuPages
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(40)] 
		[RED("topButtonsController")] 
		public CWeakHandle<PhotoModeTopBarController> TopButtonsController
		{
			get => GetPropertyValue<CWeakHandle<PhotoModeTopBarController>>();
			set => SetPropertyValue<CWeakHandle<PhotoModeTopBarController>>(value);
		}

		[Ordinal(41)] 
		[RED("cameraLocationController")] 
		public CWeakHandle<PhotoModeCameraLocation> CameraLocationController
		{
			get => GetPropertyValue<CWeakHandle<PhotoModeCameraLocation>>();
			set => SetPropertyValue<CWeakHandle<PhotoModeCameraLocation>>(value);
		}

		[Ordinal(42)] 
		[RED("currentPage")] 
		public CUInt32 CurrentPage
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(43)] 
		[RED("IsHoverOver")] 
		public CBool IsHoverOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("holdSafeguard")] 
		public CBool HoldSafeguard
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("notificationUserData")] 
		public CHandle<inkGameNotificationData> NotificationUserData
		{
			get => GetPropertyValue<CHandle<inkGameNotificationData>>();
			set => SetPropertyValue<CHandle<inkGameNotificationData>>(value);
		}

		[Ordinal(46)] 
		[RED("notificationToken")] 
		public CHandle<inkGameNotificationToken> NotificationToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(47)] 
		[RED("loopAnimproxy")] 
		public CHandle<inkanimProxy> LoopAnimproxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(48)] 
		[RED("uiVisiblityFadeAnim")] 
		public CHandle<inkanimProxy> UiVisiblityFadeAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(49)] 
		[RED("currentNpc")] 
		public CInt32 CurrentNpc
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
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
			InputCameraControlKbd = new inkWidgetReference();
			InputCameraKbd = new inkWidgetReference();
			InputCameraControlPad = new inkWidgetReference();
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
			TabTitleText = new inkRichTextBoxWidgetReference();
			TabTitleIcon = new inkImageWidgetReference();
			AspectRatioPanel = new inkWidgetReference();
			MenuPages = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
