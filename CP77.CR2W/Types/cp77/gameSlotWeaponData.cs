using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSlotWeaponData : CVariable
	{
		[Ordinal(0)]  [RED("ammoCurrent")] public CInt32 AmmoCurrent { get; set; }
		[Ordinal(1)]  [RED("ammoId")] public gameItemID AmmoId { get; set; }
		[Ordinal(2)]  [RED("evolution")] public CEnum<gamedataWeaponEvolution> Evolution { get; set; }
		[Ordinal(3)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(4)]  [RED("isFirstEquip")] public CBool IsFirstEquip { get; set; }
		[Ordinal(5)]  [RED("magazineCap")] public CInt32 MagazineCap { get; set; }
		[Ordinal(6)]  [RED("triggerModeCurrent")] public CEnum<gamedataTriggerMode> TriggerModeCurrent { get; set; }
		[Ordinal(7)]  [RED("triggerModeList")] public CArray<CEnum<gamedataTriggerMode>> TriggerModeList { get; set; }
		[Ordinal(8)]  [RED("weaponID")] public gameItemID WeaponID { get; set; }

		public gameSlotWeaponData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
