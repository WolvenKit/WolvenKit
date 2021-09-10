using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LiftDevice : InteractiveMasterDevice
	{
		[Ordinal(97)] 
		[RED("advertismentNames")] 
		public CArray<CName> AdvertismentNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(98)] 
		[RED("advertisments")] 
		public CArray<CHandle<entIPlacedComponent>> Advertisments
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(99)] 
		[RED("movingPlatform")] 
		public CHandle<gameMovingPlatform> MovingPlatform
		{
			get => GetPropertyValue<CHandle<gameMovingPlatform>>();
			set => SetPropertyValue<CHandle<gameMovingPlatform>>(value);
		}

		[Ordinal(100)] 
		[RED("floors")] 
		public CArray<ElevatorFloorSetup> Floors
		{
			get => GetPropertyValue<CArray<ElevatorFloorSetup>>();
			set => SetPropertyValue<CArray<ElevatorFloorSetup>>(value);
		}

		[Ordinal(101)] 
		[RED("QuestSafeguardColliders")] 
		public CArray<CHandle<entIPlacedComponent>> QuestSafeguardColliders
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(102)] 
		[RED("QuestSafeguardColliderNames")] 
		public CArray<CName> QuestSafeguardColliderNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(103)] 
		[RED("frontDoorOccluder")] 
		public CHandle<entIPlacedComponent> FrontDoorOccluder
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(104)] 
		[RED("backDoorOccluder")] 
		public CHandle<entIPlacedComponent> BackDoorOccluder
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(105)] 
		[RED("radioMesh")] 
		public CHandle<entIPlacedComponent> RadioMesh
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(106)] 
		[RED("radioDestroyed")] 
		public CHandle<entIPlacedComponent> RadioDestroyed
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(107)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		[Ordinal(108)] 
		[RED("isLoadPerformed")] 
		public CBool IsLoadPerformed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LiftDevice()
		{
			ControllerTypeName = "LiftController";
			AdvertismentNames = new();
			Advertisments = new();
			Floors = new();
			QuestSafeguardColliders = new();
			QuestSafeguardColliderNames = new();
		}
	}
}
