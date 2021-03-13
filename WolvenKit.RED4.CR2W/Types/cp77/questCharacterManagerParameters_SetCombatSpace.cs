using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetCombatSpace : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)] [RED("combatSpaceSize")] public CEnum<AICombatSpaceSize> CombatSpaceSize { get; set; }

		public questCharacterManagerParameters_SetCombatSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
