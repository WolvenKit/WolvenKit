using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_AutodriveDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("AutoDriveAvailable")] 
		public gamebbScriptID_Bool AutoDriveAvailable
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("AutoDriveEnabled")] 
		public gamebbScriptID_Bool AutoDriveEnabled
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("AutoDriveDelamain")] 
		public gamebbScriptID_Bool AutoDriveDelamain
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("FreeRoamEnabled")] 
		public gamebbScriptID_Bool FreeRoamEnabled
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(4)] 
		[RED("CinematicCameraActive")] 
		public gamebbScriptID_Bool CinematicCameraActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_AutodriveDataDef()
		{
			AutoDriveAvailable = new gamebbScriptID_Bool();
			AutoDriveEnabled = new gamebbScriptID_Bool();
			AutoDriveDelamain = new gamebbScriptID_Bool();
			FreeRoamEnabled = new gamebbScriptID_Bool();
			CinematicCameraActive = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
