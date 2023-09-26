using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ServerNode : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("minWeaponCharge")] 
		public CFloat MinWeaponCharge
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(99)] 
		[RED("maxWeaponCharge")] 
		public CFloat MaxWeaponCharge
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(100)] 
		[RED("livePinMeshes")] 
		public CArray<CHandle<entMeshComponent>> LivePinMeshes
		{
			get => GetPropertyValue<CArray<CHandle<entMeshComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entMeshComponent>>>(value);
		}

		[Ordinal(101)] 
		[RED("deadPinMeshes")] 
		public CArray<CHandle<entMeshComponent>> DeadPinMeshes
		{
			get => GetPropertyValue<CArray<CHandle<entMeshComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entMeshComponent>>>(value);
		}

		[Ordinal(102)] 
		[RED("closedFrontPlates")] 
		public CArray<CHandle<entMeshComponent>> ClosedFrontPlates
		{
			get => GetPropertyValue<CArray<CHandle<entMeshComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entMeshComponent>>>(value);
		}

		[Ordinal(103)] 
		[RED("animatedFrontPlates")] 
		public CArray<CHandle<entMeshComponent>> AnimatedFrontPlates
		{
			get => GetPropertyValue<CArray<CHandle<entMeshComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entMeshComponent>>>(value);
		}

		[Ordinal(104)] 
		[RED("numOfPins")] 
		public CInt32 NumOfPins
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(105)] 
		[RED("alivePins")] 
		public CInt32 AlivePins
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(106)] 
		[RED("pinIndices")] 
		public CArray<CInt32> PinIndices
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(107)] 
		[RED("nodesDestroyedInTotalQuestFactName")] 
		public CName NodesDestroyedInTotalQuestFactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(108)] 
		[RED("animFeatureServer")] 
		public CHandle<AnimFeatureServer> AnimFeatureServer
		{
			get => GetPropertyValue<CHandle<AnimFeatureServer>>();
			set => SetPropertyValue<CHandle<AnimFeatureServer>>(value);
		}

		[Ordinal(109)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetPropertyValue<CHandle<gameStatPoolsSystem>>();
			set => SetPropertyValue<CHandle<gameStatPoolsSystem>>(value);
		}

		[Ordinal(110)] 
		[RED("healthListener")] 
		public CHandle<ServerNodeHealthChangeListener> HealthListener
		{
			get => GetPropertyValue<CHandle<ServerNodeHealthChangeListener>>();
			set => SetPropertyValue<CHandle<ServerNodeHealthChangeListener>>(value);
		}

		[Ordinal(111)] 
		[RED("ventingFX")] 
		public CName VentingFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(112)] 
		[RED("damagedFX")] 
		public CName DamagedFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(113)] 
		[RED("destroyedMesh")] 
		public CHandle<entPhysicalMeshComponent> DestroyedMesh
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		public ServerNode()
		{
			ControllerTypeName = "ServerNodeController";
			LivePinMeshes = new();
			DeadPinMeshes = new();
			ClosedFrontPlates = new();
			AnimatedFrontPlates = new();
			NumOfPins = 12;
			AlivePins = 12;
			PinIndices = new();
			NodesDestroyedInTotalQuestFactName = "q303_03_server_nodes_destroyed";
			VentingFX = "venting";
			DamagedFX = "damage_state_01";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
