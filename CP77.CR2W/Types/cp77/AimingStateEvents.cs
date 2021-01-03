using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AimingStateEvents : UpperBodyEventsTransition
	{
		[Ordinal(0)]  [RED("aim")] public CHandle<gameweaponAnimFeature_AimPlayer> Aim { get; set; }
		[Ordinal(1)]  [RED("aimBroadcast")] public CBool AimBroadcast { get; set; }
		[Ordinal(2)]  [RED("aimInTimeRemaining")] public CFloat AimInTimeRemaining { get; set; }
		[Ordinal(3)]  [RED("currentZoomLevel")] public CFloat CurrentZoomLevel { get; set; }
		[Ordinal(4)]  [RED("delayAimSnap")] public CInt32 DelayAimSnap { get; set; }
		[Ordinal(5)]  [RED("finalZoomLevel")] public CFloat FinalZoomLevel { get; set; }
		[Ordinal(6)]  [RED("isAiming")] public CBool IsAiming { get; set; }
		[Ordinal(7)]  [RED("mouseZoomLevel")] public CFloat MouseZoomLevel { get; set; }
		[Ordinal(8)]  [RED("numZoomLevels")] public CInt32 NumZoomLevels { get; set; }
		[Ordinal(9)]  [RED("previousZoomLevel")] public CFloat PreviousZoomLevel { get; set; }
		[Ordinal(10)]  [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(11)]  [RED("time")] public CFloat Time { get; set; }
		[Ordinal(12)]  [RED("timeToBlendZoom")] public CFloat TimeToBlendZoom { get; set; }
		[Ordinal(13)]  [RED("zoomLevel")] public CFloat ZoomLevel { get; set; }
		[Ordinal(14)]  [RED("zoomLevelNum")] public CInt32 ZoomLevelNum { get; set; }

		public AimingStateEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
