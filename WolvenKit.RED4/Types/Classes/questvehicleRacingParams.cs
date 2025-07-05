using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questvehicleRacingParams : questVehicleSpecificCommandParams
	{
		[Ordinal(3)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(4)] 
		[RED("preciseLevel")] 
		public CFloat PreciseLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("backwards")] 
		public CBool Backwards
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("closest")] 
		public CBool Closest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("rubberBanding")] 
		public CBool RubberBanding
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("rubberBandingParam")] 
		public CHandle<questParamRubberbanding> RubberBandingParam
		{
			get => GetPropertyValue<CHandle<questParamRubberbanding>>();
			set => SetPropertyValue<CHandle<questParamRubberbanding>>(value);
		}

		public questvehicleRacingParams()
		{
			PushOtherVehiclesAside = true;
			SecureTimeOut = 60.000000F;
			PreciseLevel = 1.000000F;
			Closest = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
