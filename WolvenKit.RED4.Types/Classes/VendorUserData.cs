using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorUserData : IScriptable
	{
		private CHandle<questVendorPanelData> _vendorData;
		private CString _menu;

		[Ordinal(0)] 
		[RED("vendorData")] 
		public CHandle<questVendorPanelData> VendorData
		{
			get => GetProperty(ref _vendorData);
			set => SetProperty(ref _vendorData, value);
		}

		[Ordinal(1)] 
		[RED("menu")] 
		public CString Menu
		{
			get => GetProperty(ref _menu);
			set => SetProperty(ref _menu, value);
		}
	}
}
