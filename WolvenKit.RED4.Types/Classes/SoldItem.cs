using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SoldItem : IScriptable
	{
		private gameItemID _itemID;
		private CInt32 _quantity;
		private CInt32 _piecePrice;

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
		[RED("piecePrice")] 
		public CInt32 PiecePrice
		{
			get => GetProperty(ref _piecePrice);
			set => SetProperty(ref _piecePrice, value);
		}
	}
}
