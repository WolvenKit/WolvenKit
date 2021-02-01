using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("counterWidget")] public wCHandle<inkTextWidget> CounterWidget { get; set; }
		[Ordinal(1)]  [RED("defaultUI")] public wCHandle<inkCanvasWidget> DefaultUI { get; set; }
		[Ordinal(2)]  [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(3)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }
		[Ordinal(4)]  [RED("onTimeToDepartChangedListener")] public CUInt32 OnTimeToDepartChangedListener { get; set; }

		public NcartTimetableInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
