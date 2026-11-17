using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModMenuFilterDrawer : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("resetFilterButton")] 
		public inkWidgetReference ResetFilterButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("closeAreaCanvas")] 
		public inkWidgetReference CloseAreaCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("folderSpawnerWidget")] 
		public inkWidgetReference FolderSpawnerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("scrollAreaRef")] 
		public inkScrollAreaWidgetReference ScrollAreaRef
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("sliderRef")] 
		public inkWidgetReference SliderRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("contentWindowRef")] 
		public inkWidgetReference ContentWindowRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("scrollCanvas")] 
		public inkCompoundWidgetReference ScrollCanvas
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("endOfScrollArea")] 
		public inkWidgetReference EndOfScrollArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("currentNumberOfFiltersAppliedText")] 
		public inkTextWidgetReference CurrentNumberOfFiltersAppliedText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(11)] 
		[RED("filterFolderList")] 
		public CArray<CWeakHandle<ModFilterCategoryFolder>> FilterFolderList
		{
			get => GetPropertyValue<CArray<CWeakHandle<ModFilterCategoryFolder>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ModFilterCategoryFolder>>>(value);
		}

		[Ordinal(12)] 
		[RED("activeFiltersList")] 
		public CArray<CWeakHandle<ModFilterCategoryItem>> ActiveFiltersList
		{
			get => GetPropertyValue<CArray<CWeakHandle<ModFilterCategoryItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ModFilterCategoryItem>>>(value);
		}

		[Ordinal(13)] 
		[RED("activeExceptionFiltersList")] 
		public CArray<CWeakHandle<ModFilterExceptionItem>> ActiveExceptionFiltersList
		{
			get => GetPropertyValue<CArray<CWeakHandle<ModFilterExceptionItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ModFilterExceptionItem>>>(value);
		}

		[Ordinal(14)] 
		[RED("bVisible")] 
		public CBool BVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("openAnim")] 
		public CHandle<inkanimProxy> OpenAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(16)] 
		[RED("closeAnim")] 
		public CHandle<inkanimProxy> CloseAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(17)] 
		[RED("scrollPosition")] 
		public CFloat ScrollPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("UpperHiddenContentSize")] 
		public CFloat UpperHiddenContentSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("cWindowSize")] 
		public CFloat CWindowSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("ContentSize")] 
		public CFloat ContentSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("currentlyNavigatedItem")] 
		public CWeakHandle<DrawerNavigableItem> CurrentlyNavigatedItem
		{
			get => GetPropertyValue<CWeakHandle<DrawerNavigableItem>>();
			set => SetPropertyValue<CWeakHandle<DrawerNavigableItem>>(value);
		}

		[Ordinal(22)] 
		[RED("lastFoldedOrUnfoldedFolder")] 
		public CWeakHandle<ModFilterCategoryFolder> LastFoldedOrUnfoldedFolder
		{
			get => GetPropertyValue<CWeakHandle<ModFilterCategoryFolder>>();
			set => SetPropertyValue<CWeakHandle<ModFilterCategoryFolder>>(value);
		}

		[Ordinal(23)] 
		[RED("endOfScrollAreaPos")] 
		public Vector2 EndOfScrollAreaPos
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(24)] 
		[RED("cursorPos")] 
		public Vector2 CursorPos
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(25)] 
		[RED("sliderController")] 
		public CWeakHandle<inkSliderController> SliderController
		{
			get => GetPropertyValue<CWeakHandle<inkSliderController>>();
			set => SetPropertyValue<CWeakHandle<inkSliderController>>(value);
		}

		[Ordinal(26)] 
		[RED("maximumNumberOfFiltersActivatedAtOnce")] 
		public CInt32 MaximumNumberOfFiltersActivatedAtOnce
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ModMenuFilterDrawer()
		{
			ResetFilterButton = new inkWidgetReference();
			CloseAreaCanvas = new inkWidgetReference();
			FolderSpawnerWidget = new inkWidgetReference();
			ScrollAreaRef = new inkScrollAreaWidgetReference();
			SliderRef = new inkWidgetReference();
			ContentWindowRef = new inkWidgetReference();
			ScrollCanvas = new inkCompoundWidgetReference();
			EndOfScrollArea = new inkWidgetReference();
			CurrentNumberOfFiltersAppliedText = new inkTextWidgetReference();
			FilterFolderList = new();
			ActiveFiltersList = new();
			ActiveExceptionFiltersList = new();
			EndOfScrollAreaPos = new Vector2();
			CursorPos = new Vector2();
			MaximumNumberOfFiltersActivatedAtOnce = 10;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
