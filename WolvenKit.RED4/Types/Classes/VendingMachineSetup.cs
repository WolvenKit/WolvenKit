using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
