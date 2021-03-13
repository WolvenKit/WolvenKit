using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDevice : BasicDistractionDevice
	{
		[Ordinal(99)] [RED("numberOfComponentsToON")] public CInt32 NumberOfComponentsToON { get; set; }
		[Ordinal(100)] [RED("numberOfComponentsToOFF")] public CInt32 NumberOfComponentsToOFF { get; set; }
		[Ordinal(101)] [RED("indexesOfComponentsToOFF")] public CArray<CInt32> IndexesOfComponentsToOFF { get; set; }
		[Ordinal(102)] [RED("shouldDistractionEnableCollider")] public CBool ShouldDistractionEnableCollider { get; set; }
		[Ordinal(103)] [RED("shouldDistractionVFXstay")] public CBool ShouldDistractionVFXstay { get; set; }
		[Ordinal(104)] [RED("loopAudioEvent")] public CName LoopAudioEvent { get; set; }
		[Ordinal(105)] [RED("spawnedFxInstancesToKill")] public CArray<CHandle<gameFxInstance>> SpawnedFxInstancesToKill { get; set; }
		[Ordinal(106)] [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }
		[Ordinal(107)] [RED("collider")] public CHandle<entIPlacedComponent> Collider { get; set; }
		[Ordinal(108)] [RED("distractionCollider")] public CHandle<entIPlacedComponent> DistractionCollider { get; set; }
		[Ordinal(109)] [RED("numberOfReceivedHits")] public CInt32 NumberOfReceivedHits { get; set; }
		[Ordinal(110)] [RED("devicePenetrationHealth")] public CFloat DevicePenetrationHealth { get; set; }
		[Ordinal(111)] [RED("killedByExplosion")] public CBool KilledByExplosion { get; set; }
		[Ordinal(112)] [RED("distractionTimeStart")] public CFloat DistractionTimeStart { get; set; }
		[Ordinal(113)] [RED("isBroadcastingEnvironmentalHazardStim")] public CBool IsBroadcastingEnvironmentalHazardStim { get; set; }
		[Ordinal(114)] [RED("componentsON")] public CArray<CHandle<entIPlacedComponent>> ComponentsON { get; set; }
		[Ordinal(115)] [RED("componentsOFF")] public CArray<CHandle<entIPlacedComponent>> ComponentsOFF { get; set; }

		public ExplosiveDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
