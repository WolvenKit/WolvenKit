using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModSortingDropdownButtonController : DropdownButtonController
	{
		[Ordinal(5)] 
		[RED("navigableComponentRef")] 
		public inkWidgetReference NavigableComponentRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("ownerWidget")] 
		public CWeakHandle<ModDetailsItem> OwnerWidget
		{
			get => GetPropertyValue<CWeakHandle<ModDetailsItem>>();
			set => SetPropertyValue<CWeakHandle<ModDetailsItem>>(value);
		}

		[Ordinal(7)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(8)] 
		[RED("navigableComponentController")] 
		public CWeakHandle<AnimatedListItemController> NavigableComponentController
		{
			get => GetPropertyValue<CWeakHandle<AnimatedListItemController>>();
			set => SetPropertyValue<CWeakHandle<AnimatedListItemController>>(value);
		}

		[Ordinal(9)] 
		[RED("menuColors")] 
		public ModsMenuColorsNames MenuColors
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		public ModSortingDropdownButtonController()
		{
			NavigableComponentRef = new inkWidgetReference();
			MenuColors = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
