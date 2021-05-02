using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuEventBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_CName _menuEventToTrigger;

		[Ordinal(0)] 
		[RED("MenuEventToTrigger")] 
		public gamebbScriptID_CName MenuEventToTrigger
		{
			get => GetProperty(ref _menuEventToTrigger);
			set => SetProperty(ref _menuEventToTrigger, value);
		}

		public MenuEventBlackboardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
