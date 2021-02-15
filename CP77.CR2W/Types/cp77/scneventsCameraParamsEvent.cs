using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraParamsEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("cameraRef")] public NodeRef CameraRef { get; set; }
		[Ordinal(7)] [RED("fovValue")] public CFloat FovValue { get; set; }
		[Ordinal(8)] [RED("fovWeigh")] public CFloat FovWeigh { get; set; }
		[Ordinal(9)] [RED("dofIntensity")] public CFloat DofIntensity { get; set; }
		[Ordinal(10)] [RED("dofNearBlur")] public CFloat DofNearBlur { get; set; }
		[Ordinal(11)] [RED("dofNearFocus")] public CFloat DofNearFocus { get; set; }
		[Ordinal(12)] [RED("dofFarBlur")] public CFloat DofFarBlur { get; set; }
		[Ordinal(13)] [RED("dofFarFocus")] public CFloat DofFarFocus { get; set; }
		[Ordinal(14)] [RED("useNearPlane")] public CBool UseNearPlane { get; set; }
		[Ordinal(15)] [RED("useFarPlane")] public CBool UseFarPlane { get; set; }
		[Ordinal(16)] [RED("isPlayerCamera")] public CBool IsPlayerCamera { get; set; }
		[Ordinal(17)] [RED("cameraOverrideSettings")] public scneventsCameraOverrideSettings CameraOverrideSettings { get; set; }
		[Ordinal(18)] [RED("targetActor")] public scnPerformerId TargetActor { get; set; }
		[Ordinal(19)] [RED("targetSlot")] public CName TargetSlot { get; set; }

		public scneventsCameraParamsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
