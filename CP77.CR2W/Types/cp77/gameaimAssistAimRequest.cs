using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaimAssistAimRequest : CVariable
	{
		[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)] [RED("adjustPitch")] public CBool AdjustPitch { get; set; }
		[Ordinal(2)] [RED("adjustYaw")] public CBool AdjustYaw { get; set; }
		[Ordinal(3)] [RED("endOnTargetReached")] public CBool EndOnTargetReached { get; set; }
		[Ordinal(4)] [RED("endOnCameraInputApplied")] public CBool EndOnCameraInputApplied { get; set; }
		[Ordinal(5)] [RED("endOnTimeExceeded")] public CBool EndOnTimeExceeded { get; set; }
		[Ordinal(6)] [RED("endOnAimingStopped")] public CBool EndOnAimingStopped { get; set; }
		[Ordinal(7)] [RED("cameraInputMagToBreak")] public CFloat CameraInputMagToBreak { get; set; }
		[Ordinal(8)] [RED("precision")] public CFloat Precision { get; set; }
		[Ordinal(9)] [RED("maxDuration")] public CFloat MaxDuration { get; set; }
		[Ordinal(10)] [RED("easeIn")] public CBool EaseIn { get; set; }
		[Ordinal(11)] [RED("easeOut")] public CBool EaseOut { get; set; }
		[Ordinal(12)] [RED("checkRange")] public CBool CheckRange { get; set; }
		[Ordinal(13)] [RED("lookAtTarget")] public Vector4 LookAtTarget { get; set; }
		[Ordinal(14)] [RED("processAsInput")] public CBool ProcessAsInput { get; set; }
		[Ordinal(15)] [RED("bodyPartsTracking")] public CBool BodyPartsTracking { get; set; }
		[Ordinal(16)] [RED("bptMaxDot")] public CFloat BptMaxDot { get; set; }
		[Ordinal(17)] [RED("bptMaxSwitches")] public CFloat BptMaxSwitches { get; set; }
		[Ordinal(18)] [RED("bptMinInputMag")] public CFloat BptMinInputMag { get; set; }
		[Ordinal(19)] [RED("bptMinResetInputMag")] public CFloat BptMinResetInputMag { get; set; }

		public gameaimAssistAimRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
