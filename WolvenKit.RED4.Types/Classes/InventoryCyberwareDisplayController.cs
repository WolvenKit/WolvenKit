using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryCyberwareDisplayController : InventoryItemDisplayController
	{
		[Ordinal(99)] 
		[RED("ownedFrame")] 
		public inkWidgetReference OwnedFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(100)] 
		[RED("selectedFrame")] 
		public inkWidgetReference SelectedFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(101)] 
		[RED("amountPanel")] 
		public inkWidgetReference AmountPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(102)] 
		[RED("amount")] 
		public inkTextWidgetReference Amount
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public InventoryCyberwareDisplayController()
		{
			OwnedFrame = new();
			SelectedFrame = new();
			AmountPanel = new();
			Amount = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
