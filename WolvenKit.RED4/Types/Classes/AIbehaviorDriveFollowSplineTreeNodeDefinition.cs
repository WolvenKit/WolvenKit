using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDriveFollowSplineTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("useKinematic")] 
		public CHandle<AIArgumentMapping> UseKinematic
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("needDriver")] 
		public CHandle<AIArgumentMapping> NeedDriver
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("secureTimeOut")] 
		public CHandle<AIArgumentMapping> SecureTimeOut
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("backwards")] 
		public CHandle<AIArgumentMapping> Backwards
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("reverse")] 
		public CHandle<AIArgumentMapping> Reverse
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("closest")] 
		public CHandle<AIArgumentMapping> Closest
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(8)] 
		[RED("forcedStartSpeed")] 
		public CHandle<AIArgumentMapping> ForcedStartSpeed
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(9)] 
		[RED("stopAtPathEnd")] 
		public CHandle<AIArgumentMapping> StopAtPathEnd
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(10)] 
		[RED("keepDistanceParamBool")] 
		public CHandle<AIArgumentMapping> KeepDistanceParamBool
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(11)] 
		[RED("keepDistanceParamCompanion")] 
		public CHandle<AIArgumentMapping> KeepDistanceParamCompanion
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(12)] 
		[RED("keepDistanceParamDistance")] 
		public CHandle<AIArgumentMapping> KeepDistanceParamDistance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(13)] 
		[RED("rubberBandingBool")] 
		public CHandle<AIArgumentMapping> RubberBandingBool
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(14)] 
		[RED("rubberBandingTargetRef")] 
		public CHandle<AIArgumentMapping> RubberBandingTargetRef
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(15)] 
		[RED("rubberBandingMinDistance")] 
		public CHandle<AIArgumentMapping> RubberBandingMinDistance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(16)] 
		[RED("rubberBandingMaxDistance")] 
		public CHandle<AIArgumentMapping> RubberBandingMaxDistance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(17)] 
		[RED("rubberBandingStopAndWait")] 
		public CHandle<AIArgumentMapping> RubberBandingStopAndWait
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(18)] 
		[RED("rubberBandingTeleportToCatchUp")] 
		public CHandle<AIArgumentMapping> RubberBandingTeleportToCatchUp
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(19)] 
		[RED("audioCurvesParam")] 
		public CHandle<AIArgumentMapping> AudioCurvesParam
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorDriveFollowSplineTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
