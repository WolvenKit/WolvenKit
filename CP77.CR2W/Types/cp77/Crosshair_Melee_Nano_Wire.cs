using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Melee_Nano_Wire : CrosshairGameController_Melee
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
		[Ordinal(16)]  [RED("meleeStateBlackboardId")] public CUInt32 MeleeStateBlackboardId { get; set; }
		[Ordinal(17)]  [RED("playerSMBB")] public CHandle<gameIBlackboard> PlayerSMBB { get; set; }
		[Ordinal(18)]  [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(19)]  [RED("chargeBar")] public wCHandle<inkCanvasWidget> ChargeBar { get; set; }
		[Ordinal(20)]  [RED("chargeBarFG")] public wCHandle<inkRectangleWidget> ChargeBarFG { get; set; }
		[Ordinal(21)]  [RED("chargeBarMonoTop")] public wCHandle<inkImageWidget> ChargeBarMonoTop { get; set; }
		[Ordinal(22)]  [RED("chargeBarMonoBottom")] public wCHandle<inkImageWidget> ChargeBarMonoBottom { get; set; }
		[Ordinal(23)]  [RED("chargeBarMask")] public wCHandle<inkMaskWidget> ChargeBarMask { get; set; }
		[Ordinal(24)]  [RED("chargeValueL")] public wCHandle<inkTextWidget> ChargeValueL { get; set; }
		[Ordinal(25)]  [RED("chargeValueR")] public wCHandle<inkTextWidget> ChargeValueR { get; set; }
		[Ordinal(26)]  [RED("bbcharge")] public CUInt32 Bbcharge { get; set; }
		[Ordinal(27)]  [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }
		[Ordinal(28)]  [RED("meleeResourcePoolListener")] public CHandle<MeleeResourcePoolListener> MeleeResourcePoolListener { get; set; }
		[Ordinal(29)]  [RED("weaponID")] public entEntityID WeaponID { get; set; }
		[Ordinal(30)]  [RED("displayChargeBar")] public CBool DisplayChargeBar { get; set; }
		[Ordinal(31)]  [RED("animEnterADS")] public CHandle<inkanimProxy> AnimEnterADS { get; set; }
		[Ordinal(32)]  [RED("inAimDownSight")] public CBool InAimDownSight { get; set; }
		[Ordinal(33)]  [RED("isHoveringOfficer")] public CBool IsHoveringOfficer { get; set; }
		[Ordinal(34)]  [RED("inChargedHold")] public CBool InChargedHold { get; set; }
		[Ordinal(35)]  [RED("anim_EnterHipFire")] public CHandle<inkanimProxy> Anim_EnterHipFire { get; set; }
		[Ordinal(36)]  [RED("anim_HoverEnterEnemy")] public CHandle<inkanimProxy> Anim_HoverEnterEnemy { get; set; }
		[Ordinal(37)]  [RED("anim_EnterStrongAttack")] public CHandle<inkanimProxy> Anim_EnterStrongAttack { get; set; }
		[Ordinal(38)]  [RED("anim_EnterThrowAttack")] public CHandle<inkanimProxy> Anim_EnterThrowAttack { get; set; }
		[Ordinal(39)]  [RED("anim_EnterEveryOtherAttack")] public CHandle<inkanimProxy> Anim_EnterEveryOtherAttack { get; set; }
		[Ordinal(40)]  [RED("anim_EnterChargedHold")] public CHandle<inkanimProxy> Anim_EnterChargedHold { get; set; }
		[Ordinal(41)]  [RED("anim_HoverExitEnemy")] public CHandle<inkanimProxy> Anim_HoverExitEnemy { get; set; }

		public Crosshair_Melee_Nano_Wire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
