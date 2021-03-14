using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleComponentPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("defaultStateSet")] public CBool DefaultStateSet { get; set; }
		[Ordinal(104)] [RED("stateModifiedByQuest")] public CBool StateModifiedByQuest { get; set; }
		[Ordinal(105)] [RED("playerVehicle")] public CBool PlayerVehicle { get; set; }
		[Ordinal(106)] [RED("npcOccupiedSlots")] public CArray<CName> NpcOccupiedSlots { get; set; }
		[Ordinal(107)] [RED("isDestroyed")] public CBool IsDestroyed { get; set; }
		[Ordinal(108)] [RED("isStolen")] public CBool IsStolen { get; set; }
		[Ordinal(109)] [RED("crystalDomeQuestModified")] public CBool CrystalDomeQuestModified { get; set; }
		[Ordinal(110)] [RED("crystalDomeQuestState")] public CBool CrystalDomeQuestState { get; set; }
		[Ordinal(111)] [RED("crystalDomeState")] public CBool CrystalDomeState { get; set; }
		[Ordinal(112)] [RED("visualDestructionSet")] public CBool VisualDestructionSet { get; set; }
		[Ordinal(113)] [RED("visualDestructionNeeded")] public CBool VisualDestructionNeeded { get; set; }
		[Ordinal(114)] [RED("exploded")] public CBool Exploded { get; set; }
		[Ordinal(115)] [RED("sirenOn")] public CBool SirenOn { get; set; }
		[Ordinal(116)] [RED("sirenSoundOn")] public CBool SirenSoundOn { get; set; }
		[Ordinal(117)] [RED("sirenLightsOn")] public CBool SirenLightsOn { get; set; }
		[Ordinal(118)] [RED("anyDoorOpen")] public CBool AnyDoorOpen { get; set; }
		[Ordinal(119)] [RED("previousInteractionState")] public CArray<TemporaryDoorState> PreviousInteractionState { get; set; }
		[Ordinal(120)] [RED("thrusterState")] public CBool ThrusterState { get; set; }
		[Ordinal(121)] [RED("uiQuestModified")] public CBool UiQuestModified { get; set; }
		[Ordinal(122)] [RED("uiState")] public CBool UiState { get; set; }
		[Ordinal(123)] [RED("vehicleSkillChecks")] public CHandle<EngDemoContainer> VehicleSkillChecks { get; set; }
		[Ordinal(124)] [RED("ready")] public CBool Ready { get; set; }
		[Ordinal(125)] [RED("isPlayerPerformingBodyDisposal")] public CBool IsPlayerPerformingBodyDisposal { get; set; }
		[Ordinal(126)] [RED("vehicleControllerPS")] public CHandle<vehicleControllerPS> VehicleControllerPS { get; set; }

		public VehicleComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
