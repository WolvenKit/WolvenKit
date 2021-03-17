using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDriveOnSplineCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outUseKinematic;
		private CHandle<AIArgumentMapping> _outNeedDriver;
		private CHandle<AIArgumentMapping> _outSpline;
		private CHandle<AIArgumentMapping> _outSecureTimeOut;
		private CHandle<AIArgumentMapping> _outDriveBackwards;
		private CHandle<AIArgumentMapping> _outReverseSpline;
		private CHandle<AIArgumentMapping> _outStartFromClosest;
		private CHandle<AIArgumentMapping> _outForcedStartSpeed;
		private CHandle<AIArgumentMapping> _outStopAtPathEnd;
		private CHandle<AIArgumentMapping> _outKeepDistanceBool;
		private CHandle<AIArgumentMapping> _outKeepDistanceCompanion;
		private CHandle<AIArgumentMapping> _outKeepDistanceDistance;
		private CHandle<AIArgumentMapping> _outRubberBandingBool;
		private CHandle<AIArgumentMapping> _outRubberBandingTargetRef;
		private CHandle<AIArgumentMapping> _outRubberBandingMinDistance;
		private CHandle<AIArgumentMapping> _outRubberBandingMaxDistance;
		private CHandle<AIArgumentMapping> _outRubberBandingStopAndWait;
		private CHandle<AIArgumentMapping> _outRubberBandingTeleportToCatchUp;
		private CHandle<AIArgumentMapping> _outRubberBandingStayInFront;

		[Ordinal(1)] 
		[RED("outUseKinematic")] 
		public CHandle<AIArgumentMapping> OutUseKinematic
		{
			get => GetProperty(ref _outUseKinematic);
			set => SetProperty(ref _outUseKinematic, value);
		}

		[Ordinal(2)] 
		[RED("outNeedDriver")] 
		public CHandle<AIArgumentMapping> OutNeedDriver
		{
			get => GetProperty(ref _outNeedDriver);
			set => SetProperty(ref _outNeedDriver, value);
		}

		[Ordinal(3)] 
		[RED("outSpline")] 
		public CHandle<AIArgumentMapping> OutSpline
		{
			get => GetProperty(ref _outSpline);
			set => SetProperty(ref _outSpline, value);
		}

		[Ordinal(4)] 
		[RED("outSecureTimeOut")] 
		public CHandle<AIArgumentMapping> OutSecureTimeOut
		{
			get => GetProperty(ref _outSecureTimeOut);
			set => SetProperty(ref _outSecureTimeOut, value);
		}

		[Ordinal(5)] 
		[RED("outDriveBackwards")] 
		public CHandle<AIArgumentMapping> OutDriveBackwards
		{
			get => GetProperty(ref _outDriveBackwards);
			set => SetProperty(ref _outDriveBackwards, value);
		}

		[Ordinal(6)] 
		[RED("outReverseSpline")] 
		public CHandle<AIArgumentMapping> OutReverseSpline
		{
			get => GetProperty(ref _outReverseSpline);
			set => SetProperty(ref _outReverseSpline, value);
		}

		[Ordinal(7)] 
		[RED("outStartFromClosest")] 
		public CHandle<AIArgumentMapping> OutStartFromClosest
		{
			get => GetProperty(ref _outStartFromClosest);
			set => SetProperty(ref _outStartFromClosest, value);
		}

		[Ordinal(8)] 
		[RED("outForcedStartSpeed")] 
		public CHandle<AIArgumentMapping> OutForcedStartSpeed
		{
			get => GetProperty(ref _outForcedStartSpeed);
			set => SetProperty(ref _outForcedStartSpeed, value);
		}

		[Ordinal(9)] 
		[RED("outStopAtPathEnd")] 
		public CHandle<AIArgumentMapping> OutStopAtPathEnd
		{
			get => GetProperty(ref _outStopAtPathEnd);
			set => SetProperty(ref _outStopAtPathEnd, value);
		}

		[Ordinal(10)] 
		[RED("outKeepDistanceBool")] 
		public CHandle<AIArgumentMapping> OutKeepDistanceBool
		{
			get => GetProperty(ref _outKeepDistanceBool);
			set => SetProperty(ref _outKeepDistanceBool, value);
		}

		[Ordinal(11)] 
		[RED("outKeepDistanceCompanion")] 
		public CHandle<AIArgumentMapping> OutKeepDistanceCompanion
		{
			get => GetProperty(ref _outKeepDistanceCompanion);
			set => SetProperty(ref _outKeepDistanceCompanion, value);
		}

		[Ordinal(12)] 
		[RED("outKeepDistanceDistance")] 
		public CHandle<AIArgumentMapping> OutKeepDistanceDistance
		{
			get => GetProperty(ref _outKeepDistanceDistance);
			set => SetProperty(ref _outKeepDistanceDistance, value);
		}

		[Ordinal(13)] 
		[RED("outRubberBandingBool")] 
		public CHandle<AIArgumentMapping> OutRubberBandingBool
		{
			get => GetProperty(ref _outRubberBandingBool);
			set => SetProperty(ref _outRubberBandingBool, value);
		}

		[Ordinal(14)] 
		[RED("outRubberBandingTargetRef")] 
		public CHandle<AIArgumentMapping> OutRubberBandingTargetRef
		{
			get => GetProperty(ref _outRubberBandingTargetRef);
			set => SetProperty(ref _outRubberBandingTargetRef, value);
		}

		[Ordinal(15)] 
		[RED("outRubberBandingMinDistance")] 
		public CHandle<AIArgumentMapping> OutRubberBandingMinDistance
		{
			get => GetProperty(ref _outRubberBandingMinDistance);
			set => SetProperty(ref _outRubberBandingMinDistance, value);
		}

		[Ordinal(16)] 
		[RED("outRubberBandingMaxDistance")] 
		public CHandle<AIArgumentMapping> OutRubberBandingMaxDistance
		{
			get => GetProperty(ref _outRubberBandingMaxDistance);
			set => SetProperty(ref _outRubberBandingMaxDistance, value);
		}

		[Ordinal(17)] 
		[RED("outRubberBandingStopAndWait")] 
		public CHandle<AIArgumentMapping> OutRubberBandingStopAndWait
		{
			get => GetProperty(ref _outRubberBandingStopAndWait);
			set => SetProperty(ref _outRubberBandingStopAndWait, value);
		}

		[Ordinal(18)] 
		[RED("outRubberBandingTeleportToCatchUp")] 
		public CHandle<AIArgumentMapping> OutRubberBandingTeleportToCatchUp
		{
			get => GetProperty(ref _outRubberBandingTeleportToCatchUp);
			set => SetProperty(ref _outRubberBandingTeleportToCatchUp, value);
		}

		[Ordinal(19)] 
		[RED("outRubberBandingStayInFront")] 
		public CHandle<AIArgumentMapping> OutRubberBandingStayInFront
		{
			get => GetProperty(ref _outRubberBandingStayInFront);
			set => SetProperty(ref _outRubberBandingStayInFront, value);
		}

		public AIDriveOnSplineCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
