using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerQuickHackDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _cachedQuickHackList;

		[Ordinal(0)] 
		[RED("CachedQuickHackList")] 
		public gamebbScriptID_Variant CachedQuickHackList
		{
			get => GetProperty(ref _cachedQuickHackList);
			set => SetProperty(ref _cachedQuickHackList, value);
		}

		public PlayerQuickHackDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
