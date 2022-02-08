using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryCyberwareDisplayController : InventoryItemDisplayController
	{
		[Ordinal(80)] 
		[RED("ownedFrame")] 
		public inkWidgetReference OwnedFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(81)] 
		[RED("selectedFrame")] 
		public inkWidgetReference SelectedFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(82)] 
		[RED("amountPanel")] 
		public inkWidgetReference AmountPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(83)] 
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
		}
	}
}
