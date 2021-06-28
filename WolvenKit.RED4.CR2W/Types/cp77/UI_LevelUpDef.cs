using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_LevelUpDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _level;

		[Ordinal(0)] 
		[RED("level")] 
		public gamebbScriptID_Variant Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		public UI_LevelUpDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
