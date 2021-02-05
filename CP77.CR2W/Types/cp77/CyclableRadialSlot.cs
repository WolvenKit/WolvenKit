using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyclableRadialSlot : WeaponRadialSlot
	{
		[Ordinal(0)]  [RED("slotAnchorRef")] public inkWidgetReference SlotAnchorRef { get; set; }
		[Ordinal(1)]  [RED("libraryRef")] public inkWidgetLibraryReference LibraryRef { get; set; }
		[Ordinal(2)]  [RED("slotType")] public CEnum<SlotType> SlotType { get; set; }
		[Ordinal(3)]  [RED("animData")] public RadialAnimData AnimData { get; set; }
		[Ordinal(4)]  [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }
		[Ordinal(5)]  [RED("targetAngle")] public CFloat TargetAngle { get; set; }
		[Ordinal(6)]  [RED("active")] public CString Active { get; set; }
		[Ordinal(7)]  [RED("inactive")] public CString Inactive { get; set; }
		[Ordinal(8)]  [RED("blocked")] public CString Blocked { get; set; }
		[Ordinal(9)]  [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(10)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(11)]  [RED("leftArrowEmpty")] public inkWidgetReference LeftArrowEmpty { get; set; }
		[Ordinal(12)]  [RED("leftArrowFull")] public inkWidgetReference LeftArrowFull { get; set; }
		[Ordinal(13)]  [RED("rightArrowEmpty")] public inkWidgetReference RightArrowEmpty { get; set; }
		[Ordinal(14)]  [RED("rightArrowFull")] public inkWidgetReference RightArrowFull { get; set; }
		[Ordinal(15)]  [RED("canCycle")] public CBool CanCycle { get; set; }
		[Ordinal(16)]  [RED("isCycling")] public CBool IsCycling { get; set; }
		[Ordinal(17)]  [RED("wasCyclingRight")] public CBool WasCyclingRight { get; set; }
		[Ordinal(18)]  [RED("hotkey")] public CEnum<gameEHotkey> Hotkey { get; set; }

		public CyclableRadialSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
