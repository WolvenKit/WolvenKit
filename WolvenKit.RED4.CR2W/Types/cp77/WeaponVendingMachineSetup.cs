using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponVendingMachineSetup : CVariable
	{
		private TweakDBID _vendorTweakID;
		private TweakDBID _junkItemID;
		private CFloat _timeToCompletePurchase;

		[Ordinal(0)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get => GetProperty(ref _vendorTweakID);
			set => SetProperty(ref _vendorTweakID, value);
		}

		[Ordinal(1)] 
		[RED("junkItemID")] 
		public TweakDBID JunkItemID
		{
			get => GetProperty(ref _junkItemID);
			set => SetProperty(ref _junkItemID, value);
		}

		[Ordinal(2)] 
		[RED("timeToCompletePurchase")] 
		public CFloat TimeToCompletePurchase
		{
			get => GetProperty(ref _timeToCompletePurchase);
			set => SetProperty(ref _timeToCompletePurchase, value);
		}

		public WeaponVendingMachineSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
