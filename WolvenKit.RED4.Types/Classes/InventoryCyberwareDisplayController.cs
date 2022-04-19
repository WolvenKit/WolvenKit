using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryCyberwareDisplayController : InventoryItemDisplayController
	{
		[Ordinal(90)] 
		[RED("ownedFrame")] 
		public inkWidgetReference OwnedFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(91)] 
		[RED("selectedFrame")] 
		public inkWidgetReference SelectedFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(92)] 
		[RED("amountPanel")] 
		public inkWidgetReference AmountPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(93)] 
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
