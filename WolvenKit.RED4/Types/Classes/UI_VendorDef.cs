using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_VendorDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("VendorData")] 
		public gamebbScriptID_Variant VendorData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_VendorDef()
		{
			VendorData = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
