using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SurveillanceCamera : SensorDevice
	{
		[Ordinal(178)]  [RED("virtualCam")] public CHandle<entVirtualCameraComponent> VirtualCam { get; set; }
		[Ordinal(179)]  [RED("cameraHead")] public CHandle<entIComponent> CameraHead { get; set; }
		[Ordinal(180)]  [RED("cameraHeadPhysics")] public CHandle<entIComponent> CameraHeadPhysics { get; set; }
		[Ordinal(181)]  [RED("verticalDecal1")] public CHandle<entIComponent> VerticalDecal1 { get; set; }
		[Ordinal(182)]  [RED("verticalDecal2")] public CHandle<entIComponent> VerticalDecal2 { get; set; }
		[Ordinal(183)]  [RED("meshDestrSupport")] public CBool MeshDestrSupport { get; set; }
		[Ordinal(184)]  [RED("shouldRotate")] public CBool ShouldRotate { get; set; }
		[Ordinal(185)]  [RED("canStreamVideo")] public CBool CanStreamVideo { get; set; }
		[Ordinal(186)]  [RED("canDetectIntruders")] public CBool CanDetectIntruders { get; set; }
		[Ordinal(187)]  [RED("currentAngle")] public CFloat CurrentAngle { get; set; }
		[Ordinal(188)]  [RED("rotateLeft")] public CBool RotateLeft { get; set; }
		[Ordinal(189)]  [RED("targetPosition")] public Vector4 TargetPosition { get; set; }
		[Ordinal(190)]  [RED("factOnFeedReceived")] public CName FactOnFeedReceived { get; set; }
		[Ordinal(191)]  [RED("questFactOnDetection")] public CName QuestFactOnDetection { get; set; }
		[Ordinal(192)]  [RED("lookAtEvent")] public CHandle<entLookAtAddEvent> LookAtEvent { get; set; }
		[Ordinal(193)]  [RED("currentYawModifier")] public CFloat CurrentYawModifier { get; set; }
		[Ordinal(194)]  [RED("currentPitchModifier")] public CFloat CurrentPitchModifier { get; set; }

		public SurveillanceCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
