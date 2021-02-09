using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EquipmentSystemPlayerData : IScriptable
	{
		[Ordinal(0)]  [RED("owner")] public wCHandle<ScriptedPuppet> Owner { get; set; }
		[Ordinal(1)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(2)]  [RED("equipment")] public gameSLoadout Equipment { get; set; }
		[Ordinal(3)]  [RED("lastUsedStruct")] public gameSLastUsedWeapon LastUsedStruct { get; set; }
		[Ordinal(4)]  [RED("slotActiveItemsInHands")] public gameSSlotActiveItems SlotActiveItemsInHands { get; set; }
		[Ordinal(5)]  [RED("hiddenItems")] public CArray<gameItemID> HiddenItems { get; set; }
		[Ordinal(6)]  [RED("clothingSlotsInfo")] public CArray<gameSSlotInfo> ClothingSlotsInfo { get; set; }
		[Ordinal(7)]  [RED("isPartialVisualTagActive")] public CBool IsPartialVisualTagActive { get; set; }
		[Ordinal(8)]  [RED("visualTagProcessingInfo")] public CArray<gameSVisualTagProcessing> VisualTagProcessingInfo { get; set; }
		[Ordinal(9)]  [RED("eventsSent")] public CInt32 EventsSent { get; set; }
		[Ordinal(10)]  [RED("hotkeys")] public CArray<CHandle<Hotkey>> Hotkeys { get; set; }
		[Ordinal(11)]  [RED("inventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }

		public EquipmentSystemPlayerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
