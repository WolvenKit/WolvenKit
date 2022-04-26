using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIDriveOnSplineCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] 
		[RED("outUseKinematic")] 
		public CHandle<AIArgumentMapping> OutUseKinematic
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("outNeedDriver")] 
		public CHandle<AIArgumentMapping> OutNeedDriver
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("outSpline")] 
		public CHandle<AIArgumentMapping> OutSpline
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("outSecureTimeOut")] 
		public CHandle<AIArgumentMapping> OutSecureTimeOut
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("outDriveBackwards")] 
		public CHandle<AIArgumentMapping> OutDriveBackwards
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("outReverseSpline")] 
		public CHandle<AIArgumentMapping> OutReverseSpline
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("outStartFromClosest")] 
		public CHandle<AIArgumentMapping> OutStartFromClosest
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(8)] 
		[RED("outForcedStartSpeed")] 
		public CHandle<AIArgumentMapping> OutForcedStartSpeed
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(9)] 
		[RED("outStopAtPathEnd")] 
		public CHandle<AIArgumentMapping> OutStopAtPathEnd
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(10)] 
		[RED("outKeepDistanceBool")] 
		public CHandle<AIArgumentMapping> OutKeepDistanceBool
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(11)] 
		[RED("outKeepDistanceCompanion")] 
		public CHandle<AIArgumentMapping> OutKeepDistanceCompanion
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(12)] 
		[RED("outKeepDistanceDistance")] 
		public CHandle<AIArgumentMapping> OutKeepDistanceDistance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(13)] 
		[RED("outRubberBandingBool")] 
		public CHandle<AIArgumentMapping> OutRubberBandingBool
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(14)] 
		[RED("outRubberBandingTargetRef")] 
		public CHandle<AIArgumentMapping> OutRubberBandingTargetRef
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(15)] 
		[RED("outRubberBandingMinDistance")] 
		public CHandle<AIArgumentMapping> OutRubberBandingMinDistance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(16)] 
		[RED("outRubberBandingMaxDistance")] 
		public CHandle<AIArgumentMapping> OutRubberBandingMaxDistance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(17)] 
		[RED("outRubberBandingStopAndWait")] 
		public CHandle<AIArgumentMapping> OutRubberBandingStopAndWait
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(18)] 
		[RED("outRubberBandingTeleportToCatchUp")] 
		public CHandle<AIArgumentMapping> OutRubberBandingTeleportToCatchUp
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(19)] 
		[RED("outRubberBandingStayInFront")] 
		public CHandle<AIArgumentMapping> OutRubberBandingStayInFront
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIDriveOnSplineCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
