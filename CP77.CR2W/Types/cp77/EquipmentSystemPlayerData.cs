using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EquipmentSystemPlayerData : IScriptable
	{
		[Ordinal(0)]  [RED("clothingSlotsInfo")] public CArray<gameSSlotInfo> ClothingSlotsInfo { get; set; }
		[Ordinal(1)]  [RED("equipment")] public gameSLoadout Equipment { get; set; }
		[Ordinal(2)]  [RED("eventsSent")] public CInt32 EventsSent { get; set; }
		[Ordinal(3)]  [RED("hiddenItems")] public CArray<gameItemID> HiddenItems { get; set; }
		[Ordinal(4)]  [RED("hotkeys")] public CArray<CHandle<Hotkey>> Hotkeys { get; set; }
		[Ordinal(5)]  [RED("inventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(6)]  [RED("isPartialVisualTagActive")] public CBool IsPartialVisualTagActive { get; set; }
		[Ordinal(7)]  [RED("lastUsedStruct")] public gameSLastUsedWeapon LastUsedStruct { get; set; }
		[Ordinal(8)]  [RED("owner")] public wCHandle<ScriptedPuppet> Owner { get; set; }
		[Ordinal(9)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(10)]  [RED("slotActiveItemsInHands")] public gameSSlotActiveItems SlotActiveItemsInHands { get; set; }
		[Ordinal(11)]  [RED("visualTagProcessingInfo")] public CArray<gameSVisualTagProcessing> VisualTagProcessingInfo { get; set; }

		public EquipmentSystemPlayerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
