using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SurveillanceCamera : SensorDevice
	{
		private CHandle<entVirtualCameraComponent> _virtualCam;
		private CHandle<entIComponent> _cameraHead;
		private CHandle<entIComponent> _cameraHeadPhysics;
		private CHandle<entIComponent> _verticalDecal1;
		private CHandle<entIComponent> _verticalDecal2;
		private CBool _meshDestrSupport;
		private CBool _shouldRotate;
		private CBool _canStreamVideo;
		private CBool _canDetectIntruders;
		private CFloat _currentAngle;
		private CBool _rotateLeft;
		private Vector4 _targetPosition;
		private CName _factOnFeedReceived;
		private CName _questFactOnDetection;
		private CHandle<entLookAtAddEvent> _lookAtEvent;
		private CFloat _currentYawModifier;
		private CFloat _currentPitchModifier;

		[Ordinal(190)] 
		[RED("virtualCam")] 
		public CHandle<entVirtualCameraComponent> VirtualCam
		{
			get => GetProperty(ref _virtualCam);
			set => SetProperty(ref _virtualCam, value);
		}

		[Ordinal(191)] 
		[RED("cameraHead")] 
		public CHandle<entIComponent> CameraHead
		{
			get => GetProperty(ref _cameraHead);
			set => SetProperty(ref _cameraHead, value);
		}

		[Ordinal(192)] 
		[RED("cameraHeadPhysics")] 
		public CHandle<entIComponent> CameraHeadPhysics
		{
			get => GetProperty(ref _cameraHeadPhysics);
			set => SetProperty(ref _cameraHeadPhysics, value);
		}

		[Ordinal(193)] 
		[RED("verticalDecal1")] 
		public CHandle<entIComponent> VerticalDecal1
		{
			get => GetProperty(ref _verticalDecal1);
			set => SetProperty(ref _verticalDecal1, value);
		}

		[Ordinal(194)] 
		[RED("verticalDecal2")] 
		public CHandle<entIComponent> VerticalDecal2
		{
			get => GetProperty(ref _verticalDecal2);
			set => SetProperty(ref _verticalDecal2, value);
		}

		[Ordinal(195)] 
		[RED("meshDestrSupport")] 
		public CBool MeshDestrSupport
		{
			get => GetProperty(ref _meshDestrSupport);
			set => SetProperty(ref _meshDestrSupport, value);
		}

		[Ordinal(196)] 
		[RED("shouldRotate")] 
		public CBool ShouldRotate
		{
			get => GetProperty(ref _shouldRotate);
			set => SetProperty(ref _shouldRotate, value);
		}

		[Ordinal(197)] 
		[RED("canStreamVideo")] 
		public CBool CanStreamVideo
		{
			get => GetProperty(ref _canStreamVideo);
			set => SetProperty(ref _canStreamVideo, value);
		}

		[Ordinal(198)] 
		[RED("canDetectIntruders")] 
		public CBool CanDetectIntruders
		{
			get => GetProperty(ref _canDetectIntruders);
			set => SetProperty(ref _canDetectIntruders, value);
		}

		[Ordinal(199)] 
		[RED("currentAngle")] 
		public CFloat CurrentAngle
		{
			get => GetProperty(ref _currentAngle);
			set => SetProperty(ref _currentAngle, value);
		}

		[Ordinal(200)] 
		[RED("rotateLeft")] 
		public CBool RotateLeft
		{
			get => GetProperty(ref _rotateLeft);
			set => SetProperty(ref _rotateLeft, value);
		}

		[Ordinal(201)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(202)] 
		[RED("factOnFeedReceived")] 
		public CName FactOnFeedReceived
		{
			get => GetProperty(ref _factOnFeedReceived);
			set => SetProperty(ref _factOnFeedReceived, value);
		}

		[Ordinal(203)] 
		[RED("questFactOnDetection")] 
		public CName QuestFactOnDetection
		{
			get => GetProperty(ref _questFactOnDetection);
			set => SetProperty(ref _questFactOnDetection, value);
		}

		[Ordinal(204)] 
		[RED("lookAtEvent")] 
		public CHandle<entLookAtAddEvent> LookAtEvent
		{
			get => GetProperty(ref _lookAtEvent);
			set => SetProperty(ref _lookAtEvent, value);
		}

		[Ordinal(205)] 
		[RED("currentYawModifier")] 
		public CFloat CurrentYawModifier
		{
			get => GetProperty(ref _currentYawModifier);
			set => SetProperty(ref _currentYawModifier, value);
		}

		[Ordinal(206)] 
		[RED("currentPitchModifier")] 
		public CFloat CurrentPitchModifier
		{
			get => GetProperty(ref _currentPitchModifier);
			set => SetProperty(ref _currentPitchModifier, value);
		}

		public SurveillanceCamera(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
