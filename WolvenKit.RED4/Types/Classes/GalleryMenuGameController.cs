using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GalleryMenuGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("favoriteManagerRef")] 
		public inkWidgetReference FavoriteManagerRef
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
		[RED("globalWrapper")] 
		public inkWidgetReference GlobalWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("screenshotsGrid")] 
		public inkCompoundWidgetReference ScreenshotsGrid
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("filtersGrid")] 
		public inkWidgetReference FiltersGrid
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("paginationWidget")] 
		public inkCompoundWidgetReference PaginationWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("globalPreloaderContainer")] 
		public inkWidgetReference GlobalPreloaderContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("screenshotsPerPage")] 
		public CInt32 ScreenshotsPerPage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("noPermissionWidget")] 
		public inkWidgetReference NoPermissionWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("noPermissionController")] 
		public CWeakHandle<GalleryPopup> NoPermissionController
		{
			get => GetPropertyValue<CWeakHandle<GalleryPopup>>();
			set => SetPropertyValue<CWeakHandle<GalleryPopup>>(value);
		}

		[Ordinal(14)] 
		[RED("globalPreloader")] 
		public CWeakHandle<inkWidget> GlobalPreloader
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("paginationController")] 
		public CWeakHandle<PaginationController> PaginationController
		{
			get => GetPropertyValue<CWeakHandle<PaginationController>>();
			set => SetPropertyValue<CWeakHandle<PaginationController>>(value);
		}

		[Ordinal(16)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(17)] 
		[RED("systemHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(18)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(19)] 
		[RED("screenshotInfos")] 
		public CArray<inkGameScreenshotInfo> ScreenshotInfos
		{
			get => GetPropertyValue<CArray<inkGameScreenshotInfo>>();
			set => SetPropertyValue<CArray<inkGameScreenshotInfo>>(value);
		}

		[Ordinal(20)] 
		[RED("sortedScreenshotInfos")] 
		public CArray<inkGameScreenshotInfo> SortedScreenshotInfos
		{
			get => GetPropertyValue<CArray<inkGameScreenshotInfo>>();
			set => SetPropertyValue<CArray<inkGameScreenshotInfo>>(value);
		}

		[Ordinal(21)] 
		[RED("screenshotFullPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ScreenshotFullPreviewPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(22)] 
		[RED("filterTypes")] 
		public CArray<CEnum<inkGameScreenshotSortMode>> FilterTypes
		{
			get => GetPropertyValue<CArray<CEnum<inkGameScreenshotSortMode>>>();
			set => SetPropertyValue<CArray<CEnum<inkGameScreenshotSortMode>>>(value);
		}

		[Ordinal(23)] 
		[RED("activeSort")] 
		public CWeakHandle<GalleryFilterController> ActiveSort
		{
			get => GetPropertyValue<CWeakHandle<GalleryFilterController>>();
			set => SetPropertyValue<CWeakHandle<GalleryFilterController>>(value);
		}

		[Ordinal(24)] 
		[RED("isFavoriteFiltering")] 
		public CBool IsFavoriteFiltering
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("screenshotItems")] 
		public CArray<CWeakHandle<GalleryScreenshotItem>> ScreenshotItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<GalleryScreenshotItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<GalleryScreenshotItem>>>(value);
		}

		[Ordinal(26)] 
		[RED("pageCount")] 
		public CInt32 PageCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(27)] 
		[RED("currentPage")] 
		public CInt32 CurrentPage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(28)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(29)] 
		[RED("favoriteManager")] 
		public CWeakHandle<GalleryFavoriteManager> FavoriteManager
		{
			get => GetPropertyValue<CWeakHandle<GalleryFavoriteManager>>();
			set => SetPropertyValue<CWeakHandle<GalleryFavoriteManager>>(value);
		}

		[Ordinal(30)] 
		[RED("onInputDeviceChangedCallbackID")] 
		public CHandle<redCallbackObject> OnInputDeviceChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("deleteConfirmationToken")] 
		public CHandle<inkGameNotificationToken> DeleteConfirmationToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(32)] 
		[RED("deleteScreenshotId")] 
		public CInt32 DeleteScreenshotId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(33)] 
		[RED("visualStateName")] 
		public CName VisualStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("isSecondaryActionEnabled")] 
		public CBool IsSecondaryActionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("filterButtons")] 
		public CArray<CWeakHandle<GalleryFilterController>> FilterButtons
		{
			get => GetPropertyValue<CArray<CWeakHandle<GalleryFilterController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<GalleryFilterController>>>(value);
		}

		[Ordinal(36)] 
		[RED("canInteract")] 
		public CBool CanInteract
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("playerObj")] 
		public CWeakHandle<gameObject> PlayerObj
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(38)] 
		[RED("pageToDisplayOnLoad")] 
		public CInt32 PageToDisplayOnLoad
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public GalleryMenuGameController()
		{
			TooltipsManagerRef = new inkWidgetReference();
			FavoriteManagerRef = new inkWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			GlobalWrapper = new inkWidgetReference();
			ScreenshotsGrid = new inkCompoundWidgetReference();
			FiltersGrid = new inkWidgetReference();
			PaginationWidget = new inkCompoundWidgetReference();
			GlobalPreloaderContainer = new inkWidgetReference();
			NoPermissionWidget = new inkWidgetReference();
			GameInstance = new ScriptGameInstance();
			ScreenshotInfos = new();
			SortedScreenshotInfos = new();
			FilterTypes = new();
			ScreenshotItems = new();
			CurrentPage = -1;
			DeleteScreenshotId = -1;
			VisualStateName = "inkGameGalleryMenuState";
			IsSecondaryActionEnabled = true;
			FilterButtons = new();
			CanInteract = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
