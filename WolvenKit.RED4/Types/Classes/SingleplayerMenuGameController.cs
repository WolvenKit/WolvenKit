using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SingleplayerMenuGameController : gameuiMainMenuGameController
	{
		[Ordinal(9)] 
		[RED("baseLogoContainer")] 
		public inkCompoundWidgetReference BaseLogoContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("ep1LogoContainer")] 
		public inkCompoundWidgetReference Ep1LogoContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("gogButtonWidgetRef")] 
		public inkWidgetReference GogButtonWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("gogContainerRef")] 
		public inkCompoundWidgetReference GogContainerRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("gogUserDisplayContainerRef")] 
		public inkWidgetReference GogUserDisplayContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("AdditionalButtonsBoxRef")] 
		public inkCompoundWidgetReference AdditionalButtonsBoxRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("accountSelector")] 
		public inkCompoundWidgetReference AccountSelector
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("commonGameVersionButton")] 
		public inkCompoundWidgetReference CommonGameVersionButton
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("emporiumButtons")] 
		public inkCompoundWidgetReference EmporiumButtons
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("emporiumGameVersionButton")] 
		public inkCompoundWidgetReference EmporiumGameVersionButton
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("emporiumFeaturesBtn")] 
		public inkCompoundWidgetReference EmporiumFeaturesBtn
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("patch2Notification")] 
		public inkCompoundWidgetReference Patch2Notification
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("patch2NotificationDelay")] 
		public CFloat Patch2NotificationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("expansionBanner")] 
		public inkCompoundWidgetReference ExpansionBanner
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("ep1IdName")] 
		public CName Ep1IdName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("eulaWidget")] 
		public inkWidgetReference EulaWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("quitGameWidget")] 
		public inkWidgetReference QuitGameWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("declineButtonWidget")] 
		public inkWidgetReference DeclineButtonWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("acceptButtonWidget")] 
		public inkWidgetReference AcceptButtonWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("declineButtonText")] 
		public inkTextWidgetReference DeclineButtonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("acceptButtonText")] 
		public inkTextWidgetReference AcceptButtonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("contentTextRef")] 
		public inkTextWidgetReference ContentTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("contentTextLocKey")] 
		public CName ContentTextLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("continuetooltipContainer")] 
		public inkCompoundWidgetReference ContinuetooltipContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("versionTextRef")] 
		public inkTextWidgetReference VersionTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("onlineSystem")] 
		public CWeakHandle<gameIOnlineSystem> OnlineSystem
		{
			get => GetPropertyValue<CWeakHandle<gameIOnlineSystem>>();
			set => SetPropertyValue<CWeakHandle<gameIOnlineSystem>>(value);
		}

		[Ordinal(38)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(39)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(40)] 
		[RED("continueGameTooltipController")] 
		public CWeakHandle<ContinueGameTooltip> ContinueGameTooltipController
		{
			get => GetPropertyValue<CWeakHandle<ContinueGameTooltip>>();
			set => SetPropertyValue<CWeakHandle<ContinueGameTooltip>>(value);
		}

		[Ordinal(41)] 
		[RED("modioTooltipController")] 
		public CWeakHandle<ModioToolTipInMenu> ModioTooltipController
		{
			get => GetPropertyValue<CWeakHandle<ModioToolTipInMenu>>();
			set => SetPropertyValue<CWeakHandle<ModioToolTipInMenu>>(value);
		}

		[Ordinal(42)] 
		[RED("expansionHintController")] 
		public CWeakHandle<TrophyTooltipController> ExpansionHintController
		{
			get => GetPropertyValue<CWeakHandle<TrophyTooltipController>>();
			set => SetPropertyValue<CWeakHandle<TrophyTooltipController>>(value);
		}

		[Ordinal(43)] 
		[RED("expansionBannerController")] 
		public CWeakHandle<ExpansionBannerController> ExpansionBannerController
		{
			get => GetPropertyValue<CWeakHandle<ExpansionBannerController>>();
			set => SetPropertyValue<CWeakHandle<ExpansionBannerController>>(value);
		}

		[Ordinal(44)] 
		[RED("accountSelectorController")] 
		public CWeakHandle<inkMenuAccountLogicController> AccountSelectorController
		{
			get => GetPropertyValue<CWeakHandle<inkMenuAccountLogicController>>();
			set => SetPropertyValue<CWeakHandle<inkMenuAccountLogicController>>(value);
		}

		[Ordinal(45)] 
		[RED("gogContainerController")] 
		public CWeakHandle<GogContainerController> GogContainerController
		{
			get => GetPropertyValue<CWeakHandle<GogContainerController>>();
			set => SetPropertyValue<CWeakHandle<GogContainerController>>(value);
		}

		[Ordinal(46)] 
		[RED("textAnimController")] 
		public CWeakHandle<inkTextReplaceAnimationController> TextAnimController
		{
			get => GetPropertyValue<CWeakHandle<inkTextReplaceAnimationController>>();
			set => SetPropertyValue<CWeakHandle<inkTextReplaceAnimationController>>(value);
		}

		[Ordinal(47)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(48)] 
		[RED("gameVersionButton")] 
		public inkCompoundWidgetReference GameVersionButton
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(49)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(50)] 
		[RED("patchNotesCheckData")] 
		public CHandle<PatchNotesCheckData> PatchNotesCheckData
		{
			get => GetPropertyValue<CHandle<PatchNotesCheckData>>();
			set => SetPropertyValue<CHandle<PatchNotesCheckData>>(value);
		}

		[Ordinal(51)] 
		[RED("dataSyncStatus")] 
		public CEnum<servicesCloudSavesQueryStatus> DataSyncStatus
		{
			get => GetPropertyValue<CEnum<servicesCloudSavesQueryStatus>>();
			set => SetPropertyValue<CEnum<servicesCloudSavesQueryStatus>>(value);
		}

		[Ordinal(52)] 
		[RED("savesCount")] 
		public CInt32 SavesCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(53)] 
		[RED("savesReady")] 
		public CBool SavesReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("isOffline")] 
		public CBool IsOffline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("isModded")] 
		public CBool IsModded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("isUserUGCRestricted")] 
		public CBool IsUserUGCRestricted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("isExpansionHintShown")] 
		public CBool IsExpansionHintShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("isMainMenuShownFirstTime")] 
		public CBool IsMainMenuShownFirstTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("isPatch2NotificationShown")] 
		public CBool IsPatch2NotificationShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("isReloadPopupShown")] 
		public CBool IsReloadPopupShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("isEp1Enabled")] 
		public CBool IsEp1Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("isEmporium")] 
		public CBool IsEmporium
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("gameVersion")] 
		public CString GameVersion
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(64)] 
		[RED("patch2NotificationIntroName")] 
		public CName Patch2NotificationIntroName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(65)] 
		[RED("patch2NotificationOutroName")] 
		public CName Patch2NotificationOutroName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(66)] 
		[RED("patch2NotificationAnimProxy")] 
		public CHandle<inkanimProxy> Patch2NotificationAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(67)] 
		[RED("gameVersionAnim")] 
		public CHandle<inkanimProxy> GameVersionAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(68)] 
		[RED("eulaIsAccepted")] 
		public CBool EulaIsAccepted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(69)] 
		[RED("isEulaWindowOpened")] 
		public CBool IsEulaWindowOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("eulaRead")] 
		public CBool EulaRead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("sliderController")] 
		public CWeakHandle<inkSliderController> SliderController
		{
			get => GetPropertyValue<CWeakHandle<inkSliderController>>();
			set => SetPropertyValue<CWeakHandle<inkSliderController>>(value);
		}

		[Ordinal(72)] 
		[RED("declineButtonController")] 
		public CWeakHandle<inkButtonController> DeclineButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(73)] 
		[RED("acceptButtonController")] 
		public CWeakHandle<inkButtonController> AcceptButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(74)] 
		[RED("eulaAnimationProxy")] 
		public CHandle<inkanimProxy> EulaAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(75)] 
		[RED("modioButton")] 
		public CWeakHandle<inkWidget> ModioButton
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(76)] 
		[RED("isModReloadingPopupShown")] 
		public CBool IsModReloadingPopupShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(77)] 
		[RED("hasAlreadyShownMenuItemList")] 
		public CBool HasAlreadyShownMenuItemList
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(78)] 
		[RED("gogUserDisplayController")] 
		public CWeakHandle<GogUserDisplayController> GogUserDisplayController
		{
			get => GetPropertyValue<CWeakHandle<GogUserDisplayController>>();
			set => SetPropertyValue<CWeakHandle<GogUserDisplayController>>(value);
		}

		public SingleplayerMenuGameController()
		{
			BaseLogoContainer = new inkCompoundWidgetReference();
			Ep1LogoContainer = new inkCompoundWidgetReference();
			GogButtonWidgetRef = new inkWidgetReference();
			GogContainerRef = new inkCompoundWidgetReference();
			GogUserDisplayContainerRef = new inkWidgetReference();
			AdditionalButtonsBoxRef = new inkCompoundWidgetReference();
			AccountSelector = new inkCompoundWidgetReference();
			CommonGameVersionButton = new inkCompoundWidgetReference();
			EmporiumButtons = new inkCompoundWidgetReference();
			EmporiumGameVersionButton = new inkCompoundWidgetReference();
			EmporiumFeaturesBtn = new inkCompoundWidgetReference();
			Patch2Notification = new inkCompoundWidgetReference();
			Patch2NotificationDelay = 10.000000F;
			ExpansionBanner = new inkCompoundWidgetReference();
			Ep1IdName = "EP1";
			EulaWidget = new inkWidgetReference();
			QuitGameWidget = new inkWidgetReference();
			SliderWidget = new inkWidgetReference();
			DeclineButtonWidget = new inkWidgetReference();
			AcceptButtonWidget = new inkWidgetReference();
			DeclineButtonText = new inkTextWidgetReference();
			AcceptButtonText = new inkTextWidgetReference();
			ContentTextRef = new inkTextWidgetReference();
			ContentTextLocKey = "UI-EULA-EULAFullText";
			ButtonHintsManagerRef = new inkWidgetReference();
			ContinuetooltipContainer = new inkCompoundWidgetReference();
			TooltipsManagerRef = new inkWidgetReference();
			VersionTextRef = new inkTextWidgetReference();
			GameVersionButton = new inkCompoundWidgetReference();
			Patch2NotificationIntroName = "patch2_notification_intro";
			Patch2NotificationOutroName = "patch2_notification_outro";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
