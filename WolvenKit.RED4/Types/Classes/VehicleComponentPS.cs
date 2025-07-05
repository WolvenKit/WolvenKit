using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleComponentPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("defaultStateSet")] 
		public CBool DefaultStateSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("stateModifiedByQuest")] 
		public CBool StateModifiedByQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("playerVehicle")] 
		public CBool PlayerVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("npcOccupiedSlots")] 
		public CArray<CName> NpcOccupiedSlots
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(111)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("isStolen")] 
		public CBool IsStolen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(113)] 
		[RED("crystalDomeQuestModified")] 
		public CBool CrystalDomeQuestModified
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(114)] 
		[RED("crystalDomeQuestState")] 
		public CBool CrystalDomeQuestState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(115)] 
		[RED("crystalDomeState")] 
		public CBool CrystalDomeState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(116)] 
		[RED("visualDestructionSet")] 
		public CBool VisualDestructionSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("visualDestructionNeeded")] 
		public CBool VisualDestructionNeeded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(118)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(119)] 
		[RED("submerged")] 
		public CBool Submerged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(120)] 
		[RED("sirenOn")] 
		public CBool SirenOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(121)] 
		[RED("sirenSoundOn")] 
		public CBool SirenSoundOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(122)] 
		[RED("sirenLightsOn")] 
		public CBool SirenLightsOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(123)] 
		[RED("isDefaultLightToggleSet")] 
		public CBool IsDefaultLightToggleSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(124)] 
		[RED("anyDoorOpen")] 
		public CBool AnyDoorOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(125)] 
		[RED("previousInteractionState")] 
		public CArray<TemporaryDoorState> PreviousInteractionState
		{
			get => GetPropertyValue<CArray<TemporaryDoorState>>();
			set => SetPropertyValue<CArray<TemporaryDoorState>>(value);
		}

		[Ordinal(126)] 
		[RED("thrusterState")] 
		public CBool ThrusterState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(127)] 
		[RED("uiQuestModified")] 
		public CBool UiQuestModified
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(128)] 
		[RED("uiState")] 
		public CBool UiState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(129)] 
		[RED("vehicleSkillChecks")] 
		public CHandle<EngDemoContainer> VehicleSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(130)] 
		[RED("controlStimShouldBeActive")] 
		public CBool ControlStimShouldBeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(131)] 
		[RED("controlStimRunning")] 
		public CBool ControlStimRunning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(132)] 
		[RED("vehicleApperanceCustomizationActive")] 
		public CBool VehicleApperanceCustomizationActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(133)] 
		[RED("vehicleApperanceCustomizationInDistanceTermination")] 
		public CBool VehicleApperanceCustomizationInDistanceTermination
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(134)] 
		[RED("vehicleAppearanceCustomizationBlockedByDamage")] 
		public CBool VehicleAppearanceCustomizationBlockedByDamage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(135)] 
		[RED("vehicleVisualCustomizationTemplate")] 
		public SavedVehicleVisualCustomizationTemplate VehicleVisualCustomizationTemplate
		{
			get => GetPropertyValue<SavedVehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<SavedVehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(136)] 
		[RED("vehicleApperanceDefinition")] 
		public vehicleVisualModdingDefinition VehicleApperanceDefinition
		{
			get => GetPropertyValue<vehicleVisualModdingDefinition>();
			set => SetPropertyValue<vehicleVisualModdingDefinition>(value);
		}

		[Ordinal(137)] 
		[RED("ready")] 
		public CBool Ready
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(138)] 
		[RED("isPlayerPerformingBodyDisposal")] 
		public CBool IsPlayerPerformingBodyDisposal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(139)] 
		[RED("submergedTimestamp")] 
		public CFloat SubmergedTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(140)] 
		[RED("vehicleControllerPS")] 
		public CHandle<vehicleControllerPS> VehicleControllerPS
		{
			get => GetPropertyValue<CHandle<vehicleControllerPS>>();
			set => SetPropertyValue<CHandle<vehicleControllerPS>>(value);
		}

		public VehicleComponentPS()
		{
			NpcOccupiedSlots = new();
			PreviousInteractionState = new();
			VehicleVisualCustomizationTemplate = new SavedVehicleVisualCustomizationTemplate { GenericData = new GenericTemplatePersistentData() };
			VehicleApperanceDefinition = new vehicleVisualModdingDefinition();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
