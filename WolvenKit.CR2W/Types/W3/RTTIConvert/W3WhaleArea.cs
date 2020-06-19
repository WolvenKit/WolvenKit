using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WhaleArea : CEntity
	{
		[RED("whaleSpawnPointTag")] 		public CName WhaleSpawnPointTag { get; set;}

		[RED("whaleSpawnOffsetY")] 		public CFloat WhaleSpawnOffsetY { get; set;}

		[RED("minSpawnDistance")] 		public CFloat MinSpawnDistance { get; set;}

		[RED("maxSpawnDistance")] 		public CFloat MaxSpawnDistance { get; set;}

		[RED("spawnFrequencyMin")] 		public CFloat SpawnFrequencyMin { get; set;}

		[RED("spawnFrequencyMax")] 		public CFloat SpawnFrequencyMax { get; set;}

		[RED("movementPatern")] 		public CEnum<EWhaleMovementPatern> MovementPatern { get; set;}

		public W3WhaleArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3WhaleArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}