using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IronsightGameController : gameuiIronsightGameController
	{
		[Ordinal(0)]  [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(1)]  [RED("dot")] public inkWidgetReference Dot { get; set; }
		[Ordinal(2)]  [RED("ammo")] public inkTextWidgetReference Ammo { get; set; }
		[Ordinal(3)]  [RED("ammoSpareCount")] public inkTextWidgetReference AmmoSpareCount { get; set; }
		[Ordinal(4)]  [RED("range")] public inkTextWidgetReference Range { get; set; }
		[Ordinal(5)]  [RED("seeThroughWalls")] public CBool SeeThroughWalls { get; set; }
		[Ordinal(6)]  [RED("targetAttitudeFriendly")] public inkWidgetReference TargetAttitudeFriendly { get; set; }
		[Ordinal(7)]  [RED("targetAttitudeHostile")] public inkWidgetReference TargetAttitudeHostile { get; set; }
		[Ordinal(8)]  [RED("targetAttitudeEnemyNonHostile")] public inkWidgetReference TargetAttitudeEnemyNonHostile { get; set; }
		[Ordinal(9)]  [RED("weaponDataBB")] public CHandle<gameIBlackboard> WeaponDataBB { get; set; }
		[Ordinal(10)]  [RED("targetHitAnimationName")] public CName TargetHitAnimationName { get; set; }
		[Ordinal(11)]  [RED("targetHitAnimation")] public CHandle<inkanimProxy> TargetHitAnimation { get; set; }
		[Ordinal(12)]  [RED("weaponDataTargetHitBBID")] public CUInt32 WeaponDataTargetHitBBID { get; set; }
		[Ordinal(13)]  [RED("shootAnimationName")] public CName ShootAnimationName { get; set; }
		[Ordinal(14)]  [RED("shootAnimation")] public CHandle<inkanimProxy> ShootAnimation { get; set; }
		[Ordinal(15)]  [RED("weaponDataShootBBID")] public CUInt32 WeaponDataShootBBID { get; set; }
		[Ordinal(16)]  [RED("currentAmmo")] public CInt32 CurrentAmmo { get; set; }
		[Ordinal(17)]  [RED("animIntro")] public CHandle<inkanimProxy> AnimIntro { get; set; }
		[Ordinal(18)]  [RED("animLoop")] public CHandle<inkanimProxy> AnimLoop { get; set; }
		[Ordinal(19)]  [RED("animReload")] public CHandle<inkanimProxy> AnimReload { get; set; }
		[Ordinal(20)]  [RED("BufferedRosterData")] public CHandle<gameSlotDataHolder> BufferedRosterData { get; set; }
		[Ordinal(21)]  [RED("ActiveWeapon")] public gameSlotWeaponData ActiveWeapon { get; set; }
		[Ordinal(22)]  [RED("weaponItemData")] public InventoryItemData WeaponItemData { get; set; }
		[Ordinal(23)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(24)]  [RED("bb")] public wCHandle<gameIBlackboard> Bb { get; set; }
		[Ordinal(25)]  [RED("bbID")] public CUInt32 BbID { get; set; }
		[Ordinal(26)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(27)]  [RED("targetBB")] public wCHandle<gameIBlackboard> TargetBB { get; set; }
		[Ordinal(28)]  [RED("targetRange")] public CFloat TargetRange { get; set; }
		[Ordinal(29)]  [RED("targetRangeBBID")] public CUInt32 TargetRangeBBID { get; set; }
		[Ordinal(30)]  [RED("targetAttitudeBBID")] public CUInt32 TargetAttitudeBBID { get; set; }
		[Ordinal(31)]  [RED("targetAcquiredBBID")] public CUInt32 TargetAcquiredBBID { get; set; }
		[Ordinal(32)]  [RED("targetRangeObstructedBBID")] public CUInt32 TargetRangeObstructedBBID { get; set; }
		[Ordinal(33)]  [RED("targetAcquiredObstructedBBID")] public CUInt32 TargetAcquiredObstructedBBID { get; set; }
		[Ordinal(34)]  [RED("targetRangeDecimalPrecision")] public CUInt32 TargetRangeDecimalPrecision { get; set; }
		[Ordinal(35)]  [RED("targetAttitudeAnimator")] public wCHandle<TargetAttitudeAnimationController> TargetAttitudeAnimator { get; set; }
		[Ordinal(36)]  [RED("targetAttitudeContainer")] public inkWidgetReference TargetAttitudeContainer { get; set; }
		[Ordinal(37)]  [RED("targetHealthListener")] public CHandle<IronsightTargetHealthChangeListener> TargetHealthListener { get; set; }
		[Ordinal(38)]  [RED("compass")] public wCHandle<CompassController> Compass { get; set; }
		[Ordinal(39)]  [RED("compassContainer")] public inkWidgetReference CompassContainer { get; set; }
		[Ordinal(40)]  [RED("compass2")] public wCHandle<CompassController> Compass2 { get; set; }
		[Ordinal(41)]  [RED("compassContainer2")] public inkWidgetReference CompassContainer2 { get; set; }
		[Ordinal(42)]  [RED("altimeter")] public wCHandle<AltimeterController> Altimeter { get; set; }
		[Ordinal(43)]  [RED("altimeterContainer")] public inkWidgetReference AltimeterContainer { get; set; }
		[Ordinal(44)]  [RED("weaponBB")] public wCHandle<gameIBlackboard> WeaponBB { get; set; }
		[Ordinal(45)]  [RED("chargebar")] public wCHandle<ChargebarController> Chargebar { get; set; }
		[Ordinal(46)]  [RED("chargebarContainer")] public inkWidgetReference ChargebarContainer { get; set; }
		[Ordinal(47)]  [RED("chargebarValueChanged")] public CUInt32 ChargebarValueChanged { get; set; }
		[Ordinal(48)]  [RED("chargebarTriggerModeChanged")] public CUInt32 ChargebarTriggerModeChanged { get; set; }
		[Ordinal(49)]  [RED("ADSContainer")] public inkWidgetReference ADSContainer { get; set; }
		[Ordinal(50)]  [RED("ADSAnimator")] public wCHandle<AimDownSightController> ADSAnimator { get; set; }
		[Ordinal(51)]  [RED("playerStateMachineBB")] public CHandle<gameIBlackboard> PlayerStateMachineBB { get; set; }
		[Ordinal(52)]  [RED("playerStateMachineUpperBodyBBID")] public CUInt32 PlayerStateMachineUpperBodyBBID { get; set; }
		[Ordinal(53)]  [RED("crosshairStateChanged")] public CUInt32 CrosshairStateChanged { get; set; }
		[Ordinal(54)]  [RED("crosshairState")] public CEnum<gamePSMCrosshairStates> CrosshairState { get; set; }
		[Ordinal(55)]  [RED("isTargetEnemy")] public CBool IsTargetEnemy { get; set; }
		[Ordinal(56)]  [RED("attitude")] public CEnum<EAIAttitude> Attitude { get; set; }

		public IronsightGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
