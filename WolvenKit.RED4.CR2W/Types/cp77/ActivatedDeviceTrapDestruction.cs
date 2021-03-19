using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceTrapDestruction : ActivatedDeviceTrap
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
		private wCHandle<IScriptable> _lastEntityHit;
		private CFloat _timeToActivatePhysics;

		[Ordinal(95)] 
		[RED("physicalMeshNames")] 
		public CArray<CName> PhysicalMeshNames
		{
			get => GetProperty(ref _physicalMeshNames);
			set => SetProperty(ref _physicalMeshNames, value);
		}

		[Ordinal(96)] 
		[RED("physicalMeshes")] 
		public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes
		{
			get => GetProperty(ref _physicalMeshes);
			set => SetProperty(ref _physicalMeshes, value);
		}

		[Ordinal(97)] 
		[RED("hideMeshNames")] 
		public CArray<CName> HideMeshNames
		{
			get => GetProperty(ref _hideMeshNames);
			set => SetProperty(ref _hideMeshNames, value);
		}

		[Ordinal(98)] 
		[RED("hideMeshes")] 
		public CArray<CHandle<entIPlacedComponent>> HideMeshes
		{
			get => GetProperty(ref _hideMeshes);
			set => SetProperty(ref _hideMeshes, value);
		}

		[Ordinal(99)] 
		[RED("hitColliderNames")] 
		public CArray<CName> HitColliderNames
		{
			get => GetProperty(ref _hitColliderNames);
			set => SetProperty(ref _hitColliderNames, value);
		}

		[Ordinal(100)] 
		[RED("hitColliders")] 
		public CArray<CHandle<entIPlacedComponent>> HitColliders
		{
			get => GetProperty(ref _hitColliders);
			set => SetProperty(ref _hitColliders, value);
		}

		[Ordinal(101)] 
		[RED("impulseVector")] 
		public Vector4 ImpulseVector
		{
			get => GetProperty(ref _impulseVector);
			set => SetProperty(ref _impulseVector, value);
		}

		[Ordinal(102)] 
		[RED("physicalMeshImpactVFX")] 
		public CArray<gameFxResource> PhysicalMeshImpactVFX
		{
			get => GetProperty(ref _physicalMeshImpactVFX);
			set => SetProperty(ref _physicalMeshImpactVFX, value);
		}

		[Ordinal(103)] 
		[RED("componentsToEnableNames")] 
		public CArray<CName> ComponentsToEnableNames
		{
			get => GetProperty(ref _componentsToEnableNames);
			set => SetProperty(ref _componentsToEnableNames, value);
		}

		[Ordinal(104)] 
		[RED("componentsToEnable")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsToEnable
		{
			get => GetProperty(ref _componentsToEnable);
			set => SetProperty(ref _componentsToEnable, value);
		}

		[Ordinal(105)] 
		[RED("hitCount")] 
		public CInt32 HitCount
		{
			get => GetProperty(ref _hitCount);
			set => SetProperty(ref _hitCount, value);
		}

		[Ordinal(106)] 
		[RED("wasAttackPerformed")] 
		public CBool WasAttackPerformed
		{
			get => GetProperty(ref _wasAttackPerformed);
			set => SetProperty(ref _wasAttackPerformed, value);
		}

		[Ordinal(107)] 
		[RED("alreadyPlayedVFXComponents")] 
		public CArray<CName> AlreadyPlayedVFXComponents
		{
			get => GetProperty(ref _alreadyPlayedVFXComponents);
			set => SetProperty(ref _alreadyPlayedVFXComponents, value);
		}

		[Ordinal(108)] 
		[RED("shouldCheckPhysicalCollisions")] 
		public CBool ShouldCheckPhysicalCollisions
		{
			get => GetProperty(ref _shouldCheckPhysicalCollisions);
			set => SetProperty(ref _shouldCheckPhysicalCollisions, value);
		}

		[Ordinal(109)] 
		[RED("lastEntityHit")] 
		public wCHandle<IScriptable> LastEntityHit
		{
			get => GetProperty(ref _lastEntityHit);
			set => SetProperty(ref _lastEntityHit, value);
		}

		[Ordinal(110)] 
		[RED("timeToActivatePhysics")] 
		public CFloat TimeToActivatePhysics
		{
			get => GetProperty(ref _timeToActivatePhysics);
			set => SetProperty(ref _timeToActivatePhysics, value);
		}

		public ActivatedDeviceTrapDestruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
