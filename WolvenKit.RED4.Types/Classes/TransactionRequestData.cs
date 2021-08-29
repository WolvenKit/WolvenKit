using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TransactionRequestData : RedBaseClass
	{
		private gameItemID _itemID;
		private CInt32 _quantity;
		private CFloat _powerLevel;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(2)] 
		[RED("powerLevel")] 
		public CFloat PowerLevel
		{
			get => GetProperty(ref _powerLevel);
			set => SetProperty(ref _powerLevel, value);
		}
	}
}
