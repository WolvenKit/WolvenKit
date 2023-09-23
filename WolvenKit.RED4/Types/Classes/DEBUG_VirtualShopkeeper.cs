using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DEBUG_VirtualShopkeeper : gameObject
	{
		[Ordinal(36)] 
		[RED("vendorID")] 
		public CString VendorID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public DEBUG_VirtualShopkeeper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
