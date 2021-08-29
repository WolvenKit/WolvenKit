using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LiftDevice : InteractiveMasterDevice
	{
		private CArray<CName> _advertismentNames;
		private CArray<CHandle<entIPlacedComponent>> _advertisments;
		private CHandle<gameMovingPlatform> _movingPlatform;
		private CArray<ElevatorFloorSetup> _floors;
		private CArray<CHandle<entIPlacedComponent>> _questSafeguardColliders;
		private CArray<CName> _questSafeguardColliderNames;
		private CHandle<entIPlacedComponent> _frontDoorOccluder;
		private CHandle<entIPlacedComponent> _backDoorOccluder;
		private CHandle<entIPlacedComponent> _radioMesh;
		private CHandle<entIPlacedComponent> _radioDestroyed;
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionComponent;
		private CBool _isLoadPerformed;

		[Ordinal(97)] 
		[RED("advertismentNames")] 
		public CArray<CName> AdvertismentNames
		{
			get => GetProperty(ref _advertismentNames);
			set => SetProperty(ref _advertismentNames, value);
		}

		[Ordinal(98)] 
		[RED("advertisments")] 
		public CArray<CHandle<entIPlacedComponent>> Advertisments
		{
			get => GetProperty(ref _advertisments);
			set => SetProperty(ref _advertisments, value);
		}

		[Ordinal(99)] 
		[RED("movingPlatform")] 
		public CHandle<gameMovingPlatform> MovingPlatform
		{
			get => GetProperty(ref _movingPlatform);
			set => SetProperty(ref _movingPlatform, value);
		}

		[Ordinal(100)] 
		[RED("floors")] 
		public CArray<ElevatorFloorSetup> Floors
		{
			get => GetProperty(ref _floors);
			set => SetProperty(ref _floors, value);
		}

		[Ordinal(101)] 
		[RED("QuestSafeguardColliders")] 
		public CArray<CHandle<entIPlacedComponent>> QuestSafeguardColliders
		{
			get => GetProperty(ref _questSafeguardColliders);
			set => SetProperty(ref _questSafeguardColliders, value);
		}

		[Ordinal(102)] 
		[RED("QuestSafeguardColliderNames")] 
		public CArray<CName> QuestSafeguardColliderNames
		{
			get => GetProperty(ref _questSafeguardColliderNames);
			set => SetProperty(ref _questSafeguardColliderNames, value);
		}

		[Ordinal(103)] 
		[RED("frontDoorOccluder")] 
		public CHandle<entIPlacedComponent> FrontDoorOccluder
		{
			get => GetProperty(ref _frontDoorOccluder);
			set => SetProperty(ref _frontDoorOccluder, value);
		}

		[Ordinal(104)] 
		[RED("backDoorOccluder")] 
		public CHandle<entIPlacedComponent> BackDoorOccluder
		{
			get => GetProperty(ref _backDoorOccluder);
			set => SetProperty(ref _backDoorOccluder, value);
		}

		[Ordinal(105)] 
		[RED("radioMesh")] 
		public CHandle<entIPlacedComponent> RadioMesh
		{
			get => GetProperty(ref _radioMesh);
			set => SetProperty(ref _radioMesh, value);
		}

		[Ordinal(106)] 
		[RED("radioDestroyed")] 
		public CHandle<entIPlacedComponent> RadioDestroyed
		{
			get => GetProperty(ref _radioDestroyed);
			set => SetProperty(ref _radioDestroyed, value);
		}

		[Ordinal(107)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetProperty(ref _offMeshConnectionComponent);
			set => SetProperty(ref _offMeshConnectionComponent, value);
		}

		[Ordinal(108)] 
		[RED("isLoadPerformed")] 
		public CBool IsLoadPerformed
		{
			get => GetProperty(ref _isLoadPerformed);
			set => SetProperty(ref _isLoadPerformed, value);
		}
	}
}
