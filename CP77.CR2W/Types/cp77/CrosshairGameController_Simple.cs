using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Simple : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(1)]  [RED("crosshairState")] public CEnum<gamePSMCrosshairStates> CrosshairState { get; set; }
		[Ordinal(2)]  [RED("visionState")] public CEnum<gamePSMVision> VisionState { get; set; }
		[Ordinal(3)]  [RED("crosshairStateBlackboardId")] public CUInt32 CrosshairStateBlackboardId { get; set; }
		[Ordinal(4)]  [RED("bulletSpreedBlackboardId")] public CUInt32 BulletSpreedBlackboardId { get; set; }
		[Ordinal(5)]  [RED("bbNPCStatsId")] public CUInt32 BbNPCStatsId { get; set; }
		[Ordinal(6)]  [RED("isTargetDead")] public CBool IsTargetDead { get; set; }
		[Ordinal(7)]  [RED("lastGUIStateUpdateFrame")] public CUInt64 LastGUIStateUpdateFrame { get; set; }
		[Ordinal(8)]  [RED("targetBB")] public wCHandle<gameIBlackboard> TargetBB { get; set; }
		[Ordinal(9)]  [RED("weaponBB")] public wCHandle<gameIBlackboard> WeaponBB { get; set; }
		[Ordinal(10)]  [RED("currentAimTargetBBID")] public CUInt32 CurrentAimTargetBBID { get; set; }
		[Ordinal(11)]  [RED("targetDistanceBBID")] public CUInt32 TargetDistanceBBID { get; set; }
		[Ordinal(12)]  [RED("targetAttitudeBBID")] public CUInt32 TargetAttitudeBBID { get; set; }
		[Ordinal(13)]  [RED("targetEntity")] public wCHandle<entEntity> TargetEntity { get; set; }
		[Ordinal(14)]  [RED("healthListener")] public CHandle<CrosshairHealthChangeListener> HealthListener { get; set; }
		[Ordinal(15)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(16)]  [RED("leftPart")] public inkImageWidgetReference LeftPart { get; set; }
		[Ordinal(17)]  [RED("rightPart")] public inkImageWidgetReference RightPart { get; set; }
		[Ordinal(18)]  [RED("leftPartExtra")] public inkImageWidgetReference LeftPartExtra { get; set; }
		[Ordinal(19)]  [RED("rightPartExtra")] public inkImageWidgetReference RightPartExtra { get; set; }
		[Ordinal(20)]  [RED("offsetLeftRight")] public CFloat OffsetLeftRight { get; set; }
		[Ordinal(21)]  [RED("offsetLeftRightExtra")] public CFloat OffsetLeftRightExtra { get; set; }
		[Ordinal(22)]  [RED("latchVertical")] public CFloat LatchVertical { get; set; }
		[Ordinal(23)]  [RED("topPart")] public inkImageWidgetReference TopPart { get; set; }
		[Ordinal(24)]  [RED("bottomPart")] public inkImageWidgetReference BottomPart { get; set; }
		[Ordinal(25)]  [RED("horiPart")] public inkWidgetReference HoriPart { get; set; }
		[Ordinal(26)]  [RED("vertPart")] public inkWidgetReference VertPart { get; set; }
		[Ordinal(27)]  [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(28)]  [RED("middlePart")] public inkWidgetReference MiddlePart { get; set; }
		[Ordinal(29)]  [RED("overheatShake")] public inkWidgetReference OverheatShake { get; set; }
		[Ordinal(30)]  [RED("overheatTL")] public inkWidgetReference OverheatTL { get; set; }
		[Ordinal(31)]  [RED("overheatBL")] public inkWidgetReference OverheatBL { get; set; }
		[Ordinal(32)]  [RED("overheatTR")] public inkWidgetReference OverheatTR { get; set; }
		[Ordinal(33)]  [RED("overheatBR")] public inkWidgetReference OverheatBR { get; set; }
		[Ordinal(34)]  [RED("weaponLocalBB")] public CHandle<gameIBlackboard> WeaponLocalBB { get; set; }
		[Ordinal(35)]  [RED("onChargeChangeBBID")] public CUInt32 OnChargeChangeBBID { get; set; }
		[Ordinal(36)]  [RED("shakeAnimation")] public CHandle<inkanimProxy> ShakeAnimation { get; set; }
		[Ordinal(37)]  [RED("isInForcedCool")] public CBool IsInForcedCool { get; set; }

		public CrosshairGameController_Simple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
