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

		[Ordinal(3)] 
		[RED("IsMouserActive")] 
		public gamebbScriptID_Bool IsMouserActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(4)] 
		[RED("IsJoyconDualStyle")] 
		public gamebbScriptID_Bool IsJoyconDualStyle
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(5)] 
		[RED("ActiveStyle")] 
		public gamebbScriptID_CName ActiveStyle
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		public InputSchemesDef()
		{
			Device = new gamebbScriptID_Uint32();
			Scheme = new gamebbScriptID_Uint32();
			InitializedInputHintManagerList = new gamebbScriptID_Variant();
			IsMouserActive = new gamebbScriptID_Bool();
			IsJoyconDualStyle = new gamebbScriptID_Bool();
			ActiveStyle = new gamebbScriptID_CName();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
