using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickSlotCommand : CVariable
	{
		[Ordinal(0)]  [RED("ActionType")] public CEnum<QuickSlotActionType> ActionType { get; set; }
		[Ordinal(1)]  [RED("IsSlotUnlocked")] public CBool IsSlotUnlocked { get; set; }
		[Ordinal(2)]  [RED("IsLocked")] public CBool IsLocked { get; set; }
		[Ordinal(3)]  [RED("AtlasPath")] public CName AtlasPath { get; set; }
		[Ordinal(4)]  [RED("IconName")] public CName IconName { get; set; }
		[Ordinal(5)]  [RED("MaxTier")] public CInt32 MaxTier { get; set; }
		[Ordinal(6)]  [RED("VehicleState")] public CInt32 VehicleState { get; set; }
		[Ordinal(7)]  [RED("ItemId")] public gameItemID ItemId { get; set; }
		[Ordinal(8)]  [RED("Title")] public CString Title { get; set; }
		[Ordinal(9)]  [RED("Type")] public CString Type { get; set; }
		[Ordinal(10)]  [RED("Description")] public CString Description { get; set; }
		[Ordinal(11)]  [RED("IsEquipped")] public CBool IsEquipped { get; set; }
		[Ordinal(12)]  [RED("intData")] public CInt32 IntData { get; set; }
		[Ordinal(13)]  [RED("playerVehicleData")] public vehiclePlayerVehicle PlayerVehicleData { get; set; }
		[Ordinal(14)]  [RED("itemType")] public CEnum<QuickSlotItemType> ItemType { get; set; }
		[Ordinal(15)]  [RED("equipType")] public CEnum<gamedataEquipmentArea> EquipType { get; set; }
		[Ordinal(16)]  [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(17)]  [RED("interactiveAction")] public CHandle<gamedeviceAction> InteractiveAction { get; set; }
		[Ordinal(18)]  [RED("interactiveActionOwner")] public entEntityID InteractiveActionOwner { get; set; }

		public QuickSlotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
