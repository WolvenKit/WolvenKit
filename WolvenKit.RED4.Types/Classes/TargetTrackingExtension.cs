using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetTrackingExtension : AITargetTrackerComponent
	{
		private DroppedThreatData _droppedThreatData;
		private CArray<CHandle<AICombatSquadScriptInterface>> _trackedCombatSquads;
		private CArray<CInt32> _trackedCombatSquadsCounters;
		private ThreatPersistanceMemory _threatPersistanceMemory;
		private CBool _hasBeenSeenByPlayer;
		private CBool _canBeAddedToBossHealthbar;
		private CWeakHandle<gameObject> _playerPuppet;

		[Ordinal(5)] 
		[RED("droppedThreatData")] 
		public DroppedThreatData DroppedThreatData
		{
			get => GetProperty(ref _droppedThreatData);
			set => SetProperty(ref _droppedThreatData, value);
		}

		[Ordinal(6)] 
		[RED("trackedCombatSquads")] 
		public CArray<CHandle<AICombatSquadScriptInterface>> TrackedCombatSquads
		{
			get => GetProperty(ref _trackedCombatSquads);
			set => SetProperty(ref _trackedCombatSquads, value);
		}

		[Ordinal(7)] 
		[RED("trackedCombatSquadsCounters")] 
		public CArray<CInt32> TrackedCombatSquadsCounters
		{
			get => GetProperty(ref _trackedCombatSquadsCounters);
			set => SetProperty(ref _trackedCombatSquadsCounters, value);
		}

		[Ordinal(8)] 
		[RED("threatPersistanceMemory")] 
		public ThreatPersistanceMemory ThreatPersistanceMemory
		{
			get => GetProperty(ref _threatPersistanceMemory);
			set => SetProperty(ref _threatPersistanceMemory, value);
		}

		[Ordinal(9)] 
		[RED("hasBeenSeenByPlayer")] 
		public CBool HasBeenSeenByPlayer
		{
			get => GetProperty(ref _hasBeenSeenByPlayer);
			set => SetProperty(ref _hasBeenSeenByPlayer, value);
		}

		[Ordinal(10)] 
		[RED("canBeAddedToBossHealthbar")] 
		public CBool CanBeAddedToBossHealthbar
		{
			get => GetProperty(ref _canBeAddedToBossHealthbar);
			set => SetProperty(ref _canBeAddedToBossHealthbar, value);
		}

		[Ordinal(11)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}
	}
}
