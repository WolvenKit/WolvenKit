using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractiveDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] 
		[RED("showAd")] 
		public gamebbScriptID_Bool ShowAd
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(8)] 
		[RED("showVendor")] 
		public gamebbScriptID_Bool ShowVendor
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public InteractiveDeviceBlackboardDef()
		{
			ShowAd = new();
			ShowVendor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
