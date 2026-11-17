using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HiddenModManager : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("hiddenModsTab")] 
		public inkWidgetReference HiddenModsTab
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("hiddenAuthorsTab")] 
		public inkWidgetReference HiddenAuthorsTab
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("applyButtonRef")] 
		public inkWidgetReference ApplyButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("applyButtonText")] 
		public inkWidgetReference ApplyButtonText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public CHandle<HiddenModManagerPopupData> Data
		{
			get => GetPropertyValue<CHandle<HiddenModManagerPopupData>>();
			set => SetPropertyValue<CHandle<HiddenModManagerPopupData>>(value);
		}

		[Ordinal(8)] 
		[RED("ownerMenuRef")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenuRef
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(9)] 
		[RED("hiddenModsTabController")] 
		public CWeakHandle<HiddenManagerTabItem> HiddenModsTabController
		{
			get => GetPropertyValue<CWeakHandle<HiddenManagerTabItem>>();
			set => SetPropertyValue<CWeakHandle<HiddenManagerTabItem>>(value);
		}

		[Ordinal(10)] 
		[RED("hiddenAuthorsTabController")] 
		public CWeakHandle<HiddenManagerTabItem> HiddenAuthorsTabController
		{
			get => GetPropertyValue<CWeakHandle<HiddenManagerTabItem>>();
			set => SetPropertyValue<CWeakHandle<HiddenManagerTabItem>>(value);
		}

		[Ordinal(11)] 
		[RED("openAnim")] 
		public CHandle<inkanimProxy> OpenAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(12)] 
		[RED("closeAnim")] 
		public CHandle<inkanimProxy> CloseAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(13)] 
		[RED("applyButtonController")] 
		public CWeakHandle<inkButtonController> ApplyButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(14)] 
		[RED("closeButtonController")] 
		public CWeakHandle<inkButtonController> CloseButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(15)] 
		[RED("bHasChanges")] 
		public CBool BHasChanges
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("currentlyHoveredWidget")] 
		public CWeakHandle<inkWidget> CurrentlyHoveredWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(17)] 
		[RED("mainHiddenModsWidget")] 
		public inkWidgetReference MainHiddenModsWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("hiddenModSpawnerRef")] 
		public inkWidgetReference HiddenModSpawnerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("hiddenModList")] 
		public CArray<CWeakHandle<HiddenModItem>> HiddenModList
		{
			get => GetPropertyValue<CArray<CWeakHandle<HiddenModItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<HiddenModItem>>>(value);
		}

		[Ordinal(20)] 
		[RED("listOfHiddenModsToUnhide")] 
		public CArray<inkModioModInfos> ListOfHiddenModsToUnhide
		{
			get => GetPropertyValue<CArray<inkModioModInfos>>();
			set => SetPropertyValue<CArray<inkModioModInfos>>(value);
		}

		[Ordinal(21)] 
		[RED("mainHiddenAuthorsWidget")] 
		public inkWidgetReference MainHiddenAuthorsWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("hiddenAuthorSpawnerRef")] 
		public inkWidgetReference HiddenAuthorSpawnerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("hiddenAuthorList")] 
		public CArray<CWeakHandle<HiddenAuthorItem>> HiddenAuthorList
		{
			get => GetPropertyValue<CArray<CWeakHandle<HiddenAuthorItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<HiddenAuthorItem>>>(value);
		}

		[Ordinal(24)] 
		[RED("listOfHiddenAuthorsToUnhide")] 
		public CArray<inkModAuthorInfo> ListOfHiddenAuthorsToUnhide
		{
			get => GetPropertyValue<CArray<inkModAuthorInfo>>();
			set => SetPropertyValue<CArray<inkModAuthorInfo>>(value);
		}

		public HiddenModManager()
		{
			HiddenModsTab = new inkWidgetReference();
			HiddenAuthorsTab = new inkWidgetReference();
			ApplyButtonRef = new inkWidgetReference();
			ApplyButtonText = new inkWidgetReference();
			CloseButtonRef = new inkWidgetReference();
			MainHiddenModsWidget = new inkWidgetReference();
			HiddenModSpawnerRef = new inkWidgetReference();
			HiddenModList = new();
			ListOfHiddenModsToUnhide = new();
			MainHiddenAuthorsWidget = new inkWidgetReference();
			HiddenAuthorSpawnerRef = new inkWidgetReference();
			HiddenAuthorList = new();
			ListOfHiddenAuthorsToUnhide = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
