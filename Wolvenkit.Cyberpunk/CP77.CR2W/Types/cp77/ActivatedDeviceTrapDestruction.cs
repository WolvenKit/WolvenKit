using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceTrapDestruction : ActivatedDeviceTrap
	{
		[Ordinal(0)]  [RED("alreadyPlayedVFXComponents")] public CArray<CName> AlreadyPlayedVFXComponents { get; set; }
		[Ordinal(1)]  [RED("componentsToEnable")] public CArray<CHandle<entIPlacedComponent>> ComponentsToEnable { get; set; }
		[Ordinal(2)]  [RED("componentsToEnableNames")] public CArray<CName> ComponentsToEnableNames { get; set; }
		[Ordinal(3)]  [RED("hideMeshNames")] public CArray<CName> HideMeshNames { get; set; }
		[Ordinal(4)]  [RED("hideMeshes")] public CArray<CHandle<entIPlacedComponent>> HideMeshes { get; set; }
		[Ordinal(5)]  [RED("hitColliderNames")] public CArray<CName> HitColliderNames { get; set; }
		[Ordinal(6)]  [RED("hitColliders")] public CArray<CHandle<entIPlacedComponent>> HitColliders { get; set; }
		[Ordinal(7)]  [RED("hitCount")] public CInt32 HitCount { get; set; }
		[Ordinal(8)]  [RED("impulseVector")] public Vector4 ImpulseVector { get; set; }
		[Ordinal(9)]  [RED("lastEntityHit")] public wCHandle<IScriptable> LastEntityHit { get; set; }
		[Ordinal(10)]  [RED("physicalMeshImpactVFX")] public CArray<gameFxResource> PhysicalMeshImpactVFX { get; set; }
		[Ordinal(11)]  [RED("physicalMeshNames")] public CArray<CName> PhysicalMeshNames { get; set; }
		[Ordinal(12)]  [RED("physicalMeshes")] public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes { get; set; }
		[Ordinal(13)]  [RED("shouldCheckPhysicalCollisions")] public CBool ShouldCheckPhysicalCollisions { get; set; }
		[Ordinal(14)]  [RED("timeToActivatePhysics")] public CFloat TimeToActivatePhysics { get; set; }
		[Ordinal(15)]  [RED("wasAttackPerformed")] public CBool WasAttackPerformed { get; set; }

		public ActivatedDeviceTrapDestruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
