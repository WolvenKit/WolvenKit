using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_SetWeaponState : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] [RED("areaType")] public CEnum<gameCityAreaType> AreaType { get; set; }

		public questCharacterManagerCombat_SetWeaponState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
