using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LoadGameMenuGameController : gameuiSaveHandlingController
	{
		[Ordinal(4)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("noSavedGamesLabel")] 
		public inkWidgetReference NoSavedGamesLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("transitToLoadingAnimName")] 
		public CName TransitToLoadingAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("transitToLoadingSlotAnimName")] 
		public CName TransitToLoadingSlotAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("animDelayBetweenSlots")] 
		public CFloat AnimDelayBetweenSlots
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("animDelayForMainSlot")] 
		public CFloat AnimDelayForMainSlot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("enableLoadingTransition")] 
		public CBool EnableLoadingTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("gogButtonWidgetRef")] 
		public inkWidgetReference GogButtonWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("gogContainer")] 
		public inkWidgetReference GogContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("loadingSpinner")] 
		public inkWidgetReference LoadingSpinner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("scrollbar")] 
		public inkWidgetReference Scrollbar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("tooltipManagerRef")] 
		public inkWidgetReference TooltipManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("disableModVerificationLabel")] 
		public inkWidgetReference DisableModVerificationLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("tooltipManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(19)] 
		[RED("eventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(20)] 
		[RED("loadComplete")] 
		public CBool LoadComplete
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("saveInfo")] 
		public CHandle<inkSaveMetadataInfo> SaveInfo
		{
			get => GetPropertyValue<CHandle<inkSaveMetadataInfo>>();
			set => SetPropertyValue<CHandle<inkSaveMetadataInfo>>(value);
		}

		[Ordinal(22)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(23)] 
		[RED("saveToLoadIndex")] 
		public CInt32 SaveToLoadIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("saveToLoadID")] 
		public CUInt64 SaveToLoadID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(25)] 
		[RED("isInputDisabled")] 
		public CBool IsInputDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("saveTransferPopupToken")] 
		public CHandle<inkGameNotificationToken> SaveTransferPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(27)] 
		[RED("saves")] 
		public CArray<CString> Saves
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(28)] 
		[RED("saveFilesReady")] 
		public CBool SaveFilesReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("cloudSynced")] 
		public CBool CloudSynced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("onlineSystem")] 
		public CWeakHandle<gameIOnlineSystem> OnlineSystem
		{
			get => GetPropertyValue<CWeakHandle<gameIOnlineSystem>>();
			set => SetPropertyValue<CWeakHandle<gameIOnlineSystem>>(value);
		}

		[Ordinal(31)] 
		[RED("systemHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(32)] 
		[RED("pendingRegistration")] 
		public CBool PendingRegistration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("isEp1Enabled")] 
		public CBool IsEp1Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(35)] 
		[RED("sourceIndex")] 
		public CInt32 SourceIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(36)] 
		[RED("playthroughIDs")] 
		public CArray<CString> PlaythroughIDs
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(37)] 
		[RED("saveWidgetsMap")] 
		public CArray<CArray<CWeakHandle<inkWidget>>> SaveWidgetsMap
		{
			get => GetPropertyValue<CArray<CArray<CWeakHandle<inkWidget>>>>();
			set => SetPropertyValue<CArray<CArray<CWeakHandle<inkWidget>>>>(value);
		}

		[Ordinal(38)] 
		[RED("saveGroupHeaderWidgets")] 
		public CArray<CWeakHandle<inkWidget>> SaveGroupHeaderWidgets
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(39)] 
		[RED("saveGroupInfos")] 
		public CArray<CHandle<SaveGroupInfo>> SaveGroupInfos
		{
			get => GetPropertyValue<CArray<CHandle<SaveGroupInfo>>>();
			set => SetPropertyValue<CArray<CHandle<SaveGroupInfo>>>(value);
		}

		[Ordinal(40)] 
		[RED("buttonList")] 
		public CArray<CWeakHandle<LoadListItem>> ButtonList
		{
			get => GetPropertyValue<CArray<CWeakHandle<LoadListItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<LoadListItem>>>(value);
		}

		[Ordinal(41)] 
		[RED("buttonListFinalized")] 
		public CBool ButtonListFinalized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("gogContainerController")] 
		public CWeakHandle<GogContainerController> GogContainerController
		{
			get => GetPropertyValue<CWeakHandle<GogContainerController>>();
			set => SetPropertyValue<CWeakHandle<GogContainerController>>(value);
		}

		[Ordinal(43)] 
		[RED("isUserUGCRestricted")] 
		public CBool IsUserUGCRestricted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LoadGameMenuGameController()
		{
			List = new inkCompoundWidgetReference();
			NoSavedGamesLabel = new inkWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			EnableLoadingTransition = true;
			GogButtonWidgetRef = new inkWidgetReference();
			GogContainer = new inkWidgetReference();
			LoadingSpinner = new inkWidgetReference();
			Scrollbar = new inkWidgetReference();
			TooltipManagerRef = new inkWidgetReference();
			DisableModVerificationLabel = new inkWidgetReference();
			Saves = new();
			PlaythroughIDs = new();
			SaveWidgetsMap = new();
			SaveGroupHeaderWidgets = new();
			SaveGroupInfos = new();
			ButtonList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
