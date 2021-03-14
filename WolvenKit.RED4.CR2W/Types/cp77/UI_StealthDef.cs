using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_StealthDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _combatDebug;
		private gamebbScriptID_Uint32 _numberOfCombatants;

		[Ordinal(0)] 
		[RED("CombatDebug")] 
		public gamebbScriptID_Bool CombatDebug
		{
			get
			{
				if (_combatDebug == null)
				{
					_combatDebug = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "CombatDebug", cr2w, this);
				}
				return _combatDebug;
			}
			set
			{
				if (_combatDebug == value)
				{
					return;
				}
				_combatDebug = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("numberOfCombatants")] 
		public gamebbScriptID_Uint32 NumberOfCombatants
		{
			get
			{
				if (_numberOfCombatants == null)
				{
					_numberOfCombatants = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "numberOfCombatants", cr2w, this);
				}
				return _numberOfCombatants;
			}
			set
			{
				if (_numberOfCombatants == value)
				{
					return;
				}
				_numberOfCombatants = value;
				PropertySet(this);
			}
		}

		public UI_StealthDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
