using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorUserData : IScriptable
	{
		private CHandle<questVendorPanelData> _vendorData;
		private CString _menu;

		[Ordinal(0)] 
		[RED("vendorData")] 
		public CHandle<questVendorPanelData> VendorData
		{
			get
			{
				if (_vendorData == null)
				{
					_vendorData = (CHandle<questVendorPanelData>) CR2WTypeManager.Create("handle:questVendorPanelData", "vendorData", cr2w, this);
				}
				return _vendorData;
			}
			set
			{
				if (_vendorData == value)
				{
					return;
				}
				_vendorData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("menu")] 
		public CString Menu
		{
			get
			{
				if (_menu == null)
				{
					_menu = (CString) CR2WTypeManager.Create("String", "menu", cr2w, this);
				}
				return _menu;
			}
			set
			{
				if (_menu == value)
				{
					return;
				}
				_menu = value;
				PropertySet(this);
			}
		}

		public VendorUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
