using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetTrackingExtension : AITargetTrackerComponent
	{
		private DroppedThreatData _droppedThreatData;
		private CArray<CHandle<AICombatSquadScriptInterface>> _trackedCombatSquads;
		private CArray<CInt32> _trackedCombatSquadsCounters;
		private ThreatPersistanceMemory _threatPersistanceMemory;
		private CBool _hasBeenSeenByPlayer;
		private CBool _canBeAddedToBossHealthbar;
		private wCHandle<gameObject> _playerPuppet;

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
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		public TargetTrackingExtension(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
