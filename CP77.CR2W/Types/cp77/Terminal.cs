using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Terminal : InteractiveMasterDevice
	{
		[Ordinal(84)]  [RED("cameraFeed")] public CHandle<ScriptableVirtualCameraViewComponent> CameraFeed { get; set; }
		[Ordinal(85)]  [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(86)]  [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }

		public Terminal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
