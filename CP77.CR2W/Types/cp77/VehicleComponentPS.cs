using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleComponentPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("anyDoorOpen")] public CBool AnyDoorOpen { get; set; }
		[Ordinal(1)]  [RED("crystalDomeQuestModified")] public CBool CrystalDomeQuestModified { get; set; }
		[Ordinal(2)]  [RED("crystalDomeQuestState")] public CBool CrystalDomeQuestState { get; set; }
		[Ordinal(3)]  [RED("crystalDomeState")] public CBool CrystalDomeState { get; set; }
		[Ordinal(4)]  [RED("defaultStateSet")] public CBool DefaultStateSet { get; set; }
		[Ordinal(5)]  [RED("exploded")] public CBool Exploded { get; set; }
		[Ordinal(6)]  [RED("isDestroyed")] public CBool IsDestroyed { get; set; }
		[Ordinal(7)]  [RED("isPlayerPerformingBodyDisposal")] public CBool IsPlayerPerformingBodyDisposal { get; set; }
		[Ordinal(8)]  [RED("isStolen")] public CBool IsStolen { get; set; }
		[Ordinal(9)]  [RED("npcOccupiedSlots")] public CArray<CName> NpcOccupiedSlots { get; set; }
		[Ordinal(10)]  [RED("playerVehicle")] public CBool PlayerVehicle { get; set; }
		[Ordinal(11)]  [RED("previousInteractionState")] public CArray<TemporaryDoorState> PreviousInteractionState { get; set; }
		[Ordinal(12)]  [RED("ready")] public CBool Ready { get; set; }
		[Ordinal(13)]  [RED("sirenLightsOn")] public CBool SirenLightsOn { get; set; }
		[Ordinal(14)]  [RED("sirenOn")] public CBool SirenOn { get; set; }
		[Ordinal(15)]  [RED("sirenSoundOn")] public CBool SirenSoundOn { get; set; }
		[Ordinal(16)]  [RED("stateModifiedByQuest")] public CBool StateModifiedByQuest { get; set; }
		[Ordinal(17)]  [RED("thrusterState")] public CBool ThrusterState { get; set; }
		[Ordinal(18)]  [RED("uiQuestModified")] public CBool UiQuestModified { get; set; }
		[Ordinal(19)]  [RED("uiState")] public CBool UiState { get; set; }
		[Ordinal(20)]  [RED("vehicleControllerPS")] public CHandle<vehicleControllerPS> VehicleControllerPS { get; set; }
		[Ordinal(21)]  [RED("vehicleSkillChecks")] public CHandle<EngDemoContainer> VehicleSkillChecks { get; set; }
		[Ordinal(22)]  [RED("visualDestructionNeeded")] public CBool VisualDestructionNeeded { get; set; }
		[Ordinal(23)]  [RED("visualDestructionSet")] public CBool VisualDestructionSet { get; set; }

		public VehicleComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
