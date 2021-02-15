using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_SetWeaponState : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] [RED("areaType")] public CEnum<gameCityAreaType> AreaType { get; set; }

		public questCharacterManagerCombat_SetWeaponState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
