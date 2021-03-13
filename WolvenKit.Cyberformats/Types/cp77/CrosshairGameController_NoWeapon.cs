using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_NoWeapon : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("AimDownSightContainer")] public inkCompoundWidgetReference AimDownSightContainer { get; set; }
		[Ordinal(19)] [RED("ZoomMovingContainer")] public inkCompoundWidgetReference ZoomMovingContainer { get; set; }
		[Ordinal(20)] [RED("ZoomNumber")] public inkTextWidgetReference ZoomNumber { get; set; }
		[Ordinal(21)] [RED("ZoomNumberR")] public inkTextWidgetReference ZoomNumberR { get; set; }
		[Ordinal(22)] [RED("DistanceImageRuler")] public inkImageWidgetReference DistanceImageRuler { get; set; }
		[Ordinal(23)] [RED("ZoomMoveBracketL")] public inkImageWidgetReference ZoomMoveBracketL { get; set; }
		[Ordinal(24)] [RED("ZoomMoveBracketR")] public inkImageWidgetReference ZoomMoveBracketR { get; set; }
		[Ordinal(25)] [RED("ZoomLevelString")] public CString ZoomLevelString { get; set; }
		[Ordinal(26)] [RED("PlayerSMBB")] public CHandle<gameIBlackboard> PlayerSMBB { get; set; }
		[Ordinal(27)] [RED("ZoomLevelBBID")] public CUInt32 ZoomLevelBBID { get; set; }
		[Ordinal(28)] [RED("sceneTierBlackboardId")] public CUInt32 SceneTierBlackboardId { get; set; }
		[Ordinal(29)] [RED("sceneTier")] public CEnum<gamePSMHighLevel> SceneTier { get; set; }
		[Ordinal(30)] [RED("zoomUpAnim")] public CHandle<inkanimProxy> ZoomUpAnim { get; set; }
		[Ordinal(31)] [RED("animLockOn")] public CHandle<inkanimProxy> AnimLockOn { get; set; }
		[Ordinal(32)] [RED("zoomDownAnim")] public CHandle<inkanimProxy> ZoomDownAnim { get; set; }
		[Ordinal(33)] [RED("animLockOff")] public CHandle<inkanimProxy> AnimLockOff { get; set; }
		[Ordinal(34)] [RED("zoomShowAnim")] public CHandle<inkanimProxy> ZoomShowAnim { get; set; }
		[Ordinal(35)] [RED("zoomHideAnim")] public CHandle<inkanimProxy> ZoomHideAnim { get; set; }
		[Ordinal(36)] [RED("argZoomBuffered")] public CFloat ArgZoomBuffered { get; set; }

		public CrosshairGameController_NoWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
