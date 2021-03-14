using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_VirtualShopkeeper : gameObject
	{
		private CString _vendorID;

		[Ordinal(40)] 
		[RED("vendorID")] 
		public CString VendorID
		{
			get
			{
				if (_vendorID == null)
				{
					_vendorID = (CString) CR2WTypeManager.Create("String", "vendorID", cr2w, this);
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

		public DEBUG_VirtualShopkeeper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
