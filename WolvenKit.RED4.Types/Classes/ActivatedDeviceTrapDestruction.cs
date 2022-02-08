using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceTrapDestruction : ActivatedDeviceTrap
	{
		[Ordinal(99)] 
		[RED("physicalMeshNames")] 
		public CArray<CName> PhysicalMeshNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(100)] 
		[RED("physicalMeshes")] 
		public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes
		{
			get => GetPropertyValue<CArray<CHandle<entPhysicalMeshComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entPhysicalMeshComponent>>>(value);
		}

		[Ordinal(101)] 
		[RED("hideMeshNames")] 
		public CArray<CName> HideMeshNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(102)] 
		[RED("hideMeshes")] 
		public CArray<CHandle<entIPlacedComponent>> HideMeshes
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(103)] 
		[RED("hitColliderNames")] 
		public CArray<CName> HitColliderNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(104)] 
		[RED("hitColliders")] 
		public CArray<CHandle<entIPlacedComponent>> HitColliders
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(105)] 
		[RED("impulseVector")] 
		public Vector4 ImpulseVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(106)] 
		[RED("physicalMeshImpactVFX")] 
		public CArray<gameFxResource> PhysicalMeshImpactVFX
		{
			get => GetPropertyValue<CArray<gameFxResource>>();
			set => SetPropertyValue<CArray<gameFxResource>>(value);
		}

		[Ordinal(107)] 
		[RED("componentsToEnableNames")] 
		public CArray<CName> ComponentsToEnableNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(108)] 
		[RED("componentsToEnable")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsToEnable
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(109)] 
		[RED("hitCount")] 
		public CInt32 HitCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(110)] 
		[RED("wasAttackPerformed")] 
		public CBool WasAttackPerformed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("alreadyPlayedVFXComponents")] 
		public CArray<CName> AlreadyPlayedVFXComponents
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(112)] 
		[RED("shouldCheckPhysicalCollisions")] 
		public CBool ShouldCheckPhysicalCollisions
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(113)] 
		[RED("lastEntityHit")] 
		public CWeakHandle<IScriptable> LastEntityHit
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		[Ordinal(114)] 
		[RED("timeToActivatePhysics")] 
		public CFloat TimeToActivatePhysics
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ActivatedDeviceTrapDestruction()
		{
			PhysicalMeshNames = new();
			PhysicalMeshes = new();
			HideMeshNames = new();
			HideMeshes = new();
			HitColliderNames = new();
			HitColliders = new();
			ImpulseVector = new();
			PhysicalMeshImpactVFX = new();
			ComponentsToEnableNames = new();
			ComponentsToEnable = new();
			AlreadyPlayedVFXComponents = new();
		}
	}
}
