using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPaymentConditionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isInverted")] 
		public CBool IsInverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("paymentItemId")] 
		public gameItemID PaymentItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("paymentAmount")] 
		public CUInt32 PaymentAmount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public questPaymentConditionData()
		{
			PaymentItemId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
