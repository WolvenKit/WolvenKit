using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DataTermInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("districtText")] public wCHandle<inkTextWidget> DistrictText { get; set; }
		[Ordinal(1)]  [RED("fcPointsPanel")] public wCHandle<inkHorizontalPanelWidget> FcPointsPanel { get; set; }
		[Ordinal(2)]  [RED("onFastTravelPointUpdateListener")] public CUInt32 OnFastTravelPointUpdateListener { get; set; }
		[Ordinal(3)]  [RED("point")] public wCHandle<gameFastTravelPointData> Point { get; set; }
		[Ordinal(4)]  [RED("pointText")] public wCHandle<inkTextWidget> PointText { get; set; }

		public DataTermInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
