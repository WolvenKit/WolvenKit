using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MasterDeviceBaseBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] 
		[RED("ThumbnailWidgetsData")] 
		public gamebbScriptID_Variant ThumbnailWidgetsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public MasterDeviceBaseBlackboardDef()
		{
			ThumbnailWidgetsData = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
