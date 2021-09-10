using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DEBUG_VirtualShopkeeper : gameObject
	{
		[Ordinal(40)] 
		[RED("vendorID")] 
		public CString VendorID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public DEBUG_VirtualShopkeeper()
		{
			VendorID = "Vendors.CCLVendor";
		}
	}
}
