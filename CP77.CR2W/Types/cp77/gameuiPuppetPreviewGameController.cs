using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreviewGameController : gameuiPreviewGameController
	{
		[Ordinal(6)] [RED("cameraController")] public gameuiPuppetPreviewCameraController CameraController { get; set; }

		public gameuiPuppetPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
