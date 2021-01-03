using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreviewCameraController : CVariable
	{
		[Ordinal(0)]  [RED("activeSetup")] public CUInt32 ActiveSetup { get; set; }
		[Ordinal(1)]  [RED("cameraSetup")] public CArray<gameuiPuppetPreviewCameraSetup> CameraSetup { get; set; }
		[Ordinal(2)]  [RED("transitionDelay")] public CFloat TransitionDelay { get; set; }

		public gameuiPuppetPreviewCameraController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
