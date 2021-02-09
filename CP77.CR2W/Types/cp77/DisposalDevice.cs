using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DisposalDevice : InteractiveDevice
	{
		[Ordinal(84)]  [RED("additionalMeshComponent")] public CHandle<entMeshComponent> AdditionalMeshComponent { get; set; }
		[Ordinal(85)]  [RED("npcBody")] public wCHandle<NPCPuppet> NpcBody { get; set; }
		[Ordinal(86)]  [RED("playerStateMachineBlackboard")] public CHandle<gameIBlackboard> PlayerStateMachineBlackboard { get; set; }
		[Ordinal(87)]  [RED("sideTriggerNames")] public CArray<CName> SideTriggerNames { get; set; }
		[Ordinal(88)]  [RED("triggerComponents")] public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents { get; set; }
		[Ordinal(89)]  [RED("currentDisposalSyncName")] public CName CurrentDisposalSyncName { get; set; }
		[Ordinal(90)]  [RED("currentKillSyncName")] public CName CurrentKillSyncName { get; set; }
		[Ordinal(91)]  [RED("isNonlethal")] public CBool IsNonlethal { get; set; }
		[Ordinal(92)]  [RED("physicalMeshNames")] public CArray<CName> PhysicalMeshNames { get; set; }
		[Ordinal(93)]  [RED("physicalMeshes")] public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes { get; set; }
		[Ordinal(94)]  [RED("lethalTakedownKillDelay")] public CFloat LethalTakedownKillDelay { get; set; }
		[Ordinal(95)]  [RED("lethalTakedownComponentNames")] public CArray<CName> LethalTakedownComponentNames { get; set; }
		[Ordinal(96)]  [RED("lethalTakedownComponents")] public CArray<CHandle<entIPlacedComponent>> LethalTakedownComponents { get; set; }
		[Ordinal(97)]  [RED("isReactToHit")] public CBool IsReactToHit { get; set; }
		[Ordinal(98)]  [RED("distractionSoundName")] public CName DistractionSoundName { get; set; }
		[Ordinal(99)]  [RED("workspotDuration")] public CFloat WorkspotDuration { get; set; }

		public DisposalDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
