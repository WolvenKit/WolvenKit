using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetVendorPriceMultiplierRequest : gameScriptableSystemRequest
	{
		private TweakDBID _vendorID;
		private CFloat _multiplier;

		[Ordinal(0)] 
		[RED("vendorID")] 
		public TweakDBID VendorID
		{
			get
			{
				if (_vendorID == null)
				{
					_vendorID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "vendorID", cr2w, this);
				}
				return _vendorID;
			}
			set
			{
				if (_vendorID == value)
				{
					return;
				}
				_vendorID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get
			{
				if (_multiplier == null)
				{
					_multiplier = (CFloat) CR2WTypeManager.Create("Float", "multiplier", cr2w, this);
				}
				return _multiplier;
			}
			set
			{
				if (_multiplier == value)
				{
					return;
				}
				_multiplier = value;
				PropertySet(this);
			}
		}

		public SetVendorPriceMultiplierRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
