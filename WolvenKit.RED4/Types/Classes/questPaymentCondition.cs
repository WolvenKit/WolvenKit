using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPaymentCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIPayment_ConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIPayment_ConditionType>>();
			set => SetPropertyValue<CHandle<questIPayment_ConditionType>>(value);
		}

		public questPaymentCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
