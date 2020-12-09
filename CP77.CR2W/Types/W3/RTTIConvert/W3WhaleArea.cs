using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WhaleArea : CEntity
	{
		[Ordinal(1)] [RED("whaleSpawnPointTag")] 		public CName WhaleSpawnPointTag { get; set;}

		[Ordinal(2)] [RED("whaleSpawnOffsetY")] 		public CFloat WhaleSpawnOffsetY { get; set;}

		[Ordinal(3)] [RED("minSpawnDistance")] 		public CFloat MinSpawnDistance { get; set;}

		[Ordinal(4)] [RED("maxSpawnDistance")] 		public CFloat MaxSpawnDistance { get; set;}

		[Ordinal(5)] [RED("spawnFrequencyMin")] 		public CFloat SpawnFrequencyMin { get; set;}

		[Ordinal(6)] [RED("spawnFrequencyMax")] 		public CFloat SpawnFrequencyMax { get; set;}

		[Ordinal(7)] [RED("movementPatern")] 		public CEnum<EWhaleMovementPatern> MovementPatern { get; set;}

		[Ordinal(8)] [RED("whaleTemplate")] 		public CHandle<CEntityTemplate> WhaleTemplate { get; set;}

		public W3WhaleArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3WhaleArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}