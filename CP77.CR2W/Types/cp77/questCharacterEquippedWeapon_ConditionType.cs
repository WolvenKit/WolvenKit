using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterEquippedWeapon_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("anyWeaponEquipped")] public CBool AnyWeaponEquipped { get; set; }
		[Ordinal(1)]  [RED("weaponID")] public CString WeaponID { get; set; }
		[Ordinal(2)]  [RED("weaponTag")] public CName WeaponTag { get; set; }
		[Ordinal(3)]  [RED("inverted")] public CBool Inverted { get; set; }

		public questCharacterEquippedWeapon_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
