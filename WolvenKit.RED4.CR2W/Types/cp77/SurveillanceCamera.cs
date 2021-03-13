using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SurveillanceCamera : SensorDevice
	{
		[Ordinal(187)] [RED("virtualCam")] public CHandle<entVirtualCameraComponent> VirtualCam { get; set; }
		[Ordinal(188)] [RED("cameraHead")] public CHandle<entIComponent> CameraHead { get; set; }
		[Ordinal(189)] [RED("cameraHeadPhysics")] public CHandle<entIComponent> CameraHeadPhysics { get; set; }
		[Ordinal(190)] [RED("verticalDecal1")] public CHandle<entIComponent> VerticalDecal1 { get; set; }
		[Ordinal(191)] [RED("verticalDecal2")] public CHandle<entIComponent> VerticalDecal2 { get; set; }
		[Ordinal(192)] [RED("meshDestrSupport")] public CBool MeshDestrSupport { get; set; }
		[Ordinal(193)] [RED("shouldRotate")] public CBool ShouldRotate { get; set; }
		[Ordinal(194)] [RED("canStreamVideo")] public CBool CanStreamVideo { get; set; }
		[Ordinal(195)] [RED("canDetectIntruders")] public CBool CanDetectIntruders { get; set; }
		[Ordinal(196)] [RED("currentAngle")] public CFloat CurrentAngle { get; set; }
		[Ordinal(197)] [RED("rotateLeft")] public CBool RotateLeft { get; set; }
		[Ordinal(198)] [RED("targetPosition")] public Vector4 TargetPosition { get; set; }
		[Ordinal(199)] [RED("factOnFeedReceived")] public CName FactOnFeedReceived { get; set; }
		[Ordinal(200)] [RED("questFactOnDetection")] public CName QuestFactOnDetection { get; set; }
		[Ordinal(201)] [RED("lookAtEvent")] public CHandle<entLookAtAddEvent> LookAtEvent { get; set; }
		[Ordinal(202)] [RED("currentYawModifier")] public CFloat CurrentYawModifier { get; set; }
		[Ordinal(203)] [RED("currentPitchModifier")] public CFloat CurrentPitchModifier { get; set; }

		public SurveillanceCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
