using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApproachVehicleDecorator : AIVehicleTaskAbstract
	{
		private CHandle<AIArgumentMapping> _mountData;
		private CHandle<AIArgumentMapping> _mountRequest;
		private CHandle<AIArgumentMapping> _entryPoint;
		private CBool _doorOpenRequestSent;
		private CBool _closeDoor;
		private CHandle<gameMountEventData> _mountEventData;
		private CHandle<gameMountEventData> _mountRequestData;
		private Vector4 _mountEntryPoint;
		private EngineTime _activationTime;
		private CBool _runCompanionCheck;

		[Ordinal(0)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get => GetProperty(ref _mountData);
			set => SetProperty(ref _mountData, value);
		}

		[Ordinal(1)] 
		[RED("mountRequest")] 
		public CHandle<AIArgumentMapping> MountRequest
		{
			get => GetProperty(ref _mountRequest);
			set => SetProperty(ref _mountRequest, value);
		}

		[Ordinal(2)] 
		[RED("entryPoint")] 
		public CHandle<AIArgumentMapping> EntryPoint
		{
			get => GetProperty(ref _entryPoint);
			set => SetProperty(ref _entryPoint, value);
		}

		[Ordinal(3)] 
		[RED("doorOpenRequestSent")] 
		public CBool DoorOpenRequestSent
		{
			get => GetProperty(ref _doorOpenRequestSent);
			set => SetProperty(ref _doorOpenRequestSent, value);
		}

		[Ordinal(4)] 
		[RED("closeDoor")] 
		public CBool CloseDoor
		{
			get => GetProperty(ref _closeDoor);
			set => SetProperty(ref _closeDoor, value);
		}

		[Ordinal(5)] 
		[RED("mountEventData")] 
		public CHandle<gameMountEventData> MountEventData
		{
			get => GetProperty(ref _mountEventData);
			set => SetProperty(ref _mountEventData, value);
		}

		[Ordinal(6)] 
		[RED("mountRequestData")] 
		public CHandle<gameMountEventData> MountRequestData
		{
			get => GetProperty(ref _mountRequestData);
			set => SetProperty(ref _mountRequestData, value);
		}

		[Ordinal(7)] 
		[RED("mountEntryPoint")] 
		public Vector4 MountEntryPoint
		{
			get => GetProperty(ref _mountEntryPoint);
			set => SetProperty(ref _mountEntryPoint, value);
		}

		[Ordinal(8)] 
		[RED("activationTime")] 
		public EngineTime ActivationTime
		{
			get => GetProperty(ref _activationTime);
			set => SetProperty(ref _activationTime, value);
		}

		[Ordinal(9)] 
		[RED("runCompanionCheck")] 
		public CBool RunCompanionCheck
		{
			get => GetProperty(ref _runCompanionCheck);
			set => SetProperty(ref _runCompanionCheck, value);
		}
	}
}
