using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Tech_Round : BaseTechCrosshairController
	{
		[Ordinal(24)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(25)] [RED("leftPart")] public inkImageWidgetReference LeftPart { get; set; }
		[Ordinal(26)] [RED("rightPart")] public inkImageWidgetReference RightPart { get; set; }
		[Ordinal(27)] [RED("offsetLeftRight")] public CFloat OffsetLeftRight { get; set; }
		[Ordinal(28)] [RED("offsetLeftRightExtra")] public CFloat OffsetLeftRightExtra { get; set; }
		[Ordinal(29)] [RED("latchVertical")] public CFloat LatchVertical { get; set; }
		[Ordinal(30)] [RED("topPart")] public inkImageWidgetReference TopPart { get; set; }
		[Ordinal(31)] [RED("bottomPart")] public inkImageWidgetReference BottomPart { get; set; }
		[Ordinal(32)] [RED("horiPart")] public inkWidgetReference HoriPart { get; set; }
		[Ordinal(33)] [RED("vertPart")] public inkWidgetReference VertPart { get; set; }
		[Ordinal(34)] [RED("chargeBar")] public wCHandle<inkCanvasWidget> ChargeBar { get; set; }
		[Ordinal(35)] [RED("chargeBarFG")] public wCHandle<inkRectangleWidget> ChargeBarFG { get; set; }
		[Ordinal(36)] [RED("chargeBarBG")] public wCHandle<inkRectangleWidget> ChargeBarBG { get; set; }
		[Ordinal(37)] [RED("chargeBarMG")] public wCHandle<inkRectangleWidget> ChargeBarMG { get; set; }
		[Ordinal(38)] [RED("centerPart")] public wCHandle<inkWidget> CenterPart { get; set; }
		[Ordinal(39)] [RED("bottom_hip_bar")] public wCHandle<inkWidget> Bottom_hip_bar { get; set; }
		[Ordinal(40)] [RED("realFluffText_1")] public wCHandle<inkTextWidget> RealFluffText_1 { get; set; }
		[Ordinal(41)] [RED("realFluffText_2")] public wCHandle<inkTextWidget> RealFluffText_2 { get; set; }
		[Ordinal(42)] [RED("bufferedSpread")] public Vector2 BufferedSpread { get; set; }
		[Ordinal(43)] [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }
		[Ordinal(44)] [RED("bbcharge")] public CUInt32 Bbcharge { get; set; }
		[Ordinal(45)] [RED("bbmagazineAmmoCapacity")] public CUInt32 BbmagazineAmmoCapacity { get; set; }
		[Ordinal(46)] [RED("bbmagazineAmmoCount")] public CUInt32 BbmagazineAmmoCount { get; set; }
		[Ordinal(47)] [RED("bbcurrentFireMode")] public CUInt32 BbcurrentFireMode { get; set; }
		[Ordinal(48)] [RED("currentAmmo")] public CInt32 CurrentAmmo { get; set; }
		[Ordinal(49)] [RED("currentMaxAmmo")] public CInt32 CurrentMaxAmmo { get; set; }
		[Ordinal(50)] [RED("maxSupportedAmmo")] public CInt32 MaxSupportedAmmo { get; set; }
		[Ordinal(51)] [RED("currentFireMode")] public CEnum<gamedataTriggerMode> CurrentFireMode { get; set; }
		[Ordinal(52)] [RED("orgSideSize")] public Vector2 OrgSideSize { get; set; }
		[Ordinal(53)] [RED("sidesScale")] public CFloat SidesScale { get; set; }
		[Ordinal(54)] [RED("bbNPCStatsInfo")] public CUInt32 BbNPCStatsInfo { get; set; }
		[Ordinal(55)] [RED("currentObstructedTargetBBID")] public CUInt32 CurrentObstructedTargetBBID { get; set; }
		[Ordinal(56)] [RED("potentialVisibleTarget")] public wCHandle<gameObject> PotentialVisibleTarget { get; set; }
		[Ordinal(57)] [RED("potentialObstructedTarget")] public wCHandle<gameObject> PotentialObstructedTarget { get; set; }
		[Ordinal(58)] [RED("useVisibleTarget")] public CBool UseVisibleTarget { get; set; }
		[Ordinal(59)] [RED("horizontalMinSpread")] public CFloat HorizontalMinSpread { get; set; }
		[Ordinal(60)] [RED("verticalMinSpread")] public CFloat VerticalMinSpread { get; set; }
		[Ordinal(61)] [RED("gameplaySpreadMultiplier")] public CFloat GameplaySpreadMultiplier { get; set; }
		[Ordinal(62)] [RED("chargeAnimationProxy")] public CHandle<inkanimProxy> ChargeAnimationProxy { get; set; }
		[Ordinal(63)] [RED("spreadRA")] public CFloat SpreadRA { get; set; }

		public CrosshairGameController_Tech_Round(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
