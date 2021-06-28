using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingTerminalSetup : CVariable
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

		public VendingTerminalSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
