using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleDeathTask : AIDeathReactionsTask
	{
		[Ordinal(3)] 
		[RED("vehNPCDeathData")] 
		public CHandle<AnimFeature_VehicleNPCDeathData> VehNPCDeathData
		{
			get => GetPropertyValue<CHandle<AnimFeature_VehicleNPCDeathData>>();
			set => SetPropertyValue<CHandle<AnimFeature_VehicleNPCDeathData>>(value);
		}

		[Ordinal(4)] 
		[RED("previousState")] 
		public CEnum<gamedataNPCHighLevelState> PreviousState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(5)] 
		[RED("timeToRagdoll")] 
		public CFloat TimeToRagdoll
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("hasRagdolled")] 
		public CBool HasRagdolled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("readyToUnmount")] 
		public CBool ReadyToUnmount
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleDeathTask()
		{
			TimeToRagdoll = 0.440000F;
		}
	}
}
