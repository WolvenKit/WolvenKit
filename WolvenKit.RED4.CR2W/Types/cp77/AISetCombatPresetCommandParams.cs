using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISetCombatPresetCommandParams : questScriptedAICommandParams
	{
		private CEnum<EAICombatPreset> _combatPreset;

		[Ordinal(0)] 
		[RED("combatPreset")] 
		public CEnum<EAICombatPreset> CombatPreset
		{
			get => GetProperty(ref _combatPreset);
			set => SetProperty(ref _combatPreset, value);
		}

		public AISetCombatPresetCommandParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
