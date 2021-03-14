using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreviewCameraSetup : CVariable
	{
		[Ordinal(0)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(1)] [RED("cameraZoom")] public CFloat CameraZoom { get; set; }
		[Ordinal(2)] [RED("interpolationTime")] public CFloat InterpolationTime { get; set; }

		public gameuiPuppetPreviewCameraSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
