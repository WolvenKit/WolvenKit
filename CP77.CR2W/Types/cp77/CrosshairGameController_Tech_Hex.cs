using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Tech_Hex : BaseTechCrosshairController
	{
		[Ordinal(24)] [RED("leftBracket")] public wCHandle<inkImageWidget> LeftBracket { get; set; }
		[Ordinal(25)] [RED("rightBracket")] public wCHandle<inkImageWidget> RightBracket { get; set; }
		[Ordinal(26)] [RED("hori")] public wCHandle<inkWidget> Hori { get; set; }
		[Ordinal(27)] [RED("chargeBar")] public wCHandle<inkWidget> ChargeBar { get; set; }
		[Ordinal(28)] [RED("ammoLeft")] public wCHandle<inkWidget> AmmoLeft { get; set; }
		[Ordinal(29)] [RED("ammoRight")] public wCHandle<inkWidget> AmmoRight { get; set; }
		[Ordinal(30)] [RED("ammoLeftFill")] public wCHandle<inkWidget> AmmoLeftFill { get; set; }
		[Ordinal(31)] [RED("ammoRightFill")] public wCHandle<inkWidget> AmmoRightFill { get; set; }
		[Ordinal(32)] [RED("chargeBoth")] public wCHandle<inkWidget> ChargeBoth { get; set; }
		[Ordinal(33)] [RED("chargeLeftBar")] public wCHandle<inkRectangleWidget> ChargeLeftBar { get; set; }
		[Ordinal(34)] [RED("chargeRightBar")] public wCHandle<inkRectangleWidget> ChargeRightBar { get; set; }
		[Ordinal(35)] [RED("centerPart")] public wCHandle<inkImageWidget> CenterPart { get; set; }
		[Ordinal(36)] [RED("fluffCanvas")] public wCHandle<inkWidget> FluffCanvas { get; set; }
		[Ordinal(37)] [RED("chargeAnimationProxy")] public CHandle<inkanimProxy> ChargeAnimationProxy { get; set; }
		[Ordinal(38)] [RED("bufferedSpread")] public Vector2 BufferedSpread { get; set; }
		[Ordinal(39)] [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }
		[Ordinal(40)] [RED("bbcharge")] public CUInt32 Bbcharge { get; set; }
		[Ordinal(41)] [RED("bbmagazineAmmoCount")] public CUInt32 BbmagazineAmmoCount { get; set; }
		[Ordinal(42)] [RED("bbcurrentFireMode")] public CUInt32 BbcurrentFireMode { get; set; }
		[Ordinal(43)] [RED("currentAmmo")] public CInt32 CurrentAmmo { get; set; }
		[Ordinal(44)] [RED("currentMaxAmmo")] public CInt32 CurrentMaxAmmo { get; set; }
		[Ordinal(45)] [RED("maxSupportedAmmo")] public CInt32 MaxSupportedAmmo { get; set; }
		[Ordinal(46)] [RED("currentFireMode")] public CEnum<gamedataTriggerMode> CurrentFireMode { get; set; }
		[Ordinal(47)] [RED("bbNPCStatsInfo")] public CUInt32 BbNPCStatsInfo { get; set; }
		[Ordinal(48)] [RED("horizontalMinSpread")] public CFloat HorizontalMinSpread { get; set; }
		[Ordinal(49)] [RED("verticalMinSpread")] public CFloat VerticalMinSpread { get; set; }
		[Ordinal(50)] [RED("gameplaySpreadMultiplier")] public CFloat GameplaySpreadMultiplier { get; set; }
		[Ordinal(51)] [RED("charge")] public CFloat Charge { get; set; }
		[Ordinal(52)] [RED("spread")] public CFloat Spread { get; set; }

		public CrosshairGameController_Tech_Hex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
