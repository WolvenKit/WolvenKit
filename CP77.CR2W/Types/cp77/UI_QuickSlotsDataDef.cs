using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_QuickSlotsDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("UIRadialContextRequest")] public gamebbScriptID_Bool UIRadialContextRequest { get; set; }
		[Ordinal(1)] [RED("UIRadialContextRightStickAngle")] public gamebbScriptID_Float UIRadialContextRightStickAngle { get; set; }
		[Ordinal(2)] [RED("leftStick")] public gamebbScriptID_Vector4 LeftStick { get; set; }
		[Ordinal(3)] [RED("DPadCommand")] public gamebbScriptID_Variant DPadCommand { get; set; }
		[Ordinal(4)] [RED("KeyboardCommand")] public gamebbScriptID_Variant KeyboardCommand { get; set; }
		[Ordinal(5)] [RED("WheelInteractionStarted")] public gamebbScriptID_Variant WheelInteractionStarted { get; set; }
		[Ordinal(6)] [RED("WheelInteractionEnded")] public gamebbScriptID_Variant WheelInteractionEnded { get; set; }
		[Ordinal(7)] [RED("CyberwareAssignmentComplete")] public gamebbScriptID_Bool CyberwareAssignmentComplete { get; set; }
		[Ordinal(8)] [RED("WheelAssignmentComplete")] public gamebbScriptID_Bool WheelAssignmentComplete { get; set; }
		[Ordinal(9)] [RED("quickSlotsStructure")] public gamebbScriptID_Variant QuickSlotsStructure { get; set; }
		[Ordinal(10)] [RED("activeQuickSlotItem")] public gamebbScriptID_Variant ActiveQuickSlotItem { get; set; }
		[Ordinal(11)] [RED("quickSlotsActiveWeaponIndex")] public gamebbScriptID_Int32 QuickSlotsActiveWeaponIndex { get; set; }
		[Ordinal(12)] [RED("quickhackPanelOpen")] public gamebbScriptID_Bool QuickhackPanelOpen { get; set; }
		[Ordinal(13)] [RED("quickHackDescritpionVisible")] public gamebbScriptID_Bool QuickHackDescritpionVisible { get; set; }
		[Ordinal(14)] [RED("quickHackDataSelected")] public gamebbScriptID_Variant QuickHackDataSelected { get; set; }
		[Ordinal(15)] [RED("dpadHintRefresh")] public gamebbScriptID_Bool DpadHintRefresh { get; set; }
		[Ordinal(16)] [RED("containerConsumable")] public gamebbScriptID_Variant ContainerConsumable { get; set; }
		[Ordinal(17)] [RED("consumableBeingUsed")] public gamebbScriptID_Variant ConsumableBeingUsed { get; set; }

		public UI_QuickSlotsDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
