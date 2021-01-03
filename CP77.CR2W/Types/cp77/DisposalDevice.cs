using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DisposalDevice : InteractiveDevice
	{
		[Ordinal(0)]  [RED("additionalMeshComponent")] public CHandle<entMeshComponent> AdditionalMeshComponent { get; set; }
		[Ordinal(1)]  [RED("currentDisposalSyncName")] public CName CurrentDisposalSyncName { get; set; }
		[Ordinal(2)]  [RED("currentKillSyncName")] public CName CurrentKillSyncName { get; set; }
		[Ordinal(3)]  [RED("distractionSoundName")] public CName DistractionSoundName { get; set; }
		[Ordinal(4)]  [RED("isNonlethal")] public CBool IsNonlethal { get; set; }
		[Ordinal(5)]  [RED("isReactToHit")] public CBool IsReactToHit { get; set; }
		[Ordinal(6)]  [RED("lethalTakedownComponentNames")] public CArray<CName> LethalTakedownComponentNames { get; set; }
		[Ordinal(7)]  [RED("lethalTakedownComponents")] public CArray<CHandle<entIPlacedComponent>> LethalTakedownComponents { get; set; }
		[Ordinal(8)]  [RED("lethalTakedownKillDelay")] public CFloat LethalTakedownKillDelay { get; set; }
		[Ordinal(9)]  [RED("npcBody")] public wCHandle<NPCPuppet> NpcBody { get; set; }
		[Ordinal(10)]  [RED("physicalMeshNames")] public CArray<CName> PhysicalMeshNames { get; set; }
		[Ordinal(11)]  [RED("physicalMeshes")] public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes { get; set; }
		[Ordinal(12)]  [RED("playerStateMachineBlackboard")] public CHandle<gameIBlackboard> PlayerStateMachineBlackboard { get; set; }
		[Ordinal(13)]  [RED("sideTriggerNames")] public CArray<CName> SideTriggerNames { get; set; }
		[Ordinal(14)]  [RED("triggerComponents")] public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents { get; set; }
		[Ordinal(15)]  [RED("workspotDuration")] public CFloat WorkspotDuration { get; set; }

		public DisposalDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
