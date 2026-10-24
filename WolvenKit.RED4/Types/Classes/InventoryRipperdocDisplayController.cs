using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryRipperdocDisplayController : InventoryItemDisplayController
	{
		[Ordinal(122)] 
		[RED("ownedBackground")] 
		public inkWidgetReference OwnedBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(123)] 
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
