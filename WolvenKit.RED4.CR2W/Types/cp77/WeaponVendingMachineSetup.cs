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
			get
			{
				if (_vendorTweakID == null)
				{
					_vendorTweakID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "vendorTweakID", cr2w, this);
				}
				return _vendorTweakID;
			}
			set
			{
				if (_vendorTweakID == value)
				{
					return;
				}
				_vendorTweakID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("junkItemID")] 
		public TweakDBID JunkItemID
		{
			get
			{
				if (_junkItemID == null)
				{
					_junkItemID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "junkItemID", cr2w, this);
				}
				return _junkItemID;
			}
			set
			{
				if (_junkItemID == value)
				{
					return;
				}
				_junkItemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timeToCompletePurchase")] 
		public CFloat TimeToCompletePurchase
		{
			get
			{
				if (_timeToCompletePurchase == null)
				{
					_timeToCompletePurchase = (CFloat) CR2WTypeManager.Create("Float", "timeToCompletePurchase", cr2w, this);
				}
				return _timeToCompletePurchase;
			}
			set
			{
				if (_timeToCompletePurchase == value)
				{
					return;
				}
				_timeToCompletePurchase = value;
				PropertySet(this);
			}
		}

		public WeaponVendingMachineSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
