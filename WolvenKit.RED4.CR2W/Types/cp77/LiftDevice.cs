using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftDevice : InteractiveMasterDevice
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

		[Ordinal(93)] 
		[RED("advertismentNames")] 
		public CArray<CName> AdvertismentNames
		{
			get => GetProperty(ref _advertismentNames);
			set => SetProperty(ref _advertismentNames, value);
		}

		[Ordinal(94)] 
		[RED("advertisments")] 
		public CArray<CHandle<entIPlacedComponent>> Advertisments
		{
			get => GetProperty(ref _advertisments);
			set => SetProperty(ref _advertisments, value);
		}

		[Ordinal(95)] 
		[RED("movingPlatform")] 
		public CHandle<gameMovingPlatform> MovingPlatform
		{
			get => GetProperty(ref _movingPlatform);
			set => SetProperty(ref _movingPlatform, value);
		}

		[Ordinal(96)] 
		[RED("floors")] 
		public CArray<ElevatorFloorSetup> Floors
		{
			get => GetProperty(ref _floors);
			set => SetProperty(ref _floors, value);
		}

		[Ordinal(97)] 
		[RED("QuestSafeguardColliders")] 
		public CArray<CHandle<entIPlacedComponent>> QuestSafeguardColliders
		{
			get => GetProperty(ref _questSafeguardColliders);
			set => SetProperty(ref _questSafeguardColliders, value);
		}

		[Ordinal(98)] 
		[RED("QuestSafeguardColliderNames")] 
		public CArray<CName> QuestSafeguardColliderNames
		{
			get => GetProperty(ref _questSafeguardColliderNames);
			set => SetProperty(ref _questSafeguardColliderNames, value);
		}

		[Ordinal(99)] 
		[RED("frontDoorOccluder")] 
		public CHandle<entIPlacedComponent> FrontDoorOccluder
		{
			get => GetProperty(ref _frontDoorOccluder);
			set => SetProperty(ref _frontDoorOccluder, value);
		}

		[Ordinal(100)] 
		[RED("backDoorOccluder")] 
		public CHandle<entIPlacedComponent> BackDoorOccluder
		{
			get => GetProperty(ref _backDoorOccluder);
			set => SetProperty(ref _backDoorOccluder, value);
		}

		[Ordinal(101)] 
		[RED("radioMesh")] 
		public CHandle<entIPlacedComponent> RadioMesh
		{
			get => GetProperty(ref _radioMesh);
			set => SetProperty(ref _radioMesh, value);
		}

		[Ordinal(102)] 
		[RED("radioDestroyed")] 
		public CHandle<entIPlacedComponent> RadioDestroyed
		{
			get => GetProperty(ref _radioDestroyed);
			set => SetProperty(ref _radioDestroyed, value);
		}

		[Ordinal(103)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetProperty(ref _offMeshConnectionComponent);
			set => SetProperty(ref _offMeshConnectionComponent, value);
		}

		[Ordinal(104)] 
		[RED("isLoadPerformed")] 
		public CBool IsLoadPerformed
		{
			get => GetProperty(ref _isLoadPerformed);
			set => SetProperty(ref _isLoadPerformed, value);
		}

		public LiftDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
