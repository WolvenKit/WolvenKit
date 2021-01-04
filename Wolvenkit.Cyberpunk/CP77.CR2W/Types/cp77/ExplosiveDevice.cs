using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDevice : BasicDistractionDevice
	{
		[Ordinal(0)]  [RED("collider")] public CHandle<entIPlacedComponent> Collider { get; set; }
		[Ordinal(1)]  [RED("componentsOFF")] public CArray<CHandle<entIPlacedComponent>> ComponentsOFF { get; set; }
		[Ordinal(2)]  [RED("componentsON")] public CArray<CHandle<entIPlacedComponent>> ComponentsON { get; set; }
		[Ordinal(3)]  [RED("devicePenetrationHealth")] public CFloat DevicePenetrationHealth { get; set; }
		[Ordinal(4)]  [RED("distractionCollider")] public CHandle<entIPlacedComponent> DistractionCollider { get; set; }
		[Ordinal(5)]  [RED("distractionTimeStart")] public CFloat DistractionTimeStart { get; set; }
		[Ordinal(6)]  [RED("indexesOfComponentsToOFF")] public CArray<CInt32> IndexesOfComponentsToOFF { get; set; }
		[Ordinal(7)]  [RED("isBroadcastingEnvironmentalHazardStim")] public CBool IsBroadcastingEnvironmentalHazardStim { get; set; }
		[Ordinal(8)]  [RED("killedByExplosion")] public CBool KilledByExplosion { get; set; }
		[Ordinal(9)]  [RED("loopAudioEvent")] public CName LoopAudioEvent { get; set; }
		[Ordinal(10)]  [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }
		[Ordinal(11)]  [RED("numberOfComponentsToOFF")] public CInt32 NumberOfComponentsToOFF { get; set; }
		[Ordinal(12)]  [RED("numberOfComponentsToON")] public CInt32 NumberOfComponentsToON { get; set; }
		[Ordinal(13)]  [RED("numberOfReceivedHits")] public CInt32 NumberOfReceivedHits { get; set; }
		[Ordinal(14)]  [RED("shouldDistractionEnableCollider")] public CBool ShouldDistractionEnableCollider { get; set; }
		[Ordinal(15)]  [RED("shouldDistractionVFXstay")] public CBool ShouldDistractionVFXstay { get; set; }
		[Ordinal(16)]  [RED("spawnedFxInstancesToKill")] public CArray<CHandle<gameFxInstance>> SpawnedFxInstancesToKill { get; set; }

		public ExplosiveDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
