using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GarmentItemPreviewGameController : gameuiInventoryPuppetPreviewGameController
	{
		[Ordinal(14)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetPropertyValue<CHandle<InventoryItemPreviewData>>();
			set => SetPropertyValue<CHandle<InventoryItemPreviewData>>(value);
		}

		[Ordinal(15)] 
		[RED("placementSlot")] 
		public TweakDBID PlacementSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(16)] 
		[RED("initialItem")] 
		public gameItemID InitialItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(17)] 
		[RED("givenItem")] 
		public gameItemID GivenItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(18)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GarmentItemPreviewGameController()
		{
			InitialItem = new();
			GivenItem = new();
		}
	}
}
