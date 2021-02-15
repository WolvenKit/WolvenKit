using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TargetTrackingExtension : AITargetTrackerComponent
	{
		[Ordinal(4)] [RED("droppedThreatData")] public DroppedThreatData DroppedThreatData { get; set; }
		[Ordinal(5)] [RED("trackedCombatSquads")] public CArray<CHandle<AICombatSquadScriptInterface>> TrackedCombatSquads { get; set; }
		[Ordinal(6)] [RED("trackedCombatSquadsCounters")] public CArray<CInt32> TrackedCombatSquadsCounters { get; set; }
		[Ordinal(7)] [RED("threatPersistanceMemory")] public ThreatPersistanceMemory ThreatPersistanceMemory { get; set; }

		public TargetTrackingExtension(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
