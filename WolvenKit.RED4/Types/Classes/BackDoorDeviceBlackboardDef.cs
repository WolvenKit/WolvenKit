using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BackDoorDeviceBlackboardDef : MasterDeviceBaseBlackboardDef
	{
		[Ordinal(9)] 
		[RED("isInDefaultState")] 
		public gamebbScriptID_Bool IsInDefaultState
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(10)] 
		[RED("shutdownModule")] 
		public gamebbScriptID_Int32 ShutdownModule
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(11)] 
		[RED("bootModule")] 
		public gamebbScriptID_Int32 BootModule
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public BackDoorDeviceBlackboardDef()
		{
			IsInDefaultState = new gamebbScriptID_Bool();
			ShutdownModule = new gamebbScriptID_Int32();
			BootModule = new gamebbScriptID_Int32();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
