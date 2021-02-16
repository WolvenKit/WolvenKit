using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Terminal : InteractiveMasterDevice
	{
		[Ordinal(93)] [RED("cameraFeed")] public CHandle<ScriptableVirtualCameraViewComponent> CameraFeed { get; set; }
		[Ordinal(94)] [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(95)] [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }

		public Terminal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
