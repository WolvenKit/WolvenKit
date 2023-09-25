using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryCyberwareDisplayController : InventoryItemDisplayController
	{
		[Ordinal(116)] 
		[RED("ownedFrame")] 
		public inkWidgetReference OwnedFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(117)] 
		[RED("selectedFrame")] 
		public inkWidgetReference SelectedFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(118)] 
		[RED("amountPanel")] 
		public inkWidgetReference AmountPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(119)] 
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
