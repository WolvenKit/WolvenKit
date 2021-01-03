using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Tech_Round : BaseTechCrosshairController
	{
		[Ordinal(0)]  [RED("bbNPCStatsInfo")] public CUInt32 BbNPCStatsInfo { get; set; }
		[Ordinal(1)]  [RED("bbcharge")] public CUInt32 Bbcharge { get; set; }
		[Ordinal(2)]  [RED("bbcurrentFireMode")] public CUInt32 BbcurrentFireMode { get; set; }
		[Ordinal(3)]  [RED("bbmagazineAmmoCapacity")] public CUInt32 BbmagazineAmmoCapacity { get; set; }
		[Ordinal(4)]  [RED("bbmagazineAmmoCount")] public CUInt32 BbmagazineAmmoCount { get; set; }
		[Ordinal(5)]  [RED("bottomPart")] public inkImageWidgetReference BottomPart { get; set; }
		[Ordinal(6)]  [RED("bottom_hip_bar")] public wCHandle<inkWidget> Bottom_hip_bar { get; set; }
		[Ordinal(7)]  [RED("bufferedSpread")] public Vector2 BufferedSpread { get; set; }
		[Ordinal(8)]  [RED("centerPart")] public wCHandle<inkWidget> CenterPart { get; set; }
		[Ordinal(9)]  [RED("chargeAnimationProxy")] public CHandle<inkanimProxy> ChargeAnimationProxy { get; set; }
		[Ordinal(10)]  [RED("chargeBar")] public wCHandle<inkCanvasWidget> ChargeBar { get; set; }
		[Ordinal(11)]  [RED("chargeBarBG")] public wCHandle<inkRectangleWidget> ChargeBarBG { get; set; }
		[Ordinal(12)]  [RED("chargeBarFG")] public wCHandle<inkRectangleWidget> ChargeBarFG { get; set; }
		[Ordinal(13)]  [RED("chargeBarMG")] public wCHandle<inkRectangleWidget> ChargeBarMG { get; set; }
		[Ordinal(14)]  [RED("currentAmmo")] public CInt32 CurrentAmmo { get; set; }
		[Ordinal(15)]  [RED("currentFireMode")] public CEnum<gamedataTriggerMode> CurrentFireMode { get; set; }
		[Ordinal(16)]  [RED("currentMaxAmmo")] public CInt32 CurrentMaxAmmo { get; set; }
		[Ordinal(17)]  [RED("currentObstructedTargetBBID")] public CUInt32 CurrentObstructedTargetBBID { get; set; }
		[Ordinal(18)]  [RED("gameplaySpreadMultiplier")] public CFloat GameplaySpreadMultiplier { get; set; }
		[Ordinal(19)]  [RED("horiPart")] public inkWidgetReference HoriPart { get; set; }
		[Ordinal(20)]  [RED("horizontalMinSpread")] public CFloat HorizontalMinSpread { get; set; }
		[Ordinal(21)]  [RED("latchVertical")] public CFloat LatchVertical { get; set; }
		[Ordinal(22)]  [RED("leftPart")] public inkImageWidgetReference LeftPart { get; set; }
		[Ordinal(23)]  [RED("maxSupportedAmmo")] public CInt32 MaxSupportedAmmo { get; set; }
		[Ordinal(24)]  [RED("offsetLeftRight")] public CFloat OffsetLeftRight { get; set; }
		[Ordinal(25)]  [RED("offsetLeftRightExtra")] public CFloat OffsetLeftRightExtra { get; set; }
		[Ordinal(26)]  [RED("orgSideSize")] public Vector2 OrgSideSize { get; set; }
		[Ordinal(27)]  [RED("potentialObstructedTarget")] public wCHandle<gameObject> PotentialObstructedTarget { get; set; }
		[Ordinal(28)]  [RED("potentialVisibleTarget")] public wCHandle<gameObject> PotentialVisibleTarget { get; set; }
		[Ordinal(29)]  [RED("realFluffText_1")] public wCHandle<inkTextWidget> RealFluffText_1 { get; set; }
		[Ordinal(30)]  [RED("realFluffText_2")] public wCHandle<inkTextWidget> RealFluffText_2 { get; set; }
		[Ordinal(31)]  [RED("rightPart")] public inkImageWidgetReference RightPart { get; set; }
		[Ordinal(32)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(33)]  [RED("sidesScale")] public CFloat SidesScale { get; set; }
		[Ordinal(34)]  [RED("spreadRA")] public CFloat SpreadRA { get; set; }
		[Ordinal(35)]  [RED("topPart")] public inkImageWidgetReference TopPart { get; set; }
		[Ordinal(36)]  [RED("useVisibleTarget")] public CBool UseVisibleTarget { get; set; }
		[Ordinal(37)]  [RED("vertPart")] public inkWidgetReference VertPart { get; set; }
		[Ordinal(38)]  [RED("verticalMinSpread")] public CFloat VerticalMinSpread { get; set; }
		[Ordinal(39)]  [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }

		public CrosshairGameController_Tech_Round(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
