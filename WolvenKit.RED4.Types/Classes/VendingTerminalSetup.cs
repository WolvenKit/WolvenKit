using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendingTerminalSetup : RedBaseClass
	{
		private TweakDBID _vendorTweakID;
		private CArray<CEnum<EVendorMode>> _vendingBlacklist;
		private CFloat _timeToCompletePurchase;

		[Ordinal(0)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get => GetProperty(ref _vendorTweakID);
			set => SetProperty(ref _vendorTweakID, value);
		}

		[Ordinal(1)] 
		[RED("vendingBlacklist")] 
		public CArray<CEnum<EVendorMode>> VendingBlacklist
		{
			get => GetProperty(ref _vendingBlacklist);
			set => SetProperty(ref _vendingBlacklist, value);
		}

		[Ordinal(2)] 
		[RED("timeToCompletePurchase")] 
		public CFloat TimeToCompletePurchase
		{
			get => GetProperty(ref _timeToCompletePurchase);
			set => SetProperty(ref _timeToCompletePurchase, value);
		}

		public VendingTerminalSetup()
		{
			_timeToCompletePurchase = 3.000000F;
		}
	}
}
