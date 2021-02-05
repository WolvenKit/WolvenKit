using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Tech_Hex : BaseTechCrosshairController
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
		[Ordinal(16)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(17)]  [RED("statsSystem")] public CHandle<gameStatsSystem> StatsSystem { get; set; }
		[Ordinal(18)]  [RED("fullChargeAvailable")] public CBool FullChargeAvailable { get; set; }
		[Ordinal(19)]  [RED("overChargeAvailable")] public CBool OverChargeAvailable { get; set; }
		[Ordinal(20)]  [RED("fullChargeListener")] public CHandle<CrosshairWeaponStatsListener> FullChargeListener { get; set; }
		[Ordinal(21)]  [RED("overChargeListener")] public CHandle<CrosshairWeaponStatsListener> OverChargeListener { get; set; }
		[Ordinal(22)]  [RED("leftBracket")] public wCHandle<inkImageWidget> LeftBracket { get; set; }
		[Ordinal(23)]  [RED("rightBracket")] public wCHandle<inkImageWidget> RightBracket { get; set; }
		[Ordinal(24)]  [RED("hori")] public wCHandle<inkWidget> Hori { get; set; }
		[Ordinal(25)]  [RED("chargeBar")] public wCHandle<inkWidget> ChargeBar { get; set; }
		[Ordinal(26)]  [RED("ammoLeft")] public wCHandle<inkWidget> AmmoLeft { get; set; }
		[Ordinal(27)]  [RED("ammoRight")] public wCHandle<inkWidget> AmmoRight { get; set; }
		[Ordinal(28)]  [RED("ammoLeftFill")] public wCHandle<inkWidget> AmmoLeftFill { get; set; }
		[Ordinal(29)]  [RED("ammoRightFill")] public wCHandle<inkWidget> AmmoRightFill { get; set; }
		[Ordinal(30)]  [RED("chargeBoth")] public wCHandle<inkWidget> ChargeBoth { get; set; }
		[Ordinal(31)]  [RED("chargeLeftBar")] public wCHandle<inkRectangleWidget> ChargeLeftBar { get; set; }
		[Ordinal(32)]  [RED("chargeRightBar")] public wCHandle<inkRectangleWidget> ChargeRightBar { get; set; }
		[Ordinal(33)]  [RED("centerPart")] public wCHandle<inkImageWidget> CenterPart { get; set; }
		[Ordinal(34)]  [RED("fluffCanvas")] public wCHandle<inkWidget> FluffCanvas { get; set; }
		[Ordinal(35)]  [RED("chargeAnimationProxy")] public CHandle<inkanimProxy> ChargeAnimationProxy { get; set; }
		[Ordinal(36)]  [RED("bufferedSpread")] public Vector2 BufferedSpread { get; set; }
		[Ordinal(37)]  [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }
		[Ordinal(38)]  [RED("bbcharge")] public CUInt32 Bbcharge { get; set; }
		[Ordinal(39)]  [RED("bbmagazineAmmoCount")] public CUInt32 BbmagazineAmmoCount { get; set; }
		[Ordinal(40)]  [RED("bbcurrentFireMode")] public CUInt32 BbcurrentFireMode { get; set; }
		[Ordinal(41)]  [RED("currentAmmo")] public CInt32 CurrentAmmo { get; set; }
		[Ordinal(42)]  [RED("currentMaxAmmo")] public CInt32 CurrentMaxAmmo { get; set; }
		[Ordinal(43)]  [RED("maxSupportedAmmo")] public CInt32 MaxSupportedAmmo { get; set; }
		[Ordinal(44)]  [RED("currentFireMode")] public CEnum<gamedataTriggerMode> CurrentFireMode { get; set; }
		[Ordinal(45)]  [RED("bbNPCStatsInfo")] public CUInt32 BbNPCStatsInfo { get; set; }
		[Ordinal(46)]  [RED("horizontalMinSpread")] public CFloat HorizontalMinSpread { get; set; }
		[Ordinal(47)]  [RED("verticalMinSpread")] public CFloat VerticalMinSpread { get; set; }
		[Ordinal(48)]  [RED("gameplaySpreadMultiplier")] public CFloat GameplaySpreadMultiplier { get; set; }
		[Ordinal(49)]  [RED("charge")] public CFloat Charge { get; set; }
		[Ordinal(50)]  [RED("spread")] public CFloat Spread { get; set; }

		public CrosshairGameController_Tech_Hex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
