using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TargetHitIndicatorGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("aimingStatusBlackboardId")] public CUInt32 AimingStatusBlackboardId { get; set; }
		[Ordinal(1)]  [RED("bonusAnim")] public CHandle<inkanimProxy> BonusAnim { get; set; }
		[Ordinal(2)]  [RED("bonusController")] public wCHandle<TargetHitIndicatorLogicController> BonusController { get; set; }
		[Ordinal(3)]  [RED("currentAnim")] public CHandle<inkanimProxy> CurrentAnim { get; set; }
		[Ordinal(4)]  [RED("currentAnimWidget")] public wCHandle<inkWidget> CurrentAnimWidget { get; set; }
		[Ordinal(5)]  [RED("currentController")] public wCHandle<TargetHitIndicatorLogicController> CurrentController { get; set; }
		[Ordinal(6)]  [RED("currentPriority")] public CInt32 CurrentPriority { get; set; }
		[Ordinal(7)]  [RED("currentSway")] public Vector2 CurrentSway { get; set; }
		[Ordinal(8)]  [RED("currentWeaponZoom")] public CFloat CurrentWeaponZoom { get; set; }
		[Ordinal(9)]  [RED("currentZoomLevel")] public CFloat CurrentZoomLevel { get; set; }
		[Ordinal(10)]  [RED("damageController")] public wCHandle<TargetHitIndicatorLogicController> DamageController { get; set; }
		[Ordinal(11)]  [RED("damageListBlackboardId")] public CUInt32 DamageListBlackboardId { get; set; }
		[Ordinal(12)]  [RED("defeatController")] public wCHandle<TargetHitIndicatorLogicController> DefeatController { get; set; }
		[Ordinal(13)]  [RED("entityHit")] public wCHandle<gameObject> EntityHit { get; set; }
		[Ordinal(14)]  [RED("hitIndicatorEnabled")] public CBool HitIndicatorEnabled { get; set; }
		[Ordinal(15)]  [RED("indicatorEnabledBlackboardId")] public CUInt32 IndicatorEnabledBlackboardId { get; set; }
		[Ordinal(16)]  [RED("isAimingDownSights")] public CBool IsAimingDownSights { get; set; }
		[Ordinal(17)]  [RED("killController")] public wCHandle<TargetHitIndicatorLogicController> KillController { get; set; }
		[Ordinal(18)]  [RED("killListBlackboardId")] public CUInt32 KillListBlackboardId { get; set; }
		[Ordinal(19)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(20)]  [RED("realOwner")] public wCHandle<gameObject> RealOwner { get; set; }
		[Ordinal(21)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(22)]  [RED("weaponChangeBlackboardId")] public CUInt32 WeaponChangeBlackboardId { get; set; }
		[Ordinal(23)]  [RED("weaponID")] public gameStatsObjectID WeaponID { get; set; }
		[Ordinal(24)]  [RED("weaponSwayBlackboardId")] public CUInt32 WeaponSwayBlackboardId { get; set; }
		[Ordinal(25)]  [RED("weaponZoomListener")] public CHandle<HitIndicatorWeaponZoomListener> WeaponZoomListener { get; set; }
		[Ordinal(26)]  [RED("weaponZoomNeedsUpdate")] public CBool WeaponZoomNeedsUpdate { get; set; }
		[Ordinal(27)]  [RED("zoomLevelBlackboardId")] public CUInt32 ZoomLevelBlackboardId { get; set; }

		public TargetHitIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
