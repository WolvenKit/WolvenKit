using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class filterModsMenuModPicker : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("filterIconList")] 
		public inkHorizontalPanelWidgetReference FilterIconList
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		public filterModsMenuModPicker()
		{
			FilterIconList = new inkHorizontalPanelWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
