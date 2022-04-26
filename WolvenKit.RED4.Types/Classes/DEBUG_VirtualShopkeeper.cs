using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DEBUG_VirtualShopkeeper : gameObject
	{
		[Ordinal(35)] 
		[RED("vendorID")] 
		public CString VendorID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public DEBUG_VirtualShopkeeper()
		{
			VendorID = "Vendors.CCLVendor";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
