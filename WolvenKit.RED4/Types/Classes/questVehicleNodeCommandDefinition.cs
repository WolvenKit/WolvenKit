using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleNodeCommandDefinition : questAICommandNodeBase
	{
		[Ordinal(2)] 
		[RED("vehicle")] 
		public gameEntityReference Vehicle
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("commandParams")] 
		public CHandle<questVehicleCommandParams> CommandParams
		{
			get => GetPropertyValue<CHandle<questVehicleCommandParams>>();
			set => SetPropertyValue<CHandle<questVehicleCommandParams>>(value);
		}

		public questVehicleNodeCommandDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			Vehicle = new gameEntityReference();
			CommandParams = new questVehicleCommandParams { AdditionalParamsOnSpline = new questvehicleOnSplineParams { KeepDistanceParam = new questParamKeepDistance { CompanionTargetRef = new questUniversalRef { RefLocalPlayer = false } }, RubberBandingParam = new questParamRubberbanding { TargetRef = new questUniversalRef { RefLocalPlayer = false } } }, AdditionalParamsFollow = new questvehicleFollowParams(), AdditionalParamsToNode = new questvehicleToNodeParams { Portals = new vehiclePortalsList() }, AdditionalParamsRacing = new questvehicleRacingParams { RubberBandingParam = new questParamRubberbanding { TargetRef = new questUniversalRef { RefLocalPlayer = false } } }, AdditionalParamsJoinTraffic = new questvehicleJoinTrafficParams(), AdditionalParamsPanic = new questvehiclePanicParams(), AdditionalParamsChase = new questvehicleChaseParams() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
