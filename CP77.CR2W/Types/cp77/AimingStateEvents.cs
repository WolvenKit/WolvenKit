using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AimingStateEvents : UpperBodyEventsTransition
	{
		[Ordinal(6)] [RED("aim")] public CHandle<gameweaponAnimFeature_AimPlayer> Aim { get; set; }
		[Ordinal(7)] [RED("mouseZoomLevel")] public CFloat MouseZoomLevel { get; set; }
		[Ordinal(8)] [RED("zoomLevelNum")] public CInt32 ZoomLevelNum { get; set; }
		[Ordinal(9)] [RED("numZoomLevels")] public CInt32 NumZoomLevels { get; set; }
		[Ordinal(10)] [RED("delayAimSnap")] public CInt32 DelayAimSnap { get; set; }
		[Ordinal(11)] [RED("isAiming")] public CBool IsAiming { get; set; }
		[Ordinal(12)] [RED("aimInTimeRemaining")] public CFloat AimInTimeRemaining { get; set; }
		[Ordinal(13)] [RED("aimBroadcast")] public CBool AimBroadcast { get; set; }
		[Ordinal(14)] [RED("zoomLevel")] public CFloat ZoomLevel { get; set; }
		[Ordinal(15)] [RED("finalZoomLevel")] public CFloat FinalZoomLevel { get; set; }
		[Ordinal(16)] [RED("previousZoomLevel")] public CFloat PreviousZoomLevel { get; set; }
		[Ordinal(17)] [RED("currentZoomLevel")] public CFloat CurrentZoomLevel { get; set; }
		[Ordinal(18)] [RED("timeToBlendZoom")] public CFloat TimeToBlendZoom { get; set; }
		[Ordinal(19)] [RED("time")] public CFloat Time { get; set; }
		[Ordinal(20)] [RED("speed")] public CFloat Speed { get; set; }

		public AimingStateEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
