using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDevice : BasicDistractionDevice
	{
		[Ordinal(90)]  [RED("numberOfComponentsToON")] public CInt32 NumberOfComponentsToON { get; set; }
		[Ordinal(91)]  [RED("numberOfComponentsToOFF")] public CInt32 NumberOfComponentsToOFF { get; set; }
		[Ordinal(92)]  [RED("indexesOfComponentsToOFF")] public CArray<CInt32> IndexesOfComponentsToOFF { get; set; }
		[Ordinal(93)]  [RED("shouldDistractionEnableCollider")] public CBool ShouldDistractionEnableCollider { get; set; }
		[Ordinal(94)]  [RED("shouldDistractionVFXstay")] public CBool ShouldDistractionVFXstay { get; set; }
		[Ordinal(95)]  [RED("loopAudioEvent")] public CName LoopAudioEvent { get; set; }
		[Ordinal(96)]  [RED("spawnedFxInstancesToKill")] public CArray<CHandle<gameFxInstance>> SpawnedFxInstancesToKill { get; set; }
		[Ordinal(97)]  [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }
		[Ordinal(98)]  [RED("collider")] public CHandle<entIPlacedComponent> Collider { get; set; }
		[Ordinal(99)]  [RED("distractionCollider")] public CHandle<entIPlacedComponent> DistractionCollider { get; set; }
		[Ordinal(100)]  [RED("numberOfReceivedHits")] public CInt32 NumberOfReceivedHits { get; set; }
		[Ordinal(101)]  [RED("devicePenetrationHealth")] public CFloat DevicePenetrationHealth { get; set; }
		[Ordinal(102)]  [RED("killedByExplosion")] public CBool KilledByExplosion { get; set; }
		[Ordinal(103)]  [RED("distractionTimeStart")] public CFloat DistractionTimeStart { get; set; }
		[Ordinal(104)]  [RED("isBroadcastingEnvironmentalHazardStim")] public CBool IsBroadcastingEnvironmentalHazardStim { get; set; }
		[Ordinal(105)]  [RED("componentsON")] public CArray<CHandle<entIPlacedComponent>> ComponentsON { get; set; }
		[Ordinal(106)]  [RED("componentsOFF")] public CArray<CHandle<entIPlacedComponent>> ComponentsOFF { get; set; }

		public ExplosiveDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
