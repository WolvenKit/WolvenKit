using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TVDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] 
		[RED("PreviousChannel")] 
		public gamebbScriptID_Int32 PreviousChannel
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(8)] 
		[RED("CurrentChannel")] 
		public gamebbScriptID_Int32 CurrentChannel
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public TVDeviceBlackboardDef()
		{
			PreviousChannel = new();
			CurrentChannel = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
