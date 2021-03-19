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

		[Ordinal(4)] 
		[RED("droppedThreatData")] 
		public DroppedThreatData DroppedThreatData
		{
			get => GetProperty(ref _droppedThreatData);
			set => SetProperty(ref _droppedThreatData, value);
		}

		[Ordinal(5)] 
		[RED("trackedCombatSquads")] 
		public CArray<CHandle<AICombatSquadScriptInterface>> TrackedCombatSquads
		{
			get => GetProperty(ref _trackedCombatSquads);
			set => SetProperty(ref _trackedCombatSquads, value);
		}

		[Ordinal(6)] 
		[RED("trackedCombatSquadsCounters")] 
		public CArray<CInt32> TrackedCombatSquadsCounters
		{
			get => GetProperty(ref _trackedCombatSquadsCounters);
			set => SetProperty(ref _trackedCombatSquadsCounters, value);
		}

		[Ordinal(7)] 
		[RED("threatPersistanceMemory")] 
		public ThreatPersistanceMemory ThreatPersistanceMemory
		{
			get => GetProperty(ref _threatPersistanceMemory);
			set => SetProperty(ref _threatPersistanceMemory, value);
		}

		public TargetTrackingExtension(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
