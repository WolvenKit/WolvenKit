using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SurveillanceCamera : SensorDevice
	{
		[Ordinal(0)]  [RED("cameraHead")] public CHandle<entIComponent> CameraHead { get; set; }
		[Ordinal(1)]  [RED("cameraHeadPhysics")] public CHandle<entIComponent> CameraHeadPhysics { get; set; }
		[Ordinal(2)]  [RED("canDetectIntruders")] public CBool CanDetectIntruders { get; set; }
		[Ordinal(3)]  [RED("canStreamVideo")] public CBool CanStreamVideo { get; set; }
		[Ordinal(4)]  [RED("currentAngle")] public CFloat CurrentAngle { get; set; }
		[Ordinal(5)]  [RED("currentPitchModifier")] public CFloat CurrentPitchModifier { get; set; }
		[Ordinal(6)]  [RED("currentYawModifier")] public CFloat CurrentYawModifier { get; set; }
		[Ordinal(7)]  [RED("factOnFeedReceived")] public CName FactOnFeedReceived { get; set; }
		[Ordinal(8)]  [RED("lookAtEvent")] public CHandle<entLookAtAddEvent> LookAtEvent { get; set; }
		[Ordinal(9)]  [RED("meshDestrSupport")] public CBool MeshDestrSupport { get; set; }
		[Ordinal(10)]  [RED("questFactOnDetection")] public CName QuestFactOnDetection { get; set; }
		[Ordinal(11)]  [RED("rotateLeft")] public CBool RotateLeft { get; set; }
		[Ordinal(12)]  [RED("shouldRotate")] public CBool ShouldRotate { get; set; }
		[Ordinal(13)]  [RED("targetPosition")] public Vector4 TargetPosition { get; set; }
		[Ordinal(14)]  [RED("verticalDecal1")] public CHandle<entIComponent> VerticalDecal1 { get; set; }
		[Ordinal(15)]  [RED("verticalDecal2")] public CHandle<entIComponent> VerticalDecal2 { get; set; }
		[Ordinal(16)]  [RED("virtualCam")] public CHandle<entVirtualCameraComponent> VirtualCam { get; set; }

		public SurveillanceCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
