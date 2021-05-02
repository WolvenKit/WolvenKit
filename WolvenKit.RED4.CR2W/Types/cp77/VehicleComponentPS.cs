using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleComponentPS : ScriptableDeviceComponentPS
	{
		private CBool _defaultStateSet;
		private CBool _stateModifiedByQuest;
		private CBool _playerVehicle;
		private CArray<CName> _npcOccupiedSlots;
		private CBool _isDestroyed;
		private CBool _isStolen;
		private CBool _crystalDomeQuestModified;
		private CBool _crystalDomeQuestState;
		private CBool _crystalDomeState;
		private CBool _visualDestructionSet;
		private CBool _visualDestructionNeeded;
		private CBool _exploded;
		private CBool _sirenOn;
		private CBool _sirenSoundOn;
		private CBool _sirenLightsOn;
		private CBool _anyDoorOpen;
		private CArray<TemporaryDoorState> _previousInteractionState;
		private CBool _thrusterState;
		private CBool _uiQuestModified;
		private CBool _uiState;
		private CHandle<EngDemoContainer> _vehicleSkillChecks;
		private CBool _ready;
		private CBool _isPlayerPerformingBodyDisposal;
		private CHandle<vehicleControllerPS> _vehicleControllerPS;

		[Ordinal(103)] 
		[RED("defaultStateSet")] 
		public CBool DefaultStateSet
		{
			get => GetProperty(ref _defaultStateSet);
			set => SetProperty(ref _defaultStateSet, value);
		}

		[Ordinal(104)] 
		[RED("stateModifiedByQuest")] 
		public CBool StateModifiedByQuest
		{
			get => GetProperty(ref _stateModifiedByQuest);
			set => SetProperty(ref _stateModifiedByQuest, value);
		}

		[Ordinal(105)] 
		[RED("playerVehicle")] 
		public CBool PlayerVehicle
		{
			get => GetProperty(ref _playerVehicle);
			set => SetProperty(ref _playerVehicle, value);
		}

		[Ordinal(106)] 
		[RED("npcOccupiedSlots")] 
		public CArray<CName> NpcOccupiedSlots
		{
			get => GetProperty(ref _npcOccupiedSlots);
			set => SetProperty(ref _npcOccupiedSlots, value);
		}

		[Ordinal(107)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get => GetProperty(ref _isDestroyed);
			set => SetProperty(ref _isDestroyed, value);
		}

		[Ordinal(108)] 
		[RED("isStolen")] 
		public CBool IsStolen
		{
			get => GetProperty(ref _isStolen);
			set => SetProperty(ref _isStolen, value);
		}

		[Ordinal(109)] 
		[RED("crystalDomeQuestModified")] 
		public CBool CrystalDomeQuestModified
		{
			get => GetProperty(ref _crystalDomeQuestModified);
			set => SetProperty(ref _crystalDomeQuestModified, value);
		}

		[Ordinal(110)] 
		[RED("crystalDomeQuestState")] 
		public CBool CrystalDomeQuestState
		{
			get => GetProperty(ref _crystalDomeQuestState);
			set => SetProperty(ref _crystalDomeQuestState, value);
		}

		[Ordinal(111)] 
		[RED("crystalDomeState")] 
		public CBool CrystalDomeState
		{
			get => GetProperty(ref _crystalDomeState);
			set => SetProperty(ref _crystalDomeState, value);
		}

		[Ordinal(112)] 
		[RED("visualDestructionSet")] 
		public CBool VisualDestructionSet
		{
			get => GetProperty(ref _visualDestructionSet);
			set => SetProperty(ref _visualDestructionSet, value);
		}

		[Ordinal(113)] 
		[RED("visualDestructionNeeded")] 
		public CBool VisualDestructionNeeded
		{
			get => GetProperty(ref _visualDestructionNeeded);
			set => SetProperty(ref _visualDestructionNeeded, value);
		}

		[Ordinal(114)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get => GetProperty(ref _exploded);
			set => SetProperty(ref _exploded, value);
		}

		[Ordinal(115)] 
		[RED("sirenOn")] 
		public CBool SirenOn
		{
			get => GetProperty(ref _sirenOn);
			set => SetProperty(ref _sirenOn, value);
		}

		[Ordinal(116)] 
		[RED("sirenSoundOn")] 
		public CBool SirenSoundOn
		{
			get => GetProperty(ref _sirenSoundOn);
			set => SetProperty(ref _sirenSoundOn, value);
		}

		[Ordinal(117)] 
		[RED("sirenLightsOn")] 
		public CBool SirenLightsOn
		{
			get => GetProperty(ref _sirenLightsOn);
			set => SetProperty(ref _sirenLightsOn, value);
		}

		[Ordinal(118)] 
		[RED("anyDoorOpen")] 
		public CBool AnyDoorOpen
		{
			get => GetProperty(ref _anyDoorOpen);
			set => SetProperty(ref _anyDoorOpen, value);
		}

		[Ordinal(119)] 
		[RED("previousInteractionState")] 
		public CArray<TemporaryDoorState> PreviousInteractionState
		{
			get => GetProperty(ref _previousInteractionState);
			set => SetProperty(ref _previousInteractionState, value);
		}

		[Ordinal(120)] 
		[RED("thrusterState")] 
		public CBool ThrusterState
		{
			get => GetProperty(ref _thrusterState);
			set => SetProperty(ref _thrusterState, value);
		}

		[Ordinal(121)] 
		[RED("uiQuestModified")] 
		public CBool UiQuestModified
		{
			get => GetProperty(ref _uiQuestModified);
			set => SetProperty(ref _uiQuestModified, value);
		}

		[Ordinal(122)] 
		[RED("uiState")] 
		public CBool UiState
		{
			get => GetProperty(ref _uiState);
			set => SetProperty(ref _uiState, value);
		}

		[Ordinal(123)] 
		[RED("vehicleSkillChecks")] 
		public CHandle<EngDemoContainer> VehicleSkillChecks
		{
			get => GetProperty(ref _vehicleSkillChecks);
			set => SetProperty(ref _vehicleSkillChecks, value);
		}

		[Ordinal(124)] 
		[RED("ready")] 
		public CBool Ready
		{
			get => GetProperty(ref _ready);
			set => SetProperty(ref _ready, value);
		}

		[Ordinal(125)] 
		[RED("isPlayerPerformingBodyDisposal")] 
		public CBool IsPlayerPerformingBodyDisposal
		{
			get => GetProperty(ref _isPlayerPerformingBodyDisposal);
			set => SetProperty(ref _isPlayerPerformingBodyDisposal, value);
		}

		[Ordinal(126)] 
		[RED("vehicleControllerPS")] 
		public CHandle<vehicleControllerPS> VehicleControllerPS
		{
			get => GetProperty(ref _vehicleControllerPS);
			set => SetProperty(ref _vehicleControllerPS, value);
		}

		public VehicleComponentPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
