using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPaymentCondition : questTypedCondition
	{
		private CHandle<questIPayment_ConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIPayment_ConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
