using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_VendorDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _vendorData;

		[Ordinal(0)] 
		[RED("VendorData")] 
		public gamebbScriptID_Variant VendorData
		{
			get => GetProperty(ref _vendorData);
			set => SetProperty(ref _vendorData, value);
		}
	}
}
