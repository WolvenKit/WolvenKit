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

		public questVehicleCommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
