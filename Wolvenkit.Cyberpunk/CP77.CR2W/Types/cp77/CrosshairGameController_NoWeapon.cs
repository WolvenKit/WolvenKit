using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_NoWeapon : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("AimDownSightContainer")] public inkCompoundWidgetReference AimDownSightContainer { get; set; }
		[Ordinal(1)]  [RED("DistanceImageRuler")] public inkImageWidgetReference DistanceImageRuler { get; set; }
		[Ordinal(2)]  [RED("PlayerSMBB")] public CHandle<gameIBlackboard> PlayerSMBB { get; set; }
		[Ordinal(3)]  [RED("ZoomLevelBBID")] public CUInt32 ZoomLevelBBID { get; set; }
		[Ordinal(4)]  [RED("ZoomLevelString")] public CString ZoomLevelString { get; set; }
		[Ordinal(5)]  [RED("ZoomMoveBracketL")] public inkImageWidgetReference ZoomMoveBracketL { get; set; }
		[Ordinal(6)]  [RED("ZoomMoveBracketR")] public inkImageWidgetReference ZoomMoveBracketR { get; set; }
		[Ordinal(7)]  [RED("ZoomMovingContainer")] public inkCompoundWidgetReference ZoomMovingContainer { get; set; }
		[Ordinal(8)]  [RED("ZoomNumber")] public inkTextWidgetReference ZoomNumber { get; set; }
		[Ordinal(9)]  [RED("ZoomNumberR")] public inkTextWidgetReference ZoomNumberR { get; set; }
		[Ordinal(10)]  [RED("animLockOff")] public CHandle<inkanimProxy> AnimLockOff { get; set; }
		[Ordinal(11)]  [RED("animLockOn")] public CHandle<inkanimProxy> AnimLockOn { get; set; }
		[Ordinal(12)]  [RED("argZoomBuffered")] public CFloat ArgZoomBuffered { get; set; }
		[Ordinal(13)]  [RED("sceneTier")] public CEnum<gamePSMHighLevel> SceneTier { get; set; }
		[Ordinal(14)]  [RED("sceneTierBlackboardId")] public CUInt32 SceneTierBlackboardId { get; set; }
		[Ordinal(15)]  [RED("zoomDownAnim")] public CHandle<inkanimProxy> ZoomDownAnim { get; set; }
		[Ordinal(16)]  [RED("zoomHideAnim")] public CHandle<inkanimProxy> ZoomHideAnim { get; set; }
		[Ordinal(17)]  [RED("zoomShowAnim")] public CHandle<inkanimProxy> ZoomShowAnim { get; set; }
		[Ordinal(18)]  [RED("zoomUpAnim")] public CHandle<inkanimProxy> ZoomUpAnim { get; set; }

		public CrosshairGameController_NoWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
