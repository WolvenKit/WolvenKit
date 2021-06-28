using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISetCombatPresetCommand : AICombatRelatedCommand
	{
		private CEnum<EAICombatPreset> _combatPreset;

		[Ordinal(5)] 
		[RED("combatPreset")] 
		public CEnum<EAICombatPreset> CombatPreset
		{
			get => GetProperty(ref _combatPreset);
			set => SetProperty(ref _combatPreset, value);
		}

		public AISetCombatPresetCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
