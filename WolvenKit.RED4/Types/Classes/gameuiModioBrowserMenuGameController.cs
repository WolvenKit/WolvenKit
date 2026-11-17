using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiModioBrowserMenuGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("MenuUpdate")] 
		public gameuiMenuIntIntCallback MenuUpdate
		{
			get => GetPropertyValue<gameuiMenuIntIntCallback>();
			set => SetPropertyValue<gameuiMenuIntIntCallback>(value);
		}

		[Ordinal(4)] 
		[RED("ModDetailsUpdate")] 
		public gameuiMenuIntCallback ModDetailsUpdate
		{
			get => GetPropertyValue<gameuiMenuIntCallback>();
			set => SetPropertyValue<gameuiMenuIntCallback>(value);
		}

		[Ordinal(5)] 
		[RED("LogoDownloadRequested")] 
		public gameuiMenuIntCallback LogoDownloadRequested
		{
			get => GetPropertyValue<gameuiMenuIntCallback>();
			set => SetPropertyValue<gameuiMenuIntCallback>(value);
		}

		[Ordinal(6)] 
		[RED("ButtonHintsUpdateRequested")] 
		public inkEmptyCallback ButtonHintsUpdateRequested
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(7)] 
		[RED("NewModSelected")] 
		public gameuiSendSelectedModInfoCallback NewModSelected
		{
			get => GetPropertyValue<gameuiSendSelectedModInfoCallback>();
			set => SetPropertyValue<gameuiSendSelectedModInfoCallback>(value);
		}

		[Ordinal(8)] 
		[RED("ProcessedModProgressUpdate")] 
		public gameuiSendProcessedModProgressInfoCallback ProcessedModProgressUpdate
		{
			get => GetPropertyValue<gameuiSendProcessedModProgressInfoCallback>();
			set => SetPropertyValue<gameuiSendProcessedModProgressInfoCallback>(value);
		}

		[Ordinal(9)] 
		[RED("ListOfModsToDisplayUpdated")] 
		public gameuiSendModGridInfoCallback ListOfModsToDisplayUpdated
		{
			get => GetPropertyValue<gameuiSendModGridInfoCallback>();
			set => SetPropertyValue<gameuiSendModGridInfoCallback>(value);
		}

		[Ordinal(10)] 
		[RED("PagesLayoutChanged")] 
		public gameuiUpdatePageLayoutCallback PagesLayoutChanged
		{
			get => GetPropertyValue<gameuiUpdatePageLayoutCallback>();
			set => SetPropertyValue<gameuiUpdatePageLayoutCallback>(value);
		}

		[Ordinal(11)] 
		[RED("SwitchBetweenBrowserAndCollectionMenu")] 
		public inkBoolCallback SwitchBetweenBrowserAndCollectionMenu
		{
			get => GetPropertyValue<inkBoolCallback>();
			set => SetPropertyValue<inkBoolCallback>(value);
		}

		[Ordinal(12)] 
		[RED("RequestLogoForWidget")] 
		public gameuiRequestMediaForWidgetCallback RequestLogoForWidget
		{
			get => GetPropertyValue<gameuiRequestMediaForWidgetCallback>();
			set => SetPropertyValue<gameuiRequestMediaForWidgetCallback>(value);
		}

		[Ordinal(13)] 
		[RED("RequestedGalleryOnServer")] 
		public gameuiMenuIntCallback RequestedGalleryOnServer
		{
			get => GetPropertyValue<gameuiMenuIntCallback>();
			set => SetPropertyValue<gameuiMenuIntCallback>(value);
		}

		[Ordinal(14)] 
		[RED("RequestGalleryForWidget")] 
		public gameuiRequestMediaForWidgetCallback RequestGalleryForWidget
		{
			get => GetPropertyValue<gameuiRequestMediaForWidgetCallback>();
			set => SetPropertyValue<gameuiRequestMediaForWidgetCallback>(value);
		}

		[Ordinal(15)] 
		[RED("AllLanguagesCheckboxClicked")] 
		public gameuiAllLanguagesCheckboxCallback AllLanguagesCheckboxClicked
		{
			get => GetPropertyValue<gameuiAllLanguagesCheckboxCallback>();
			set => SetPropertyValue<gameuiAllLanguagesCheckboxCallback>(value);
		}

		[Ordinal(16)] 
		[RED("SearchbarUpdate")] 
		public inkEmptyCallback SearchbarUpdate
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(17)] 
		[RED("CheckIfEnabledModsListChanged")] 
		public inkBoolCallback CheckIfEnabledModsListChanged
		{
			get => GetPropertyValue<inkBoolCallback>();
			set => SetPropertyValue<inkBoolCallback>(value);
		}

		[Ordinal(18)] 
		[RED("RateLimitedErrorReceived")] 
		public inkEmptyCallback RateLimitedErrorReceived
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(19)] 
		[RED("RateLimitedErrorLifted")] 
		public inkEmptyCallback RateLimitedErrorLifted
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(20)] 
		[RED("UpdateModVerificationPopupCount")] 
		public gameuiSendModUpdateVerificationInfo UpdateModVerificationPopupCount
		{
			get => GetPropertyValue<gameuiSendModUpdateVerificationInfo>();
			set => SetPropertyValue<gameuiSendModUpdateVerificationInfo>(value);
		}

		[Ordinal(21)] 
		[RED("ModTagsReceived")] 
		public gameuiFilterTagsReceivedCallback ModTagsReceived
		{
			get => GetPropertyValue<gameuiFilterTagsReceivedCallback>();
			set => SetPropertyValue<gameuiFilterTagsReceivedCallback>(value);
		}

		[Ordinal(22)] 
		[RED("DelayedSpawnForFilters")] 
		public inkEmptyCallback DelayedSpawnForFilters
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(23)] 
		[RED("DelayedSliderAdjustForDrawer")] 
		public inkEmptyCallback DelayedSliderAdjustForDrawer
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(24)] 
		[RED("HiddenModListUpdated")] 
		public gameuiReceivedHiddenModsListCallback HiddenModListUpdated
		{
			get => GetPropertyValue<gameuiReceivedHiddenModsListCallback>();
			set => SetPropertyValue<gameuiReceivedHiddenModsListCallback>(value);
		}

		[Ordinal(25)] 
		[RED("AskedForNewModList")] 
		public inkEmptyCallback AskedForNewModList
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(26)] 
		[RED("bIsInBrowserMode")] 
		public CBool BIsInBrowserMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("bHasAtLeastOneModEnabled")] 
		public CBool BHasAtLeastOneModEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("bHasAtLeastOneModDisabled")] 
		public CBool BHasAtLeastOneModDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("bIsPregame")] 
		public CBool BIsPregame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("bIsUserSubscribedToCurrentlySelectedMod")] 
		public CBool BIsUserSubscribedToCurrentlySelectedMod
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiModioBrowserMenuGameController()
		{
			MenuUpdate = new gameuiMenuIntIntCallback { CallbackName = "OnMenuUpdate" };
			ModDetailsUpdate = new gameuiMenuIntCallback { CallbackName = "OnModDetailsUpdate" };
			LogoDownloadRequested = new gameuiMenuIntCallback { CallbackName = "OnLogoDownloadRequested" };
			ButtonHintsUpdateRequested = new inkEmptyCallback { CallbackName = "OnButtonHintsUpdateRequested" };
			NewModSelected = new gameuiSendSelectedModInfoCallback { CallbackName = "OnNewModSelected" };
			ProcessedModProgressUpdate = new gameuiSendProcessedModProgressInfoCallback { CallbackName = "OnProcessedModProgressUpdate" };
			ListOfModsToDisplayUpdated = new gameuiSendModGridInfoCallback { CallbackName = "OnListOfModsToDisplayUpdated" };
			PagesLayoutChanged = new gameuiUpdatePageLayoutCallback { CallbackName = "OnPagesLayoutChanged" };
			SwitchBetweenBrowserAndCollectionMenu = new inkBoolCallback { CallbackName = "OnSwitchBetweenBrowserAndCollectionMenu" };
			RequestLogoForWidget = new gameuiRequestMediaForWidgetCallback { CallbackName = "OnRequestLogoForWidget" };
			RequestedGalleryOnServer = new gameuiMenuIntCallback { CallbackName = "OnRequestedGalleryOnServer" };
			RequestGalleryForWidget = new gameuiRequestMediaForWidgetCallback { CallbackName = "OnRequestGalleryForWidget" };
			AllLanguagesCheckboxClicked = new gameuiAllLanguagesCheckboxCallback { CallbackName = "OnAllLanguagesCheckboxClicked" };
			SearchbarUpdate = new inkEmptyCallback { CallbackName = "OnSearchbarUpdate" };
			CheckIfEnabledModsListChanged = new inkBoolCallback { CallbackName = "OnCheckIfEnabledModsListChanged" };
			RateLimitedErrorReceived = new inkEmptyCallback { CallbackName = "OnRateLimitedErrorReceived" };
			RateLimitedErrorLifted = new inkEmptyCallback { CallbackName = "OnRateLimitedErrorLifted" };
			UpdateModVerificationPopupCount = new gameuiSendModUpdateVerificationInfo { CallbackName = "OnUpdateModVerificationPopupCount" };
			ModTagsReceived = new gameuiFilterTagsReceivedCallback { CallbackName = "OnModTagsReceived" };
			DelayedSpawnForFilters = new inkEmptyCallback { CallbackName = "OnDelayedSpawnForFilters" };
			DelayedSliderAdjustForDrawer = new inkEmptyCallback { CallbackName = "OnDelayedSliderAdjustForDrawer" };
			HiddenModListUpdated = new gameuiReceivedHiddenModsListCallback { CallbackName = "OnHiddenModListUpdated" };
			AskedForNewModList = new inkEmptyCallback { CallbackName = "OnAskedForNewModList" };
			BIsInBrowserMode = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
