using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExplosiveDevice : BasicDistractionDevice
	{
		[Ordinal(106)] 
		[RED("numberOfComponentsToON")] 
		public CInt32 NumberOfComponentsToON
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(107)] 
		[RED("numberOfComponentsToOFF")] 
		public CInt32 NumberOfComponentsToOFF
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(108)] 
		[RED("indexesOfComponentsToOFF")] 
		public CArray<CInt32> IndexesOfComponentsToOFF
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(109)] 
		[RED("shouldDistractionEnableCollider")] 
		public CBool ShouldDistractionEnableCollider
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("shouldDistractionVFXstay")] 
		public CBool ShouldDistractionVFXstay
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("loopAudioEvent")] 
		public CName LoopAudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(112)] 
		[RED("spawnedFxInstancesToKill")] 
		public CArray<CHandle<gameFxInstance>> SpawnedFxInstancesToKill
		{
			get => GetPropertyValue<CArray<CHandle<gameFxInstance>>>();
			set => SetPropertyValue<CArray<CHandle<gameFxInstance>>>(value);
		}

		[Ordinal(113)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(114)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(115)] 
		[RED("distractionCollider")] 
		public CHandle<entIPlacedComponent> DistractionCollider
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(116)] 
		[RED("numberOfReceivedHits")] 
		public CInt32 NumberOfReceivedHits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(117)] 
		[RED("devicePenetrationHealth")] 
		public CFloat DevicePenetrationHealth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(118)] 
		[RED("killedByExplosion")] 
		public CBool KilledByExplosion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(119)] 
		[RED("distractionTimeStart")] 
		public CFloat DistractionTimeStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(120)] 
		[RED("isBroadcastingEnvironmentalHazardStim")] 
		public CBool IsBroadcastingEnvironmentalHazardStim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(121)] 
		[RED("explodedByQuickhack")] 
		public CBool ExplodedByQuickhack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(122)] 
		[RED("switchAppearanceOnExplosion")] 
		public CBool SwitchAppearanceOnExplosion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(123)] 
		[RED("explodedAppearanceName")] 
		public CName ExplodedAppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(124)] 
		[RED("componentsON")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsON
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(125)] 
		[RED("componentsOFF")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsOFF
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		public ExplosiveDevice()
		{
			ControllerTypeName = "ExplosiveDeviceController";
			IndexesOfComponentsToOFF = new();
			SpawnedFxInstancesToKill = new();
			ComponentsON = new();
			ComponentsOFF = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
