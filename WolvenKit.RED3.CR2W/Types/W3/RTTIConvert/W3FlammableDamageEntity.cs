using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FlammableDamageEntity : CInteractiveEntity
	{
		[Ordinal(1)] [RED("explosionEntity")] 		public CHandle<CEntityTemplate> ExplosionEntity { get; set;}

		[Ordinal(2)] [RED("spawnedExplosion")] 		public CHandle<CDamageAreaEntity> SpawnedExplosion { get; set;}

		[Ordinal(3)] [RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		[Ordinal(4)] [RED("pos")] 		public Vector Pos { get; set;}

		public W3FlammableDamageEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}