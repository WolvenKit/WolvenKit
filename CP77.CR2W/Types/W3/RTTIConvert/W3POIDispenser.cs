using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3POIDispenser : CGameplayEntity
	{
		[Ordinal(1)] [RED("pointsTag")] 		public CName PointsTag { get; set;}

		[Ordinal(2)] [RED("onExitDespawnAllAfter")] 		public CInt32 OnExitDespawnAllAfter { get; set;}

		[Ordinal(3)] [RED("shouldUseRandomRespawnTime")] 		public CBool ShouldUseRandomRespawnTime { get; set;}

		[Ordinal(4)] [RED("respawnInterval")] 		public CFloat RespawnInterval { get; set;}

		[Ordinal(5)] [RED("poiEntity")] 		public W3POIEntities PoiEntity { get; set;}

		[Ordinal(6)] [RED("spawnedPOIs", 2,0)] 		public CArray<CHandle<W3PointOfInterestEntity>> SpawnedPOIs { get; set;}

		[Ordinal(7)] [RED("activatorArea")] 		public CHandle<CTriggerAreaComponent> ActivatorArea { get; set;}

		public W3POIDispenser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3POIDispenser(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}