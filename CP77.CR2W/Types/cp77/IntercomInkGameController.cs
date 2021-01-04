using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IntercomInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("actionsList")] public inkWidgetReference ActionsList { get; set; }
		[Ordinal(1)]  [RED("buttonRef")] public CHandle<CallActionWidgetController> ButtonRef { get; set; }
		[Ordinal(2)]  [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(3)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }
		[Ordinal(4)]  [RED("onUpdateStatusListener")] public CUInt32 OnUpdateStatusListener { get; set; }
		[Ordinal(5)]  [RED("state")] public CEnum<IntercomStatus> State { get; set; }

		public IntercomInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
