using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MarketSystemRequest : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _owner;
		private TweakDBID _vendorID;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public MarketSystemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
