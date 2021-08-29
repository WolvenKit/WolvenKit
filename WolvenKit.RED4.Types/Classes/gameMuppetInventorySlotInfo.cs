using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInventorySlotInfo : RedBaseClass
	{
		private TweakDBID _itemCategory;
		private gameItemID _itemId;
		private CUInt32 _quantity;

		[Ordinal(0)] 
		[RED("itemCategory")] 
		public TweakDBID ItemCategory
		{
			get => GetProperty(ref _itemCategory);
			set => SetProperty(ref _itemCategory, value);
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(2)] 
		[RED("quantity")] 
		public CUInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}
	}
}
