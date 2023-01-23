using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleComponentPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("defaultStateSet")] 
		public CBool DefaultStateSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("stateModifiedByQuest")] 
		public CBool StateModifiedByQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(106)] 
		[RED("playerVehicle")] 
		public CBool PlayerVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(107)] 
		[RED("npcOccupiedSlots")] 
		public CArray<CName> NpcOccupiedSlots
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(108)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("isStolen")] 
		public CBool IsStolen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("crystalDomeQuestModified")] 
		public CBool CrystalDomeQuestModified
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("crystalDomeQuestState")] 
		public CBool CrystalDomeQuestState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("crystalDomeState")] 
		public CBool CrystalDomeState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(113)] 
		[RED("visualDestructionSet")] 
		public CBool VisualDestructionSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(114)] 
		[RED("visualDestructionNeeded")] 
		public CBool VisualDestructionNeeded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(115)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(116)] 
		[RED("submerged")] 
		public CBool Submerged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("sirenOn")] 
		public CBool SirenOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(118)] 
		[RED("sirenSoundOn")] 
		public CBool SirenSoundOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(119)] 
		[RED("sirenLightsOn")] 
		public CBool SirenLightsOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(120)] 
		[RED("anyDoorOpen")] 
		public CBool AnyDoorOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(121)] 
		[RED("previousInteractionState")] 
		public CArray<TemporaryDoorState> PreviousInteractionState
		{
			get => GetPropertyValue<CArray<TemporaryDoorState>>();
			set => SetPropertyValue<CArray<TemporaryDoorState>>(value);
		}

		[Ordinal(122)] 
		[RED("thrusterState")] 
		public CBool ThrusterState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(123)] 
		[RED("uiQuestModified")] 
		public CBool UiQuestModified
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(124)] 
		[RED("uiState")] 
		public CBool UiState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(125)] 
		[RED("vehicleSkillChecks")] 
		public CHandle<EngDemoContainer> VehicleSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(126)] 
		[RED("ready")] 
		public CBool Ready
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(127)] 
		[RED("isPlayerPerformingBodyDisposal")] 
		public CBool IsPlayerPerformingBodyDisposal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(128)] 
		[RED("submergedTimestamp")] 
		public CFloat SubmergedTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(129)] 
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

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
