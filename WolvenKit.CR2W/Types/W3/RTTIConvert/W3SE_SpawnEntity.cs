using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_SpawnEntity : W3SwitchEvent
	{
		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("positionOffset")] 		public Vector PositionOffset { get; set;}

		[RED("randomOffset")] 		public Vector RandomOffset { get; set;}

		[RED("lifeTime")] 		public CFloat LifeTime { get; set;}

		[RED("maxEntitiesAtATime")] 		public CInt32 MaxEntitiesAtATime { get; set;}

		[RED("minDelayBetweenSpawns")] 		public CFloat MinDelayBetweenSpawns { get; set;}

		[RED("spawnSnapToGround")] 		public CBool SpawnSnapToGround { get; set;}

		public W3SE_SpawnEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SE_SpawnEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}