using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Paperdoll : animAnimFeature
	{
		[Ordinal(0)]  [RED("characterCreation")] public CBool CharacterCreation { get; set; }
		[Ordinal(1)]  [RED("characterCreation_Head")] public CBool CharacterCreation_Head { get; set; }
		[Ordinal(2)]  [RED("characterCreation_Nails")] public CBool CharacterCreation_Nails { get; set; }
		[Ordinal(3)]  [RED("characterCreation_Summary")] public CBool CharacterCreation_Summary { get; set; }
		[Ordinal(4)]  [RED("characterCreation_Teeth")] public CBool CharacterCreation_Teeth { get; set; }
		[Ordinal(5)]  [RED("genderSelection")] public CBool GenderSelection { get; set; }
		[Ordinal(6)]  [RED("inventoryScreen")] public CBool InventoryScreen { get; set; }
		[Ordinal(7)]  [RED("inventoryScreen_Consumable")] public CBool InventoryScreen_Consumable { get; set; }
		[Ordinal(8)]  [RED("inventoryScreen_Cyberware")] public CBool InventoryScreen_Cyberware { get; set; }
		[Ordinal(9)]  [RED("inventoryScreen_Face")] public CBool InventoryScreen_Face { get; set; }
		[Ordinal(10)]  [RED("inventoryScreen_Feet")] public CBool InventoryScreen_Feet { get; set; }
		[Ordinal(11)]  [RED("inventoryScreen_Head")] public CBool InventoryScreen_Head { get; set; }
		[Ordinal(12)]  [RED("inventoryScreen_InnerChest")] public CBool InventoryScreen_InnerChest { get; set; }
		[Ordinal(13)]  [RED("inventoryScreen_Legs")] public CBool InventoryScreen_Legs { get; set; }
		[Ordinal(14)]  [RED("inventoryScreen_OuterChest")] public CBool InventoryScreen_OuterChest { get; set; }
		[Ordinal(15)]  [RED("inventoryScreen_Outfit")] public CBool InventoryScreen_Outfit { get; set; }
		[Ordinal(16)]  [RED("inventoryScreen_QuickSlot")] public CBool InventoryScreen_QuickSlot { get; set; }
		[Ordinal(17)]  [RED("inventoryScreen_Weapon")] public CBool InventoryScreen_Weapon { get; set; }

		public AnimFeature_Paperdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
