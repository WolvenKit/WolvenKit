using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponVendingMachineSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("junkItemID")] 
		public TweakDBID JunkItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("timeToCompletePurchase")] 
		public CFloat TimeToCompletePurchase
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public WeaponVendingMachineSetup()
		{
			TimeToCompletePurchase = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
