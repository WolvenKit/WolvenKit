using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorRegisterBlackBoardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _vendors;

		[Ordinal(0)] 
		[RED("vendors")] 
		public gamebbScriptID_Variant Vendors
		{
			get => GetProperty(ref _vendors);
			set => SetProperty(ref _vendors, value);
		}
	}
}
