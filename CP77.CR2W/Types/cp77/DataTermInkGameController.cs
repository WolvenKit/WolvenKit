using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DataTermInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("fcPointsPanel")] public wCHandle<inkHorizontalPanelWidget> FcPointsPanel { get; set; }
		[Ordinal(17)] [RED("districtText")] public wCHandle<inkTextWidget> DistrictText { get; set; }
		[Ordinal(18)] [RED("pointText")] public wCHandle<inkTextWidget> PointText { get; set; }
		[Ordinal(19)] [RED("point")] public wCHandle<gameFastTravelPointData> Point { get; set; }
		[Ordinal(20)] [RED("onFastTravelPointUpdateListener")] public CUInt32 OnFastTravelPointUpdateListener { get; set; }

		public DataTermInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
