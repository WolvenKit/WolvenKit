using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElevatorDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] 
		[RED("CurrentFloor")] 
		public gamebbScriptID_String CurrentFloor
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(8)] 
		[RED("isPlayerScanned")] 
		public gamebbScriptID_Bool IsPlayerScanned
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(9)] 
		[RED("isPaused")] 
		public gamebbScriptID_Bool IsPaused
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public ElevatorDeviceBlackboardDef()
		{
			CurrentFloor = new gamebbScriptID_String();
			IsPlayerScanned = new gamebbScriptID_Bool();
			IsPaused = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
