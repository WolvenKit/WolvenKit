using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryRipperdocDisplayController : InventoryItemDisplayController
	{
		[Ordinal(120)] 
		[RED("ownedBackground")] 
		public inkWidgetReference OwnedBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(121)] 
		[RED("ownedSign")] 
		public inkWidgetReference OwnedSign
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public InventoryRipperdocDisplayController()
		{
			OwnedBackground = new inkWidgetReference();
			OwnedSign = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
