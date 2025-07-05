using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questvehicleOnSplineParams : questVehicleSpecificCommandParams
	{
		[Ordinal(3)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(4)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("backwards")] 
		public CBool Backwards
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("closest")] 
		public CBool Closest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("stopAtEnd")] 
		public CBool StopAtEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("keepDistance")] 
		public CBool KeepDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("keepDistanceParam")] 
		public CHandle<questParamKeepDistance> KeepDistanceParam
		{
			get => GetPropertyValue<CHandle<questParamKeepDistance>>();
			set => SetPropertyValue<CHandle<questParamKeepDistance>>(value);
		}

		[Ordinal(11)] 
		[RED("rubberBanding")] 
		public CBool RubberBanding
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("rubberBandingParam")] 
		public CHandle<questParamRubberbanding> RubberBandingParam
		{
			get => GetPropertyValue<CHandle<questParamRubberbanding>>();
			set => SetPropertyValue<CHandle<questParamRubberbanding>>(value);
		}

		[Ordinal(13)] 
		[RED("audioCurvesParam")] 
		public CHandle<vehicleAudioCurvesParam> AudioCurvesParam
		{
			get => GetPropertyValue<CHandle<vehicleAudioCurvesParam>>();
			set => SetPropertyValue<CHandle<vehicleAudioCurvesParam>>(value);
		}

		public questvehicleOnSplineParams()
		{
			PushOtherVehiclesAside = true;
			SecureTimeOut = 60.000000F;
			Closest = true;
			ForcedStartSpeed = -1.000000F;
			StopAtEnd = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
