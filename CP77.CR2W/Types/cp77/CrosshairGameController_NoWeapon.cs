using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_NoWeapon : gameuiCrosshairBaseGameController
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
		[Ordinal(16)]  [RED("AimDownSightContainer")] public inkCompoundWidgetReference AimDownSightContainer { get; set; }
		[Ordinal(17)]  [RED("ZoomMovingContainer")] public inkCompoundWidgetReference ZoomMovingContainer { get; set; }
		[Ordinal(18)]  [RED("ZoomNumber")] public inkTextWidgetReference ZoomNumber { get; set; }
		[Ordinal(19)]  [RED("ZoomNumberR")] public inkTextWidgetReference ZoomNumberR { get; set; }
		[Ordinal(20)]  [RED("DistanceImageRuler")] public inkImageWidgetReference DistanceImageRuler { get; set; }
		[Ordinal(21)]  [RED("ZoomMoveBracketL")] public inkImageWidgetReference ZoomMoveBracketL { get; set; }
		[Ordinal(22)]  [RED("ZoomMoveBracketR")] public inkImageWidgetReference ZoomMoveBracketR { get; set; }
		[Ordinal(23)]  [RED("ZoomLevelString")] public CString ZoomLevelString { get; set; }
		[Ordinal(24)]  [RED("PlayerSMBB")] public CHandle<gameIBlackboard> PlayerSMBB { get; set; }
		[Ordinal(25)]  [RED("ZoomLevelBBID")] public CUInt32 ZoomLevelBBID { get; set; }
		[Ordinal(26)]  [RED("sceneTierBlackboardId")] public CUInt32 SceneTierBlackboardId { get; set; }
		[Ordinal(27)]  [RED("sceneTier")] public CEnum<gamePSMHighLevel> SceneTier { get; set; }
		[Ordinal(28)]  [RED("zoomUpAnim")] public CHandle<inkanimProxy> ZoomUpAnim { get; set; }
		[Ordinal(29)]  [RED("animLockOn")] public CHandle<inkanimProxy> AnimLockOn { get; set; }
		[Ordinal(30)]  [RED("zoomDownAnim")] public CHandle<inkanimProxy> ZoomDownAnim { get; set; }
		[Ordinal(31)]  [RED("animLockOff")] public CHandle<inkanimProxy> AnimLockOff { get; set; }
		[Ordinal(32)]  [RED("zoomShowAnim")] public CHandle<inkanimProxy> ZoomShowAnim { get; set; }
		[Ordinal(33)]  [RED("zoomHideAnim")] public CHandle<inkanimProxy> ZoomHideAnim { get; set; }
		[Ordinal(34)]  [RED("argZoomBuffered")] public CFloat ArgZoomBuffered { get; set; }

		public CrosshairGameController_NoWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
