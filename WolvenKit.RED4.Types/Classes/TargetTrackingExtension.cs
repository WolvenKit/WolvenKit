using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetTrackingExtension : AITargetTrackerComponent
	{
		[Ordinal(5)] 
		[RED("droppedThreatData")] 
		public DroppedThreatData DroppedThreatData
		{
			get => GetPropertyValue<DroppedThreatData>();
			set => SetPropertyValue<DroppedThreatData>(value);
		}

		[Ordinal(6)] 
		[RED("trackedCombatSquads")] 
		public CArray<CHandle<AICombatSquadScriptInterface>> TrackedCombatSquads
		{
			get => GetPropertyValue<CArray<CHandle<AICombatSquadScriptInterface>>>();
			set => SetPropertyValue<CArray<CHandle<AICombatSquadScriptInterface>>>(value);
		}

		[Ordinal(7)] 
		[RED("trackedCombatSquadsCounters")] 
		public CArray<CInt32> TrackedCombatSquadsCounters
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(8)] 
		[RED("threatPersistanceMemory")] 
		public ThreatPersistanceMemory ThreatPersistanceMemory
		{
			get => GetPropertyValue<ThreatPersistanceMemory>();
			set => SetPropertyValue<ThreatPersistanceMemory>(value);
		}

		[Ordinal(9)] 
		[RED("hasBeenSeenByPlayer")] 
		public CBool HasBeenSeenByPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("canBeAddedToBossHealthbar")] 
		public CBool CanBeAddedToBossHealthbar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public TargetTrackingExtension()
		{
			DroppedThreatData = new() { Position = new() };
			TrackedCombatSquads = new();
			TrackedCombatSquadsCounters = new();
			ThreatPersistanceMemory = new() { Threats = new(), IsPersistent = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
