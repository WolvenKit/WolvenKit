using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSlotWeaponData : CVariable
	{
		[Ordinal(0)] [RED("weaponID")] public gameItemID WeaponID { get; set; }
		[Ordinal(1)] [RED("ammoCurrent")] public CInt32 AmmoCurrent { get; set; }
		[Ordinal(2)] [RED("magazineCap")] public CInt32 MagazineCap { get; set; }
		[Ordinal(3)] [RED("ammoId")] public gameItemID AmmoId { get; set; }
		[Ordinal(4)] [RED("triggerModeCurrent")] public CEnum<gamedataTriggerMode> TriggerModeCurrent { get; set; }
		[Ordinal(5)] [RED("triggerModeList")] public CArray<CEnum<gamedataTriggerMode>> TriggerModeList { get; set; }
		[Ordinal(6)] [RED("evolution")] public CEnum<gamedataWeaponEvolution> Evolution { get; set; }
		[Ordinal(7)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(8)] [RED("isFirstEquip")] public CBool IsFirstEquip { get; set; }

		public gameSlotWeaponData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
