using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IntercomInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("actionsList")] public inkWidgetReference ActionsList { get; set; }
		[Ordinal(17)] [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(18)] [RED("buttonRef")] public CHandle<CallActionWidgetController> ButtonRef { get; set; }
		[Ordinal(19)] [RED("state")] public CEnum<IntercomStatus> State { get; set; }
		[Ordinal(20)] [RED("onUpdateStatusListener")] public CUInt32 OnUpdateStatusListener { get; set; }
		[Ordinal(21)] [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }

		public IntercomInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
