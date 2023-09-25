using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PaymentConditionTypeBase : BluelineConditionTypeBase
	{
		[Ordinal(0)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("payWhenSucceded")] 
		public CBool PayWhenSucceded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PaymentConditionTypeBase()
		{
			PayWhenSucceded = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
