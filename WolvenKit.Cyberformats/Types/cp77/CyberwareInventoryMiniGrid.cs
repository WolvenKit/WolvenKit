using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberwareInventoryMiniGrid : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("gridContainer")] public inkUniformGridWidgetReference GridContainer { get; set; }
		[Ordinal(2)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(3)] [RED("sublabel")] public inkTextWidgetReference Sublabel { get; set; }
		[Ordinal(4)] [RED("number")] public inkTextWidgetReference Number { get; set; }
		[Ordinal(5)] [RED("numberPanel")] public inkWidgetReference NumberPanel { get; set; }
		[Ordinal(6)] [RED("gridWidth")] public CInt32 GridWidth { get; set; }
		[Ordinal(7)] [RED("selectedSlotIndex")] public CInt32 SelectedSlotIndex { get; set; }
		[Ordinal(8)] [RED("toEquipeSlotIndex")] public CInt32 ToEquipeSlotIndex { get; set; }
		[Ordinal(9)] [RED("equipArea")] public CEnum<gamedataEquipmentArea> EquipArea { get; set; }
		[Ordinal(10)] [RED("parentObject")] public CHandle<IScriptable> ParentObject { get; set; }
		[Ordinal(11)] [RED("onRealeaseCallbackName")] public CName OnRealeaseCallbackName { get; set; }
		[Ordinal(12)] [RED("gridData")] public CArray<CHandle<InventoryItemDisplayController>> GridData { get; set; }

		public CyberwareInventoryMiniGrid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
