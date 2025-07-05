using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetVendorPriceMultiplierRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("vendorID")] 
		public TweakDBID VendorID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SetVendorPriceMultiplierRequest()
		{
			Multiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
