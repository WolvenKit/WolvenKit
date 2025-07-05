using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryCyberwareDisplayController : InventoryItemDisplayController
	{
		[Ordinal(120)] 
		[RED("ownedFrame")] 
		public inkWidgetReference OwnedFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(121)] 
		[RED("selectedFrame")] 
		public inkWidgetReference SelectedFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(122)] 
		[RED("amountPanel")] 
		public inkWidgetReference AmountPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(123)] 
		[RED("amount")] 
		public inkTextWidgetReference Amount
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public InventoryCyberwareDisplayController()
		{
			OwnedFrame = new inkWidgetReference();
			SelectedFrame = new inkWidgetReference();
			AmountPanel = new inkWidgetReference();
			Amount = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
