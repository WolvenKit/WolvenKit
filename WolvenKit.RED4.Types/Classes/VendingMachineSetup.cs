using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendingMachineSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("timeToCompletePurchase")] 
		public CFloat TimeToCompletePurchase
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public VendingMachineSetup()
		{
			TimeToCompletePurchase = 0.100000F;
		}
	}
}
