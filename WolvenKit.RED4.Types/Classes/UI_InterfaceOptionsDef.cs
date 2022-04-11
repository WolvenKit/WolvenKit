using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_InterfaceOptionsDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("CrowdsOnMinimap")] 
		public gamebbScriptID_Bool CrowdsOnMinimap
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("ObjectMarkersEnabled")] 
		public gamebbScriptID_Bool ObjectMarkersEnabled
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("NPCNamesEnabled")] 
		public gamebbScriptID_Bool NPCNamesEnabled
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_InterfaceOptionsDef()
		{
			CrowdsOnMinimap = new();
			ObjectMarkersEnabled = new();
			NPCNamesEnabled = new();
		}
	}
}
