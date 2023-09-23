using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceTakeControlDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("DevicesChain")] 
		public gamebbScriptID_Variant DevicesChain
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("ActiveDevice")] 
		public gamebbScriptID_EntityID ActiveDevice
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(2)] 
		[RED("IsDeviceWorking")] 
		public gamebbScriptID_Bool IsDeviceWorking
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("ChainLocked")] 
		public gamebbScriptID_Bool ChainLocked
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public DeviceTakeControlDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
