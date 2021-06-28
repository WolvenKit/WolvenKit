using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisposalDevice : InteractiveDevice
	{
		private CHandle<entMeshComponent> _additionalMeshComponent;
		private wCHandle<NPCPuppet> _npcBody;
		private CHandle<gameIBlackboard> _playerStateMachineBlackboard;
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

		[Ordinal(96)] 
		[RED("additionalMeshComponent")] 
		public CHandle<entMeshComponent> AdditionalMeshComponent
		{
			get => GetProperty(ref _additionalMeshComponent);
			set => SetProperty(ref _additionalMeshComponent, value);
		}

		[Ordinal(97)] 
		[RED("npcBody")] 
		public wCHandle<NPCPuppet> NpcBody
		{
			get => GetProperty(ref _npcBody);
			set => SetProperty(ref _npcBody, value);
		}

		[Ordinal(98)] 
		[RED("playerStateMachineBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStateMachineBlackboard
		{
			get => GetProperty(ref _playerStateMachineBlackboard);
			set => SetProperty(ref _playerStateMachineBlackboard, value);
		}

		[Ordinal(99)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetProperty(ref _sideTriggerNames);
			set => SetProperty(ref _sideTriggerNames, value);
		}

		[Ordinal(100)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetProperty(ref _triggerComponents);
			set => SetProperty(ref _triggerComponents, value);
		}

		[Ordinal(101)] 
		[RED("currentDisposalSyncName")] 
		public CName CurrentDisposalSyncName
		{
			get => GetProperty(ref _currentDisposalSyncName);
			set => SetProperty(ref _currentDisposalSyncName, value);
		}

		[Ordinal(102)] 
		[RED("currentKillSyncName")] 
		public CName CurrentKillSyncName
		{
			get => GetProperty(ref _currentKillSyncName);
			set => SetProperty(ref _currentKillSyncName, value);
		}

		[Ordinal(103)] 
		[RED("isNonlethal")] 
		public CBool IsNonlethal
		{
			get => GetProperty(ref _isNonlethal);
			set => SetProperty(ref _isNonlethal, value);
		}

		[Ordinal(104)] 
		[RED("physicalMeshNames")] 
		public CArray<CName> PhysicalMeshNames
		{
			get => GetProperty(ref _physicalMeshNames);
			set => SetProperty(ref _physicalMeshNames, value);
		}

		[Ordinal(105)] 
		[RED("physicalMeshes")] 
		public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes
		{
			get => GetProperty(ref _physicalMeshes);
			set => SetProperty(ref _physicalMeshes, value);
		}

		[Ordinal(106)] 
		[RED("lethalTakedownKillDelay")] 
		public CFloat LethalTakedownKillDelay
		{
			get => GetProperty(ref _lethalTakedownKillDelay);
			set => SetProperty(ref _lethalTakedownKillDelay, value);
		}

		[Ordinal(107)] 
		[RED("lethalTakedownComponentNames")] 
		public CArray<CName> LethalTakedownComponentNames
		{
			get => GetProperty(ref _lethalTakedownComponentNames);
			set => SetProperty(ref _lethalTakedownComponentNames, value);
		}

		[Ordinal(108)] 
		[RED("lethalTakedownComponents")] 
		public CArray<CHandle<entIPlacedComponent>> LethalTakedownComponents
		{
			get => GetProperty(ref _lethalTakedownComponents);
			set => SetProperty(ref _lethalTakedownComponents, value);
		}

		[Ordinal(109)] 
		[RED("isReactToHit")] 
		public CBool IsReactToHit
		{
			get => GetProperty(ref _isReactToHit);
			set => SetProperty(ref _isReactToHit, value);
		}

		[Ordinal(110)] 
		[RED("distractionSoundName")] 
		public CName DistractionSoundName
		{
			get => GetProperty(ref _distractionSoundName);
			set => SetProperty(ref _distractionSoundName, value);
		}

		[Ordinal(111)] 
		[RED("workspotDuration")] 
		public CFloat WorkspotDuration
		{
			get => GetProperty(ref _workspotDuration);
			set => SetProperty(ref _workspotDuration, value);
		}

		public DisposalDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
