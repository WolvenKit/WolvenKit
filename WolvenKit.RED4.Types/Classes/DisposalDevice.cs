using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisposalDevice : InteractiveDevice
	{
		private CHandle<entMeshComponent> _additionalMeshComponent;
		private CWeakHandle<NPCPuppet> _npcBody;
		private CWeakHandle<gameIBlackboard> _playerStateMachineBlackboard;
		private CArray<CName> _sideTriggerNames;
		private CArray<CHandle<gameStaticTriggerAreaComponent>> _triggerComponents;
		private CName _currentDisposalSyncName;
		private CName _currentKillSyncName;
		private CBool _isNonlethal;
		private CArray<CName> _physicalMeshNames;
		private CArray<CHandle<entPhysicalMeshComponent>> _physicalMeshes;
		private CFloat _lethalTakedownKillDelay;
		private CArray<CName> _lethalTakedownComponentNames;
		private CArray<CHandle<entIPlacedComponent>> _lethalTakedownComponents;
		private CBool _isReactToHit;
		private CName _distractionSoundName;
		private CFloat _workspotDuration;
		private CHandle<redCallbackObject> _onTakedownChangedCallback;
		private CHandle<redCallbackObject> _onCarryingChangedCallback;

		[Ordinal(97)] 
		[RED("additionalMeshComponent")] 
		public CHandle<entMeshComponent> AdditionalMeshComponent
		{
			get => GetProperty(ref _additionalMeshComponent);
			set => SetProperty(ref _additionalMeshComponent, value);
		}

		[Ordinal(98)] 
		[RED("npcBody")] 
		public CWeakHandle<NPCPuppet> NpcBody
		{
			get => GetProperty(ref _npcBody);
			set => SetProperty(ref _npcBody, value);
		}

		[Ordinal(99)] 
		[RED("playerStateMachineBlackboard")] 
		public CWeakHandle<gameIBlackboard> PlayerStateMachineBlackboard
		{
			get => GetProperty(ref _playerStateMachineBlackboard);
			set => SetProperty(ref _playerStateMachineBlackboard, value);
		}

		[Ordinal(100)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetProperty(ref _sideTriggerNames);
			set => SetProperty(ref _sideTriggerNames, value);
		}

		[Ordinal(101)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetProperty(ref _triggerComponents);
			set => SetProperty(ref _triggerComponents, value);
		}

		[Ordinal(102)] 
		[RED("currentDisposalSyncName")] 
		public CName CurrentDisposalSyncName
		{
			get => GetProperty(ref _currentDisposalSyncName);
			set => SetProperty(ref _currentDisposalSyncName, value);
		}

		[Ordinal(103)] 
		[RED("currentKillSyncName")] 
		public CName CurrentKillSyncName
		{
			get => GetProperty(ref _currentKillSyncName);
			set => SetProperty(ref _currentKillSyncName, value);
		}

		[Ordinal(104)] 
		[RED("isNonlethal")] 
		public CBool IsNonlethal
		{
			get => GetProperty(ref _isNonlethal);
			set => SetProperty(ref _isNonlethal, value);
		}

		[Ordinal(105)] 
		[RED("physicalMeshNames")] 
		public CArray<CName> PhysicalMeshNames
		{
			get => GetProperty(ref _physicalMeshNames);
			set => SetProperty(ref _physicalMeshNames, value);
		}

		[Ordinal(106)] 
		[RED("physicalMeshes")] 
		public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes
		{
			get => GetProperty(ref _physicalMeshes);
			set => SetProperty(ref _physicalMeshes, value);
		}

		[Ordinal(107)] 
		[RED("lethalTakedownKillDelay")] 
		public CFloat LethalTakedownKillDelay
		{
			get => GetProperty(ref _lethalTakedownKillDelay);
			set => SetProperty(ref _lethalTakedownKillDelay, value);
		}

		[Ordinal(108)] 
		[RED("lethalTakedownComponentNames")] 
		public CArray<CName> LethalTakedownComponentNames
		{
			get => GetProperty(ref _lethalTakedownComponentNames);
			set => SetProperty(ref _lethalTakedownComponentNames, value);
		}

		[Ordinal(109)] 
		[RED("lethalTakedownComponents")] 
		public CArray<CHandle<entIPlacedComponent>> LethalTakedownComponents
		{
			get => GetProperty(ref _lethalTakedownComponents);
			set => SetProperty(ref _lethalTakedownComponents, value);
		}

		[Ordinal(110)] 
		[RED("isReactToHit")] 
		public CBool IsReactToHit
		{
			get => GetProperty(ref _isReactToHit);
			set => SetProperty(ref _isReactToHit, value);
		}

		[Ordinal(111)] 
		[RED("distractionSoundName")] 
		public CName DistractionSoundName
		{
			get => GetProperty(ref _distractionSoundName);
			set => SetProperty(ref _distractionSoundName, value);
		}

		[Ordinal(112)] 
		[RED("workspotDuration")] 
		public CFloat WorkspotDuration
		{
			get => GetProperty(ref _workspotDuration);
			set => SetProperty(ref _workspotDuration, value);
		}

		[Ordinal(113)] 
		[RED("OnTakedownChangedCallback")] 
		public CHandle<redCallbackObject> OnTakedownChangedCallback
		{
			get => GetProperty(ref _onTakedownChangedCallback);
			set => SetProperty(ref _onTakedownChangedCallback, value);
		}

		[Ordinal(114)] 
		[RED("OnCarryingChangedCallback")] 
		public CHandle<redCallbackObject> OnCarryingChangedCallback
		{
			get => GetProperty(ref _onCarryingChangedCallback);
			set => SetProperty(ref _onCarryingChangedCallback, value);
		}

		public DisposalDevice()
		{
			_currentDisposalSyncName = "disposalSyncSide1";
			_currentKillSyncName = "killSyncSide1";
			_lethalTakedownKillDelay = 0.200000F;
			_distractionSoundName = "v_car_thorton_galena_horn";
			_workspotDuration = 0.010000F;
		}
	}
}
