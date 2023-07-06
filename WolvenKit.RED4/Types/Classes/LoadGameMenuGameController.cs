using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LoadGameMenuGameController : gameuiSaveHandlingController
	{
		[Ordinal(3)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("noSavedGamesLabel")] 
		public inkWidgetReference NoSavedGamesLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("transitToLoadingAnimName")] 
		public CName TransitToLoadingAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("transitToLoadingSlotAnimName")] 
		public CName TransitToLoadingSlotAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("animDelayBetweenSlots")] 
		public CFloat AnimDelayBetweenSlots
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("animDelayForMainSlot")] 
		public CFloat AnimDelayForMainSlot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("enableLoadingTransition")] 
		public CBool EnableLoadingTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("gogButtonWidgetRef")] 
		public inkWidgetReference GogButtonWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("gogContainer")] 
		public inkWidgetReference GogContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("laodingSpinner")] 
		public inkWidgetReference LaodingSpinner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("scrollbar")] 
		public inkWidgetReference Scrollbar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("eventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(16)] 
		[RED("loadComplete")] 
		public CBool LoadComplete
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("saveInfo")] 
		public CHandle<inkSaveMetadataInfo> SaveInfo
		{
			get => GetPropertyValue<CHandle<inkSaveMetadataInfo>>();
			set => SetPropertyValue<CHandle<inkSaveMetadataInfo>>(value);
		}

		[Ordinal(18)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(19)] 
		[RED("saveToLoadIndex")] 
		public CInt32 SaveToLoadIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("isInputDisabled")] 
		public CBool IsInputDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("saveTransferPopupToken")] 
		public CHandle<inkGameNotificationToken> SaveTransferPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(22)] 
		[RED("saves")] 
		public CArray<CString> Saves
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(23)] 
		[RED("saveFilesReady")] 
		public CBool SaveFilesReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("cloudSynced")] 
		public CBool CloudSynced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("onlineSystem")] 
		public CWeakHandle<gameIOnlineSystem> OnlineSystem
		{
			get => GetPropertyValue<CWeakHandle<gameIOnlineSystem>>();
			set => SetPropertyValue<CWeakHandle<gameIOnlineSystem>>(value);
		}

		[Ordinal(26)] 
		[RED("systemHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(27)] 
		[RED("pendingRegistration")] 
		public CBool PendingRegistration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LoadGameMenuGameController()
		{
			List = new inkCompoundWidgetReference();
			NoSavedGamesLabel = new inkWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			GogButtonWidgetRef = new inkWidgetReference();
			GogContainer = new inkWidgetReference();
			LaodingSpinner = new inkWidgetReference();
			Scrollbar = new inkWidgetReference();
			Saves = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
