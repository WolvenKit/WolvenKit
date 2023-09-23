using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleDeathTask : AIDeathReactionsTask
	{
		[Ordinal(6)] 
		[RED("vehNPCDeathData")] 
		public CHandle<AnimFeature_VehicleNPCDeathData> VehNPCDeathData
		{
			get => GetPropertyValue<CHandle<AnimFeature_VehicleNPCDeathData>>();
			set => SetPropertyValue<CHandle<AnimFeature_VehicleNPCDeathData>>(value);
		}

		[Ordinal(7)] 
		[RED("previousState")] 
		public CEnum<gamedataNPCHighLevelState> PreviousState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(8)] 
		[RED("timeToRagdoll")] 
		public CFloat TimeToRagdoll
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("hasRagdolled")] 
		public CBool HasRagdolled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("readyToUnmount")] 
		public CBool ReadyToUnmount
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleDeathTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
