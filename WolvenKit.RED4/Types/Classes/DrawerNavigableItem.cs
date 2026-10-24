using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DrawerNavigableItem : inkButtonController
	{
		[Ordinal(13)] 
		[RED("widgetToFocusTo")] 
		public inkWidgetReference WidgetToFocusTo
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("nextNavigateUpTarget")] 
		public CWeakHandle<DrawerNavigableItem> NextNavigateUpTarget
		{
			get => GetPropertyValue<CWeakHandle<DrawerNavigableItem>>();
			set => SetPropertyValue<CWeakHandle<DrawerNavigableItem>>(value);
		}

		[Ordinal(15)] 
		[RED("nextNavigateDownTarget")] 
		public CWeakHandle<DrawerNavigableItem> NextNavigateDownTarget
		{
			get => GetPropertyValue<CWeakHandle<DrawerNavigableItem>>();
			set => SetPropertyValue<CWeakHandle<DrawerNavigableItem>>(value);
		}

		public DrawerNavigableItem()
		{
			WidgetToFocusTo = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
