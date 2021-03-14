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
			get
			{
				if (_combatPreset == null)
				{
					_combatPreset = (CEnum<EAICombatPreset>) CR2WTypeManager.Create("EAICombatPreset", "combatPreset", cr2w, this);
				}
				return _combatPreset;
			}
			set
			{
				if (_combatPreset == value)
				{
					return;
				}
				_combatPreset = value;
				PropertySet(this);
			}
		}

		public AISetCombatPresetCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
