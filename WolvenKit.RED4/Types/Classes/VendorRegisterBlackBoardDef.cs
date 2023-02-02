using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorRegisterBlackBoardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("vendors")] 
		public gamebbScriptID_Variant Vendors
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public VendorRegisterBlackBoardDef()
		{
			Vendors = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
