using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DEBUG_VirtualShopkeeper : gameObject
	{
		private CString _vendorID;

		[Ordinal(40)] 
		[RED("vendorID")] 
		public CString VendorID
		{
			get => GetProperty(ref _vendorID);
			set => SetProperty(ref _vendorID, value);
		}

		public DEBUG_VirtualShopkeeper()
		{
			_vendorID = new() { Text = "Vendors.CCLVendor" };
		}
	}
}
