using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiWeaponRosterInfo : CVariable
	{
		[Ordinal(0)]  [RED("ammoAvailable")] public CInt32 AmmoAvailable { get; set; }
		[Ordinal(1)]  [RED("ammoCurrent")] public CInt32 AmmoCurrent { get; set; }
		[Ordinal(2)]  [RED("ammoMagazine")] public CInt32 AmmoMagazine { get; set; }
		[Ordinal(3)]  [RED("damageTypeList")] public CArray<CEnum<gamedataDamageType>> DamageTypeList { get; set; }
		[Ordinal(4)]  [RED("fileModeList")] public CArray<CName> FileModeList { get; set; }
		[Ordinal(5)]  [RED("fireModeCurrent")] public CInt32 FireModeCurrent { get; set; }
		[Ordinal(6)]  [RED("weaponId")] public CInt32 WeaponId { get; set; }

		public gameuiWeaponRosterInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
