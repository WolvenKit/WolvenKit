using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceTrapDestruction : ActivatedDeviceTrap
	{
		[Ordinal(86)]  [RED("physicalMeshNames")] public CArray<CName> PhysicalMeshNames { get; set; }
		[Ordinal(87)]  [RED("physicalMeshes")] public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes { get; set; }
		[Ordinal(88)]  [RED("hideMeshNames")] public CArray<CName> HideMeshNames { get; set; }
		[Ordinal(89)]  [RED("hideMeshes")] public CArray<CHandle<entIPlacedComponent>> HideMeshes { get; set; }
		[Ordinal(90)]  [RED("hitColliderNames")] public CArray<CName> HitColliderNames { get; set; }
		[Ordinal(91)]  [RED("hitColliders")] public CArray<CHandle<entIPlacedComponent>> HitColliders { get; set; }
		[Ordinal(92)]  [RED("impulseVector")] public Vector4 ImpulseVector { get; set; }
		[Ordinal(93)]  [RED("physicalMeshImpactVFX")] public CArray<gameFxResource> PhysicalMeshImpactVFX { get; set; }
		[Ordinal(94)]  [RED("componentsToEnableNames")] public CArray<CName> ComponentsToEnableNames { get; set; }
		[Ordinal(95)]  [RED("componentsToEnable")] public CArray<CHandle<entIPlacedComponent>> ComponentsToEnable { get; set; }
		[Ordinal(96)]  [RED("hitCount")] public CInt32 HitCount { get; set; }
		[Ordinal(97)]  [RED("wasAttackPerformed")] public CBool WasAttackPerformed { get; set; }
		[Ordinal(98)]  [RED("alreadyPlayedVFXComponents")] public CArray<CName> AlreadyPlayedVFXComponents { get; set; }
		[Ordinal(99)]  [RED("shouldCheckPhysicalCollisions")] public CBool ShouldCheckPhysicalCollisions { get; set; }
		[Ordinal(100)]  [RED("lastEntityHit")] public wCHandle<IScriptable> LastEntityHit { get; set; }
		[Ordinal(101)]  [RED("timeToActivatePhysics")] public CFloat TimeToActivatePhysics { get; set; }

		public ActivatedDeviceTrapDestruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
