using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleDeathTask : AIDeathReactionsTask
	{
		private CHandle<AnimFeature_VehicleNPCDeathData> _vehNPCDeathData;
		private CEnum<gamedataNPCHighLevelState> _previousState;
		private CFloat _timeToRagdoll;
		private CBool _hasRagdolled;
		private CFloat _activationTimeStamp;
		private CBool _readyToUnmount;

		[Ordinal(3)] 
		[RED("vehNPCDeathData")] 
		public CHandle<AnimFeature_VehicleNPCDeathData> VehNPCDeathData
		{
			get => GetProperty(ref _vehNPCDeathData);
			set => SetProperty(ref _vehNPCDeathData, value);
		}

		[Ordinal(4)] 
		[RED("previousState")] 
		public CEnum<gamedataNPCHighLevelState> PreviousState
		{
			get => GetProperty(ref _previousState);
			set => SetProperty(ref _previousState, value);
		}

		[Ordinal(5)] 
		[RED("timeToRagdoll")] 
		public CFloat TimeToRagdoll
		{
			get => GetProperty(ref _timeToRagdoll);
			set => SetProperty(ref _timeToRagdoll, value);
		}

		[Ordinal(6)] 
		[RED("hasRagdolled")] 
		public CBool HasRagdolled
		{
			get => GetProperty(ref _hasRagdolled);
			set => SetProperty(ref _hasRagdolled, value);
		}

		[Ordinal(7)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetProperty(ref _activationTimeStamp);
			set => SetProperty(ref _activationTimeStamp, value);
		}

		[Ordinal(8)] 
		[RED("readyToUnmount")] 
		public CBool ReadyToUnmount
		{
			get => GetProperty(ref _readyToUnmount);
			set => SetProperty(ref _readyToUnmount, value);
		}

		public VehicleDeathTask()
		{
			_timeToRagdoll = 0.440000F;
		}
	}
}
