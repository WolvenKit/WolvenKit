using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleCommandParams : questAICommandParams
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questVehicleCommandType> Type
		{
			get => GetPropertyValue<CEnum<questVehicleCommandType>>();
			set => SetPropertyValue<CEnum<questVehicleCommandType>>(value);
		}

		[Ordinal(1)] 
		[RED("additionalParamsOnSpline")] 
		public CHandle<questvehicleOnSplineParams> AdditionalParamsOnSpline
		{
			get => GetPropertyValue<CHandle<questvehicleOnSplineParams>>();
			set => SetPropertyValue<CHandle<questvehicleOnSplineParams>>(value);
		}

		[Ordinal(2)] 
		[RED("additionalParamsFollow")] 
		public CHandle<questvehicleFollowParams> AdditionalParamsFollow
		{
			get => GetPropertyValue<CHandle<questvehicleFollowParams>>();
			set => SetPropertyValue<CHandle<questvehicleFollowParams>>(value);
		}

		[Ordinal(3)] 
		[RED("additionalParamsToNode")] 
		public CHandle<questvehicleToNodeParams> AdditionalParamsToNode
		{
			get => GetPropertyValue<CHandle<questvehicleToNodeParams>>();
			set => SetPropertyValue<CHandle<questvehicleToNodeParams>>(value);
		}

		[Ordinal(4)] 
		[RED("additionalParamsRacing")] 
		public CHandle<questvehicleRacingParams> AdditionalParamsRacing
		{
			get => GetPropertyValue<CHandle<questvehicleRacingParams>>();
			set => SetPropertyValue<CHandle<questvehicleRacingParams>>(value);
		}

		[Ordinal(5)] 
		[RED("additionalParamsJoinTraffic")] 
		public CHandle<questvehicleJoinTrafficParams> AdditionalParamsJoinTraffic
		{
			get => GetPropertyValue<CHandle<questvehicleJoinTrafficParams>>();
			set => SetPropertyValue<CHandle<questvehicleJoinTrafficParams>>(value);
		}

		[Ordinal(6)] 
		[RED("additionalParamsPanic")] 
		public CHandle<questvehiclePanicParams> AdditionalParamsPanic
		{
			get => GetPropertyValue<CHandle<questvehiclePanicParams>>();
			set => SetPropertyValue<CHandle<questvehiclePanicParams>>(value);
		}

		[Ordinal(7)] 
		[RED("additionalParamsChase")] 
		public CHandle<questvehicleChaseParams> AdditionalParamsChase
		{
			get => GetPropertyValue<CHandle<questvehicleChaseParams>>();
			set => SetPropertyValue<CHandle<questvehicleChaseParams>>(value);
		}

		public questVehicleCommandParams()
		{
			AdditionalParamsOnSpline = new questvehicleOnSplineParams { KeepDistanceParam = new questParamKeepDistance { CompanionTargetRef = new questUniversalRef { RefLocalPlayer = false } }, RubberBandingParam = new questParamRubberbanding { TargetRef = new questUniversalRef { RefLocalPlayer = false } } };
			AdditionalParamsFollow = new questvehicleFollowParams();
			AdditionalParamsToNode = new questvehicleToNodeParams { Portals = new vehiclePortalsList() };
			AdditionalParamsRacing = new questvehicleRacingParams { RubberBandingParam = new questParamRubberbanding { TargetRef = new questUniversalRef { RefLocalPlayer = false } } };
			AdditionalParamsJoinTraffic = new questvehicleJoinTrafficParams();
			AdditionalParamsPanic = new questvehiclePanicParams();
			AdditionalParamsChase = new questvehicleChaseParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
