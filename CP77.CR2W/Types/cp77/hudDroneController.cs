using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class hudDroneController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("CameraID")] public inkTextWidgetReference CameraID { get; set; }
		[Ordinal(1)]  [RED("Date")] public inkTextWidgetReference Date { get; set; }
		[Ordinal(2)]  [RED("PSM_BBID")] public CUInt32 PSM_BBID { get; set; }
		[Ordinal(3)]  [RED("Timer")] public inkTextWidgetReference Timer { get; set; }
		[Ordinal(4)]  [RED("currentTime")] public GameTime CurrentTime { get; set; }
		[Ordinal(5)]  [RED("currentZoom")] public CFloat CurrentZoom { get; set; }
		[Ordinal(6)]  [RED("psmBlackboard")] public CHandle<gameIBlackboard> PsmBlackboard { get; set; }
		[Ordinal(7)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(8)]  [RED("scanBlackboard")] public CHandle<gameIBlackboard> ScanBlackboard { get; set; }

		public hudDroneController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
