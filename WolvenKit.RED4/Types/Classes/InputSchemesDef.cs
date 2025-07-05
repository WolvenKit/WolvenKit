using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InputSchemesDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("Device")] 
		public gamebbScriptID_Uint32 Device
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(1)] 
		[RED("Scheme")] 
		public gamebbScriptID_Uint32 Scheme
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(2)] 
		[RED("InitializedInputHintManagerList")] 
		public gamebbScriptID_Variant InitializedInputHintManagerList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public InputSchemesDef()
		{
			Device = new gamebbScriptID_Uint32();
			Scheme = new gamebbScriptID_Uint32();
			InitializedInputHintManagerList = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
