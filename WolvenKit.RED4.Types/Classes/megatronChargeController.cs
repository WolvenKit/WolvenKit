using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class megatronChargeController : ChargeLogicController
	{
		private CWeakHandle<inkImageWidget> _chargeBar;

		[Ordinal(1)] 
		[RED("chargeBar")] 
		public CWeakHandle<inkImageWidget> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}
	}
}
