using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SurveillanceCamera : SensorDevice
	{
		[Ordinal(197)] 
		[RED("virtualCam")] 
		public CHandle<entVirtualCameraComponent> VirtualCam
		{
			get => GetPropertyValue<CHandle<entVirtualCameraComponent>>();
			set => SetPropertyValue<CHandle<entVirtualCameraComponent>>(value);
		}

		[Ordinal(198)] 
		[RED("cameraHead")] 
		public CHandle<entIComponent> CameraHead
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(199)] 
		[RED("cameraHeadPhysics")] 
		public CHandle<entIComponent> CameraHeadPhysics
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(200)] 
		[RED("verticalDecal1")] 
		public CHandle<entIComponent> VerticalDecal1
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(201)] 
		[RED("verticalDecal2")] 
		public CHandle<entIComponent> VerticalDecal2
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(202)] 
		[RED("meshDestrSupport")] 
		public CBool MeshDestrSupport
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(203)] 
		[RED("shouldRotate")] 
		public CBool ShouldRotate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(204)] 
		[RED("canStreamVideo")] 
		public CBool CanStreamVideo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(205)] 
		[RED("canDetectIntruders")] 
		public CBool CanDetectIntruders
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(206)] 
		[RED("currentAngle")] 
		public CFloat CurrentAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(207)] 
		[RED("rotateLeft")] 
		public CBool RotateLeft
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(208)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(209)] 
		[RED("factOnFeedReceived")] 
		public CName FactOnFeedReceived
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(210)] 
		[RED("questFactOnDetection")] 
		public CName QuestFactOnDetection
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(211)] 
		[RED("lookAtEvent")] 
		public CHandle<entLookAtAddEvent> LookAtEvent
		{
			get => GetPropertyValue<CHandle<entLookAtAddEvent>>();
			set => SetPropertyValue<CHandle<entLookAtAddEvent>>(value);
		}

		[Ordinal(212)] 
		[RED("currentYawModifier")] 
		public CFloat CurrentYawModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(213)] 
		[RED("currentPitchModifier")] 
		public CFloat CurrentPitchModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SurveillanceCamera()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
