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

		public VendorUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
