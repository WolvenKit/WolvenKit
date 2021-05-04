using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CompanionDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _flatHeadSpawned;

		[Ordinal(0)] 
		[RED("flatHeadSpawned")] 
		public gamebbScriptID_Bool FlatHeadSpawned
		{
			get => GetProperty(ref _flatHeadSpawned);
			set => SetProperty(ref _flatHeadSpawned, value);
		}

		public UI_CompanionDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
