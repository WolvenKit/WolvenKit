using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendingMachineSetup : RedBaseClass
	{
		private CFloat _timeToCompletePurchase;

		[Ordinal(0)] 
		[RED("timeToCompletePurchase")] 
		public CFloat TimeToCompletePurchase
		{
			get => GetProperty(ref _timeToCompletePurchase);
			set => SetProperty(ref _timeToCompletePurchase, value);
		}

		public VendingMachineSetup()
		{
			_timeToCompletePurchase = 0.100000F;
		}
	}
}
