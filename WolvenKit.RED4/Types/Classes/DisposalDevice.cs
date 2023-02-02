using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisposalDevice : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("additionalMeshComponent")] 
		public CHandle<entMeshComponent> AdditionalMeshComponent
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(95)] 
		[RED("npcBody")] 
		public CWeakHandle<NPCPuppet> NpcBody
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(96)] 
		[RED("playerStateMachineBlackboard")] 
		public CWeakHandle<gameIBlackboard> PlayerStateMachineBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(97)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(98)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>(value);
		}

		[Ordinal(99)] 
		[RED("currentDisposalSyncName")] 
		public CName CurrentDisposalSyncName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(100)] 
		[RED("currentKillSyncName")] 
		public CName CurrentKillSyncName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(101)] 
		[RED("isNonlethal")] 
		public CBool IsNonlethal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(102)] 
		[RED("physicalMeshNames")] 
		public CArray<CName> PhysicalMeshNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(103)] 
		[RED("physicalMeshes")] 
		public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes
		{
			get => GetPropertyValue<CArray<CHandle<entPhysicalMeshComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entPhysicalMeshComponent>>>(value);
		}

		[Ordinal(104)] 
		[RED("lethalTakedownKillDelay")] 
		public CFloat LethalTakedownKillDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(105)] 
		[RED("lethalTakedownComponentNames")] 
		public CArray<CName> LethalTakedownComponentNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(106)] 
		[RED("lethalTakedownComponents")] 
		public CArray<CHandle<entIPlacedComponent>> LethalTakedownComponents
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(107)] 
		[RED("isReactToHit")] 
		public CBool IsReactToHit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("distractionSoundName")] 
		public CName DistractionSoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(109)] 
		[RED("distractionSoundDuration")] 
		public CFloat DistractionSoundDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(110)] 
		[RED("workspotDuration")] 
		public CFloat WorkspotDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(111)] 
		[RED("OnTakedownChangedCallback")] 
		public CHandle<redCallbackObject> OnTakedownChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(112)] 
		[RED("OnCarryingChangedCallback")] 
		public CHandle<redCallbackObject> OnCarryingChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public DisposalDevice()
		{
			ControllerTypeName = "DisposalDeviceController";
			SideTriggerNames = new();
			TriggerComponents = new();
			CurrentDisposalSyncName = "disposalSyncSide1";
			CurrentKillSyncName = "killSyncSide1";
			PhysicalMeshNames = new();
			PhysicalMeshes = new();
			LethalTakedownKillDelay = 0.200000F;
			LethalTakedownComponentNames = new();
			LethalTakedownComponents = new();
			DistractionSoundName = "v_car_thorton_galena_horn";
			DistractionSoundDuration = 5.000000F;
			WorkspotDuration = 0.010000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
