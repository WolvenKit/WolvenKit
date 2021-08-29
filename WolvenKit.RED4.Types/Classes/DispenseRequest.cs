using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DispenseRequest : MarketSystemRequest
	{
		private Vector4 _position;
		private gameItemID _itemID;
		private CBool _shouldPay;

		[Ordinal(2)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(3)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(4)] 
		[RED("shouldPay")] 
		public CBool ShouldPay
		{
			get => GetProperty(ref _shouldPay);
			set => SetProperty(ref _shouldPay, value);
		}
	}
}
