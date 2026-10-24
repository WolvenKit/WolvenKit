using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModFilterCategoryFolder : DrawerNavigableItem
	{
		[Ordinal(16)] 
		[RED("folderNameText")] 
		public inkTextWidgetReference FolderNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("filterItemSpawner")] 
		public inkCompoundWidgetReference FilterItemSpawner
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("interactableWidget")] 
		public inkWidgetReference InteractableWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("arrowWidget")] 
		public inkWidgetReference ArrowWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("numberOfModsText")] 
		public inkTextWidgetReference NumberOfModsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("panelOutline")] 
		public inkWidgetReference PanelOutline
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("panelBackground")] 
		public inkWidgetReference PanelBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("fluffOutline")] 
		public inkWidgetReference FluffOutline
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("fluffBackground")] 
		public inkWidgetReference FluffBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("arrowOutline")] 
		public inkWidgetReference ArrowOutline
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("arrowFill")] 
		public inkWidgetReference ArrowFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("bAllowMultipleSelection")] 
		public CBool BAllowMultipleSelection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("bIsLanguageFolder")] 
		public CBool BIsLanguageFolder
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("filterItems")] 
		public CArray<CWeakHandle<ModFilterCategoryItem>> FilterItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<ModFilterCategoryItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ModFilterCategoryItem>>>(value);
		}

		[Ordinal(30)] 
		[RED("selectedActiveFilters")] 
		public CArray<CWeakHandle<ModFilterCategoryItem>> SelectedActiveFilters
		{
			get => GetPropertyValue<CArray<CWeakHandle<ModFilterCategoryItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ModFilterCategoryItem>>>(value);
		}

		[Ordinal(31)] 
		[RED("isFolded")] 
		public CBool IsFolded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		[Ordinal(33)] 
		[RED("ownerDrawer")] 
		public CWeakHandle<ModMenuFilterDrawer> OwnerDrawer
		{
			get => GetPropertyValue<CWeakHandle<ModMenuFilterDrawer>>();
			set => SetPropertyValue<CWeakHandle<ModMenuFilterDrawer>>(value);
		}

		[Ordinal(34)] 
		[RED("previousFolderRef")] 
		public CWeakHandle<ModFilterCategoryFolder> PreviousFolderRef
		{
			get => GetPropertyValue<CWeakHandle<ModFilterCategoryFolder>>();
			set => SetPropertyValue<CWeakHandle<ModFilterCategoryFolder>>(value);
		}

		[Ordinal(35)] 
		[RED("nextFolderRef")] 
		public CWeakHandle<ModFilterCategoryFolder> NextFolderRef
		{
			get => GetPropertyValue<CWeakHandle<ModFilterCategoryFolder>>();
			set => SetPropertyValue<CWeakHandle<ModFilterCategoryFolder>>(value);
		}

		public ModFilterCategoryFolder()
		{
			FolderNameText = new inkTextWidgetReference();
			FilterItemSpawner = new inkCompoundWidgetReference();
			InteractableWidget = new inkWidgetReference();
			ArrowWidget = new inkWidgetReference();
			NumberOfModsText = new inkTextWidgetReference();
			PanelOutline = new inkWidgetReference();
			PanelBackground = new inkWidgetReference();
			FluffOutline = new inkWidgetReference();
			FluffBackground = new inkWidgetReference();
			ArrowOutline = new inkWidgetReference();
			ArrowFill = new inkWidgetReference();
			FilterItems = new();
			SelectedActiveFilters = new();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
