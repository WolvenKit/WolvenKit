using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_SpawnEntity : W3SwitchEvent
	{
		[Ordinal(1)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(2)] [RED("positionOffset")] 		public Vector PositionOffset { get; set;}

		[Ordinal(3)] [RED("randomOffset")] 		public Vector RandomOffset { get; set;}

		[Ordinal(4)] [RED("lifeTime")] 		public CFloat LifeTime { get; set;}

		[Ordinal(5)] [RED("maxEntitiesAtATime")] 		public CInt32 MaxEntitiesAtATime { get; set;}

		[Ordinal(6)] [RED("minDelayBetweenSpawns")] 		public CFloat MinDelayBetweenSpawns { get; set;}

		[Ordinal(7)] [RED("spawnSnapToGround")] 		public CBool SpawnSnapToGround { get; set;}

		[Ordinal(8)] [RED("m_spawnedEntities", 2,0)] 		public CArray<CHandle<CEntity>> M_spawnedEntities { get; set;}

		public W3SE_SpawnEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SE_SpawnEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}