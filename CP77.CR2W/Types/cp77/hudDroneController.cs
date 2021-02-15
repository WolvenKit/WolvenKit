using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudDroneController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("Date")] public inkTextWidgetReference Date { get; set; }
		[Ordinal(10)] [RED("Timer")] public inkTextWidgetReference Timer { get; set; }
		[Ordinal(11)] [RED("CameraID")] public inkTextWidgetReference CameraID { get; set; }
		[Ordinal(12)] [RED("scanBlackboard")] public CHandle<gameIBlackboard> ScanBlackboard { get; set; }
		[Ordinal(13)] [RED("psmBlackboard")] public CHandle<gameIBlackboard> PsmBlackboard { get; set; }
		[Ordinal(14)] [RED("PSM_BBID")] public CUInt32 PSM_BBID { get; set; }
		[Ordinal(15)] [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(16)] [RED("currentZoom")] public CFloat CurrentZoom { get; set; }
		[Ordinal(17)] [RED("currentTime")] public GameTime CurrentTime { get; set; }

		public hudDroneController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
