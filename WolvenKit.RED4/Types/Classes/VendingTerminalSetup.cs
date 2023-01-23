using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendingTerminalSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("vendingBlacklist")] 
		public CArray<CEnum<EVendorMode>> VendingBlacklist
		{
			get => GetPropertyValue<CArray<CEnum<EVendorMode>>>();
			set => SetPropertyValue<CArray<CEnum<EVendorMode>>>(value);
		}

		[Ordinal(2)] 
		[RED("timeToCompletePurchase")] 
		public CFloat TimeToCompletePurchase
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public VendingTerminalSetup()
		{
			VendingBlacklist = new();
			TimeToCompletePurchase = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
