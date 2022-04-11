using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class megatronChargeController : ChargeLogicController
	{
		[Ordinal(1)] 
		[RED("chargeBar")] 
		public CWeakHandle<inkImageWidget> ChargeBar
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}
	}
}
