using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netFrameInputs : CVariable
	{
		[Ordinal(0)] [RED("inputBuffer")] public CArray<netInputAction> InputBuffer { get; set; }
		[Ordinal(1)] [RED("timestamp")] public netTime Timestamp { get; set; }
		[Ordinal(2)] [RED("cameraRotationYaw")] public CFloat CameraRotationYaw { get; set; }
		[Ordinal(3)] [RED("cameraRotationPitch")] public CFloat CameraRotationPitch { get; set; }
		[Ordinal(4)] [RED("lookAtRotationYaw")] public CFloat LookAtRotationYaw { get; set; }
		[Ordinal(5)] [RED("lookAtRotationPitch")] public CFloat LookAtRotationPitch { get; set; }
		[Ordinal(6)] [RED("timeDelta")] public CFloat TimeDelta { get; set; }

		public netFrameInputs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
