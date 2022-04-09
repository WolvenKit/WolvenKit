using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SelectMenuRequest : redEvent
	{
		[Ordinal(0)] 
		[RED("eventData")] 
		public CWeakHandle<MenuItemController> EventData
		{
			get => GetPropertyValue<CWeakHandle<MenuItemController>>();
			set => SetPropertyValue<CWeakHandle<MenuItemController>>(value);
		}

		public SelectMenuRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
