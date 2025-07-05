using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("vendorData")] 
		public CHandle<questVendorPanelData> VendorData
		{
			get => GetPropertyValue<CHandle<questVendorPanelData>>();
			set => SetPropertyValue<CHandle<questVendorPanelData>>(value);
		}

		[Ordinal(1)] 
		[RED("menu")] 
		public CString Menu
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public VendorUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
