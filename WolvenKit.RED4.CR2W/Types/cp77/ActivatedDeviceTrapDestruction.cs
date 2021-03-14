using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceTrapDestruction : ActivatedDeviceTrap
	{
		[Ordinal(95)] [RED("physicalMeshNames")] public CArray<CName> PhysicalMeshNames { get; set; }
		[Ordinal(96)] [RED("physicalMeshes")] public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes { get; set; }
		[Ordinal(97)] [RED("hideMeshNames")] public CArray<CName> HideMeshNames { get; set; }
		[Ordinal(98)] [RED("hideMeshes")] public CArray<CHandle<entIPlacedComponent>> HideMeshes { get; set; }
		[Ordinal(99)] [RED("hitColliderNames")] public CArray<CName> HitColliderNames { get; set; }
		[Ordinal(100)] [RED("hitColliders")] public CArray<CHandle<entIPlacedComponent>> HitColliders { get; set; }
		[Ordinal(101)] [RED("impulseVector")] public Vector4 ImpulseVector { get; set; }
		[Ordinal(102)] [RED("physicalMeshImpactVFX")] public CArray<gameFxResource> PhysicalMeshImpactVFX { get; set; }
		[Ordinal(103)] [RED("componentsToEnableNames")] public CArray<CName> ComponentsToEnableNames { get; set; }
		[Ordinal(104)] [RED("componentsToEnable")] public CArray<CHandle<entIPlacedComponent>> ComponentsToEnable { get; set; }
		[Ordinal(105)] [RED("hitCount")] public CInt32 HitCount { get; set; }
		[Ordinal(106)] [RED("wasAttackPerformed")] public CBool WasAttackPerformed { get; set; }
		[Ordinal(107)] [RED("alreadyPlayedVFXComponents")] public CArray<CName> AlreadyPlayedVFXComponents { get; set; }
		[Ordinal(108)] [RED("shouldCheckPhysicalCollisions")] public CBool ShouldCheckPhysicalCollisions { get; set; }
		[Ordinal(109)] [RED("lastEntityHit")] public wCHandle<IScriptable> LastEntityHit { get; set; }
		[Ordinal(110)] [RED("timeToActivatePhysics")] public CFloat TimeToActivatePhysics { get; set; }

		public ActivatedDeviceTrapDestruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
