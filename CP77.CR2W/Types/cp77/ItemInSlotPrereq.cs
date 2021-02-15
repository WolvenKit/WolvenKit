using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemInSlotPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(1)] [RED("slotCheckType")] public CEnum<EItemSlotCheckType> SlotCheckType { get; set; }
		[Ordinal(2)] [RED("itemType")] public CEnum<gamedataItemType> ItemType { get; set; }
		[Ordinal(3)] [RED("itemCategory")] public CEnum<gamedataItemCategory> ItemCategory { get; set; }
		[Ordinal(4)] [RED("weaponEvolution")] public CEnum<gamedataWeaponEvolution> WeaponEvolution { get; set; }
		[Ordinal(5)] [RED("itemTag")] public CName ItemTag { get; set; }
		[Ordinal(6)] [RED("invert")] public CBool Invert { get; set; }
		[Ordinal(7)] [RED("skipOnApply")] public CBool SkipOnApply { get; set; }

		public ItemInSlotPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
