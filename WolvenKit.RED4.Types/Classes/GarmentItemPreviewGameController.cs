using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GarmentItemPreviewGameController : gameuiInventoryPuppetPreviewGameController
	{
		private CHandle<InventoryItemPreviewData> _data;
		private TweakDBID _placementSlot;
		private gameItemID _initialItem;
		private gameItemID _givenItem;
		private CBool _isMouseDown;

		[Ordinal(14)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(15)] 
		[RED("placementSlot")] 
		public TweakDBID PlacementSlot
		{
			get => GetProperty(ref _placementSlot);
			set => SetProperty(ref _placementSlot, value);
		}

		[Ordinal(16)] 
		[RED("initialItem")] 
		public gameItemID InitialItem
		{
			get => GetProperty(ref _initialItem);
			set => SetProperty(ref _initialItem, value);
		}

		[Ordinal(17)] 
		[RED("givenItem")] 
		public gameItemID GivenItem
		{
			get => GetProperty(ref _givenItem);
			set => SetProperty(ref _givenItem, value);
		}

		[Ordinal(18)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetProperty(ref _isMouseDown);
			set => SetProperty(ref _isMouseDown, value);
		}
	}
}
