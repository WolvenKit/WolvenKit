using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceTrapDestruction : ActivatedDeviceTrap
	{
		private CArray<CName> _physicalMeshNames;
		private CArray<CHandle<entPhysicalMeshComponent>> _physicalMeshes;
		private CArray<CName> _hideMeshNames;
		private CArray<CHandle<entIPlacedComponent>> _hideMeshes;
		private CArray<CName> _hitColliderNames;
		private CArray<CHandle<entIPlacedComponent>> _hitColliders;
		private Vector4 _impulseVector;
		private CArray<gameFxResource> _physicalMeshImpactVFX;
		private CArray<CName> _componentsToEnableNames;
		private CArray<CHandle<entIPlacedComponent>> _componentsToEnable;
		private CInt32 _hitCount;
		private CBool _wasAttackPerformed;
		private CArray<CName> _alreadyPlayedVFXComponents;
		private CBool _shouldCheckPhysicalCollisions;
		private CWeakHandle<IScriptable> _lastEntityHit;
		private CFloat _timeToActivatePhysics;

		[Ordinal(99)] 
		[RED("physicalMeshNames")] 
		public CArray<CName> PhysicalMeshNames
		{
			get => GetProperty(ref _physicalMeshNames);
			set => SetProperty(ref _physicalMeshNames, value);
		}

		[Ordinal(100)] 
		[RED("physicalMeshes")] 
		public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes
		{
			get => GetProperty(ref _physicalMeshes);
			set => SetProperty(ref _physicalMeshes, value);
		}

		[Ordinal(101)] 
		[RED("hideMeshNames")] 
		public CArray<CName> HideMeshNames
		{
			get => GetProperty(ref _hideMeshNames);
			set => SetProperty(ref _hideMeshNames, value);
		}

		[Ordinal(102)] 
		[RED("hideMeshes")] 
		public CArray<CHandle<entIPlacedComponent>> HideMeshes
		{
			get => GetProperty(ref _hideMeshes);
			set => SetProperty(ref _hideMeshes, value);
		}

		[Ordinal(103)] 
		[RED("hitColliderNames")] 
		public CArray<CName> HitColliderNames
		{
			get => GetProperty(ref _hitColliderNames);
			set => SetProperty(ref _hitColliderNames, value);
		}

		[Ordinal(104)] 
		[RED("hitColliders")] 
		public CArray<CHandle<entIPlacedComponent>> HitColliders
		{
			get => GetProperty(ref _hitColliders);
			set => SetProperty(ref _hitColliders, value);
		}

		[Ordinal(105)] 
		[RED("impulseVector")] 
		public Vector4 ImpulseVector
		{
			get => GetProperty(ref _impulseVector);
			set => SetProperty(ref _impulseVector, value);
		}

		[Ordinal(106)] 
		[RED("physicalMeshImpactVFX")] 
		public CArray<gameFxResource> PhysicalMeshImpactVFX
		{
			get => GetProperty(ref _physicalMeshImpactVFX);
			set => SetProperty(ref _physicalMeshImpactVFX, value);
		}

		[Ordinal(107)] 
		[RED("componentsToEnableNames")] 
		public CArray<CName> ComponentsToEnableNames
		{
			get => GetProperty(ref _componentsToEnableNames);
			set => SetProperty(ref _componentsToEnableNames, value);
		}

		[Ordinal(108)] 
		[RED("componentsToEnable")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsToEnable
		{
			get => GetProperty(ref _componentsToEnable);
			set => SetProperty(ref _componentsToEnable, value);
		}

		[Ordinal(109)] 
		[RED("hitCount")] 
		public CInt32 HitCount
		{
			get => GetProperty(ref _hitCount);
			set => SetProperty(ref _hitCount, value);
		}

		[Ordinal(110)] 
		[RED("wasAttackPerformed")] 
		public CBool WasAttackPerformed
		{
			get => GetProperty(ref _wasAttackPerformed);
			set => SetProperty(ref _wasAttackPerformed, value);
		}

		[Ordinal(111)] 
		[RED("alreadyPlayedVFXComponents")] 
		public CArray<CName> AlreadyPlayedVFXComponents
		{
			get => GetProperty(ref _alreadyPlayedVFXComponents);
			set => SetProperty(ref _alreadyPlayedVFXComponents, value);
		}

		[Ordinal(112)] 
		[RED("shouldCheckPhysicalCollisions")] 
		public CBool ShouldCheckPhysicalCollisions
		{
			get => GetProperty(ref _shouldCheckPhysicalCollisions);
			set => SetProperty(ref _shouldCheckPhysicalCollisions, value);
		}

		[Ordinal(113)] 
		[RED("lastEntityHit")] 
		public CWeakHandle<IScriptable> LastEntityHit
		{
			get => GetProperty(ref _lastEntityHit);
			set => SetProperty(ref _lastEntityHit, value);
		}

		[Ordinal(114)] 
		[RED("timeToActivatePhysics")] 
		public CFloat TimeToActivatePhysics
		{
			get => GetProperty(ref _timeToActivatePhysics);
			set => SetProperty(ref _timeToActivatePhysics, value);
		}
	}
}
