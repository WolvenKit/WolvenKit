using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_NPCNextToTheCrosshairDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _nameplateData;
		private gamebbScriptID_Variant _buffsList;
		private gamebbScriptID_Variant _debuffsList;

		[Ordinal(0)] 
		[RED("NameplateData")] 
		public gamebbScriptID_Variant NameplateData
		{
			get => GetProperty(ref _nameplateData);
			set => SetProperty(ref _nameplateData, value);
		}

		[Ordinal(1)] 
		[RED("BuffsList")] 
		public gamebbScriptID_Variant BuffsList
		{
			get => GetProperty(ref _buffsList);
			set => SetProperty(ref _buffsList, value);
		}

		[Ordinal(2)] 
		[RED("DebuffsList")] 
		public gamebbScriptID_Variant DebuffsList
		{
			get => GetProperty(ref _debuffsList);
			set => SetProperty(ref _debuffsList, value);
		}

		public UI_NPCNextToTheCrosshairDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
