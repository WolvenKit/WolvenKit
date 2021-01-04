using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Tech_Hex : BaseTechCrosshairController
	{
		[Ordinal(0)]  [RED("ammoLeft")] public wCHandle<inkWidget> AmmoLeft { get; set; }
		[Ordinal(1)]  [RED("ammoLeftFill")] public wCHandle<inkWidget> AmmoLeftFill { get; set; }
		[Ordinal(2)]  [RED("ammoRight")] public wCHandle<inkWidget> AmmoRight { get; set; }
		[Ordinal(3)]  [RED("ammoRightFill")] public wCHandle<inkWidget> AmmoRightFill { get; set; }
		[Ordinal(4)]  [RED("bbNPCStatsInfo")] public CUInt32 BbNPCStatsInfo { get; set; }
		[Ordinal(5)]  [RED("bbcharge")] public CUInt32 Bbcharge { get; set; }
		[Ordinal(6)]  [RED("bbcurrentFireMode")] public CUInt32 BbcurrentFireMode { get; set; }
		[Ordinal(7)]  [RED("bbmagazineAmmoCount")] public CUInt32 BbmagazineAmmoCount { get; set; }
		[Ordinal(8)]  [RED("bufferedSpread")] public Vector2 BufferedSpread { get; set; }
		[Ordinal(9)]  [RED("centerPart")] public wCHandle<inkImageWidget> CenterPart { get; set; }
		[Ordinal(10)]  [RED("charge")] public CFloat Charge { get; set; }
		[Ordinal(11)]  [RED("chargeAnimationProxy")] public CHandle<inkanimProxy> ChargeAnimationProxy { get; set; }
		[Ordinal(12)]  [RED("chargeBar")] public wCHandle<inkWidget> ChargeBar { get; set; }
		[Ordinal(13)]  [RED("chargeBoth")] public wCHandle<inkWidget> ChargeBoth { get; set; }
		[Ordinal(14)]  [RED("chargeLeftBar")] public wCHandle<inkRectangleWidget> ChargeLeftBar { get; set; }
		[Ordinal(15)]  [RED("chargeRightBar")] public wCHandle<inkRectangleWidget> ChargeRightBar { get; set; }
		[Ordinal(16)]  [RED("currentAmmo")] public CInt32 CurrentAmmo { get; set; }
		[Ordinal(17)]  [RED("currentFireMode")] public CEnum<gamedataTriggerMode> CurrentFireMode { get; set; }
		[Ordinal(18)]  [RED("currentMaxAmmo")] public CInt32 CurrentMaxAmmo { get; set; }
		[Ordinal(19)]  [RED("fluffCanvas")] public wCHandle<inkWidget> FluffCanvas { get; set; }
		[Ordinal(20)]  [RED("gameplaySpreadMultiplier")] public CFloat GameplaySpreadMultiplier { get; set; }
		[Ordinal(21)]  [RED("hori")] public wCHandle<inkWidget> Hori { get; set; }
		[Ordinal(22)]  [RED("horizontalMinSpread")] public CFloat HorizontalMinSpread { get; set; }
		[Ordinal(23)]  [RED("leftBracket")] public wCHandle<inkImageWidget> LeftBracket { get; set; }
		[Ordinal(24)]  [RED("maxSupportedAmmo")] public CInt32 MaxSupportedAmmo { get; set; }
		[Ordinal(25)]  [RED("rightBracket")] public wCHandle<inkImageWidget> RightBracket { get; set; }
		[Ordinal(26)]  [RED("spread")] public CFloat Spread { get; set; }
		[Ordinal(27)]  [RED("verticalMinSpread")] public CFloat VerticalMinSpread { get; set; }
		[Ordinal(28)]  [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }

		public CrosshairGameController_Tech_Hex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
