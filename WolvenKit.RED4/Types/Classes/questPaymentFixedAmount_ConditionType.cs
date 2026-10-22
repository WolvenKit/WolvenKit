
namespace WolvenKit.RED4.Types
{
	public partial class questPaymentFixedAmount_ConditionType : questIPayment_ConditionType
	{
		public questPaymentFixedAmount_ConditionType()
		{
			ScriptCondition = new PaymentFixedAmount_ScriptConditionType();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
