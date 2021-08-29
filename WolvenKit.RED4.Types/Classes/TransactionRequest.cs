using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TransactionRequest : MarketSystemRequest
	{
		private CInt32 _requestID;
		private CArray<TransactionRequestData> _items;

		[Ordinal(2)] 
		[RED("requestID")] 
		public CInt32 RequestID
		{
			get => GetProperty(ref _requestID);
			set => SetProperty(ref _requestID, value);
		}

		[Ordinal(3)] 
		[RED("items")] 
		public CArray<TransactionRequestData> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
