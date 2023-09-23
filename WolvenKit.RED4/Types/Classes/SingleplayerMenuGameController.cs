using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SingleplayerMenuGameController : gameuiMainMenuGameController
	{
		[Ordinal(7)] 
		[RED("baseLogoContainer")] 
		public inkCompoundWidgetReference BaseLogoContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("ep1LogoContainer")] 
		public inkCompoundWidgetReference Ep1LogoContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("gogButtonWidgetRef")] 
		public inkWidgetReference GogButtonWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("accountSelector")] 
		public inkCompoundWidgetReference AccountSelector
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("gameVersionButton")] 
		public inkCompoundWidgetReference GameVersionButton
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("patch2Notification")] 
		public inkCompoundWidgetReference Patch2Notification
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("patch2NotificationDelay")] 
		public CFloat Patch2NotificationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("expansionBanner")] 
		public inkCompoundWidgetReference ExpansionBanner
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("ep1IdName")] 
		public CName Ep1IdName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("continuetooltipContainer")] 
		public inkCompoundWidgetReference ContinuetooltipContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("onlineSystem")] 
		public CWeakHandle<gameIOnlineSystem> OnlineSystem
		{
			get => GetPropertyValue<CWeakHandle<gameIOnlineSystem>>();
			set => SetPropertyValue<CWeakHandle<gameIOnlineSystem>>(value);
		}

		[Ordinal(19)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(20)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(21)] 
		[RED("continueGameTooltipController")] 
		public CWeakHandle<ContinueGameTooltip> ContinueGameTooltipController
		{
			get => GetPropertyValue<CWeakHandle<ContinueGameTooltip>>();
			set => SetPropertyValue<CWeakHandle<ContinueGameTooltip>>(value);
		}

		[Ordinal(22)] 
		[RED("expansionHintController")] 
		public CWeakHandle<inkWidgetLogicController> ExpansionHintController
		{
			get => GetPropertyValue<CWeakHandle<inkWidgetLogicController>>();
			set => SetPropertyValue<CWeakHandle<inkWidgetLogicController>>(value);
		}

		[Ordinal(23)] 
		[RED("expansionBannerController")] 
		public CWeakHandle<ExpansionBannerController> ExpansionBannerController
		{
			get => GetPropertyValue<CWeakHandle<ExpansionBannerController>>();
			set => SetPropertyValue<CWeakHandle<ExpansionBannerController>>(value);
		}

		[Ordinal(24)] 
		[RED("accountSelectorController")] 
		public CWeakHandle<inkMenuAccountLogicController> AccountSelectorController
		{
			get => GetPropertyValue<CWeakHandle<inkMenuAccountLogicController>>();
			set => SetPropertyValue<CWeakHandle<inkMenuAccountLogicController>>(value);
		}

		[Ordinal(25)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(26)] 
		[RED("dataSyncStatus")] 
		public CEnum<servicesCloudSavesQueryStatus> DataSyncStatus
		{
			get => GetPropertyValue<CEnum<servicesCloudSavesQueryStatus>>();
			set => SetPropertyValue<CEnum<servicesCloudSavesQueryStatus>>(value);
		}

		[Ordinal(27)] 
		[RED("savesCount")] 
		public CInt32 SavesCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(28)] 
		[RED("savesReady")] 
		public CBool SavesReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("isOffline")] 
		public CBool IsOffline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("isModded")] 
		public CBool IsModded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("isExpansionHintShown")] 
		public CBool IsExpansionHintShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("isMainMenuShownFirstTime")] 
		public CBool IsMainMenuShownFirstTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("isPatch2NotificationShown")] 
		public CBool IsPatch2NotificationShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("isReloadPopupShown")] 
		public CBool IsReloadPopupShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("isEp1Enabled")] 
		public CBool IsEp1Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("isDataValidationErrorShown")] 
		public CBool IsDataValidationErrorShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("patch2NotificationIntroName")] 
		public CName Patch2NotificationIntroName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(38)] 
		[RED("patch2NotificationOutroName")] 
		public CName Patch2NotificationOutroName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(39)] 
		[RED("patch2NotificationAnimProxy")] 
		public CHandle<inkanimProxy> Patch2NotificationAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public SingleplayerMenuGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
