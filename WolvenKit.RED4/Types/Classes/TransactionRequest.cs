using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TransactionRequest : MarketSystemRequest
	{
		[Ordinal(2)] 
		[RED("requestID")] 
		public CInt32 RequestID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("items")] 
		public CArray<TransactionRequestData> Items
		{
			get => GetPropertyValue<CArray<TransactionRequestData>>();
			set => SetPropertyValue<CArray<TransactionRequestData>>(value);
		}

		public TransactionRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
