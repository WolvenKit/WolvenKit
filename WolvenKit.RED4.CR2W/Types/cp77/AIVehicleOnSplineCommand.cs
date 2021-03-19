using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIVehicleOnSplineCommand : AIVehicleCommand
	{
		private NodeRef _splineRef;
		private CFloat _secureTimeOut;
		private CBool _driveBackwards;
		private CBool _reverseSpline;
		private CBool _startFromClosest;
		private CFloat _forcedStartSpeed;
		private CBool _stopAtPathEnd;
		private CBool _keepDistanceBool;
		private wCHandle<gameObject> _keepDistanceCompanion;
		private CFloat _keepDistanceDistance;
		private CBool _rubberBandingBool;
		private wCHandle<gameObject> _rubberBandingTargetRef;
		private CFloat _rubberBandingMinDistance;
		private CFloat _rubberBandingMaxDistance;
		private CBool _rubberBandingStopAndWait;
		private CBool _rubberBandingTeleportToCatchUp;
		private CBool _rubberBandingStayInFront;

		[Ordinal(6)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetProperty(ref _splineRef);
			set => SetProperty(ref _splineRef, value);
		}

		[Ordinal(7)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get => GetProperty(ref _secureTimeOut);
			set => SetProperty(ref _secureTimeOut, value);
		}

		[Ordinal(8)] 
		[RED("driveBackwards")] 
		public CBool DriveBackwards
		{
			get => GetProperty(ref _driveBackwards);
			set => SetProperty(ref _driveBackwards, value);
		}

		[Ordinal(9)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get => GetProperty(ref _reverseSpline);
			set => SetProperty(ref _reverseSpline, value);
		}

		[Ordinal(10)] 
		[RED("startFromClosest")] 
		public CBool StartFromClosest
		{
			get => GetProperty(ref _startFromClosest);
			set => SetProperty(ref _startFromClosest, value);
		}

		[Ordinal(11)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get => GetProperty(ref _forcedStartSpeed);
			set => SetProperty(ref _forcedStartSpeed, value);
		}

		[Ordinal(12)] 
		[RED("stopAtPathEnd")] 
		public CBool StopAtPathEnd
		{
			get => GetProperty(ref _stopAtPathEnd);
			set => SetProperty(ref _stopAtPathEnd, value);
		}

		[Ordinal(13)] 
		[RED("keepDistanceBool")] 
		public CBool KeepDistanceBool
		{
			get => GetProperty(ref _keepDistanceBool);
			set => SetProperty(ref _keepDistanceBool, value);
		}

		[Ordinal(14)] 
		[RED("keepDistanceCompanion")] 
		public wCHandle<gameObject> KeepDistanceCompanion
		{
			get => GetProperty(ref _keepDistanceCompanion);
			set => SetProperty(ref _keepDistanceCompanion, value);
		}

		[Ordinal(15)] 
		[RED("keepDistanceDistance")] 
		public CFloat KeepDistanceDistance
		{
			get => GetProperty(ref _keepDistanceDistance);
			set => SetProperty(ref _keepDistanceDistance, value);
		}

		[Ordinal(16)] 
		[RED("rubberBandingBool")] 
		public CBool RubberBandingBool
		{
			get => GetProperty(ref _rubberBandingBool);
			set => SetProperty(ref _rubberBandingBool, value);
		}

		[Ordinal(17)] 
		[RED("rubberBandingTargetRef")] 
		public wCHandle<gameObject> RubberBandingTargetRef
		{
			get => GetProperty(ref _rubberBandingTargetRef);
			set => SetProperty(ref _rubberBandingTargetRef, value);
		}

		[Ordinal(18)] 
		[RED("rubberBandingMinDistance")] 
		public CFloat RubberBandingMinDistance
		{
			get => GetProperty(ref _rubberBandingMinDistance);
			set => SetProperty(ref _rubberBandingMinDistance, value);
		}

		[Ordinal(19)] 
		[RED("rubberBandingMaxDistance")] 
		public CFloat RubberBandingMaxDistance
		{
			get => GetProperty(ref _rubberBandingMaxDistance);
			set => SetProperty(ref _rubberBandingMaxDistance, value);
		}

		[Ordinal(20)] 
		[RED("rubberBandingStopAndWait")] 
		public CBool RubberBandingStopAndWait
		{
			get => GetProperty(ref _rubberBandingStopAndWait);
			set => SetProperty(ref _rubberBandingStopAndWait, value);
		}

		[Ordinal(21)] 
		[RED("rubberBandingTeleportToCatchUp")] 
		public CBool RubberBandingTeleportToCatchUp
		{
			get => GetProperty(ref _rubberBandingTeleportToCatchUp);
			set => SetProperty(ref _rubberBandingTeleportToCatchUp, value);
		}

		[Ordinal(22)] 
		[RED("rubberBandingStayInFront")] 
		public CBool RubberBandingStayInFront
		{
			get => GetProperty(ref _rubberBandingStayInFront);
			set => SetProperty(ref _rubberBandingStayInFront, value);
		}

		public AIVehicleOnSplineCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
