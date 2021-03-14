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
		[RED("vendingBlacklist")] 
		public CArray<CEnum<EVendorMode>> VendingBlacklist
		{
			get
			{
				if (_vendingBlacklist == null)
				{
					_vendingBlacklist = (CArray<CEnum<EVendorMode>>) CR2WTypeManager.Create("array:EVendorMode", "vendingBlacklist", cr2w, this);
				}
				return _vendingBlacklist;
			}
			set
			{
				if (_vendingBlacklist == value)
				{
					return;
				}
				_vendingBlacklist = value;
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

		public VendingTerminalSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
