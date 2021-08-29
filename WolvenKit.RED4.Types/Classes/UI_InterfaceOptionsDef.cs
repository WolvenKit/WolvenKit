using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_InterfaceOptionsDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _crowdsOnMinimap;
		private gamebbScriptID_Bool _objectMarkersEnabled;
		private gamebbScriptID_Bool _nPCNamesEnabled;

		[Ordinal(0)] 
		[RED("CrowdsOnMinimap")] 
		public gamebbScriptID_Bool CrowdsOnMinimap
		{
			get => GetProperty(ref _crowdsOnMinimap);
			set => SetProperty(ref _crowdsOnMinimap, value);
		}

		[Ordinal(1)] 
		[RED("ObjectMarkersEnabled")] 
		public gamebbScriptID_Bool ObjectMarkersEnabled
		{
			get => GetProperty(ref _objectMarkersEnabled);
			set => SetProperty(ref _objectMarkersEnabled, value);
		}

		[Ordinal(2)] 
		[RED("NPCNamesEnabled")] 
		public gamebbScriptID_Bool NPCNamesEnabled
		{
			get => GetProperty(ref _nPCNamesEnabled);
			set => SetProperty(ref _nPCNamesEnabled, value);
		}
	}
}
