using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetVendorPriceMultiplierRequest : gameScriptableSystemRequest
	{
		private TweakDBID _vendorID;
		private CFloat _multiplier;

		[Ordinal(0)] 
		[RED("vendorID")] 
		public TweakDBID VendorID
		{
			get => GetProperty(ref _vendorID);
			set => SetProperty(ref _vendorID, value);
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetProperty(ref _multiplier);
			set => SetProperty(ref _multiplier, value);
		}

		public SetVendorPriceMultiplierRequest()
		{
			_multiplier = 1.000000F;
		}
	}
}
