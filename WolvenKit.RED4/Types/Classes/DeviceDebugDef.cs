using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceDebugDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("CurrentlyDebuggedDevice")] 
		public gamebbScriptID_CName CurrentlyDebuggedDevice
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(1)] 
		[RED("DebuggedEntityIDAsString")] 
		public gamebbScriptID_String DebuggedEntityIDAsString
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		public DeviceDebugDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
