using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetCombatSpace : questICharacterManagerCombat_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CEnum<AICombatSpaceSize> _combatSpaceSize;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("combatSpaceSize")] 
		public CEnum<AICombatSpaceSize> CombatSpaceSize
		{
			get
			{
				if (_combatSpaceSize == null)
				{
					_combatSpaceSize = (CEnum<AICombatSpaceSize>) CR2WTypeManager.Create("AICombatSpaceSize", "combatSpaceSize", cr2w, this);
				}
				return _combatSpaceSize;
			}
			set
			{
				if (_combatSpaceSize == value)
				{
					return;
				}
				_combatSpaceSize = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerParameters_SetCombatSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
