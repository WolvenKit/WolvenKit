using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModSortingDropdownListController : DropdownListController
	{
		[Ordinal(8)] 
		[RED("owningMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwningMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		public ModSortingDropdownListController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
