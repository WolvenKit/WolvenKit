using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SelectedFilterGroup : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("filterItemSpawner")] 
		public inkCompoundWidgetReference FilterItemSpawner
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("listOfFilters")] 
		public CArray<CWeakHandle<SelectedFilterItem>> ListOfFilters
		{
			get => GetPropertyValue<CArray<CWeakHandle<SelectedFilterItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<SelectedFilterItem>>>(value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<BrowserModsMenuGameController> Owner
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(4)] 
		[RED("filterDrawerRef")] 
		public CWeakHandle<ModMenuFilterDrawer> FilterDrawerRef
		{
			get => GetPropertyValue<CWeakHandle<ModMenuFilterDrawer>>();
			set => SetPropertyValue<CWeakHandle<ModMenuFilterDrawer>>(value);
		}

		public SelectedFilterGroup()
		{
			FilterItemSpawner = new inkCompoundWidgetReference();
			ListOfFilters = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
