using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_InterfaceOptionsDef : gamebbScriptDefinition
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

		public UI_InterfaceOptionsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
