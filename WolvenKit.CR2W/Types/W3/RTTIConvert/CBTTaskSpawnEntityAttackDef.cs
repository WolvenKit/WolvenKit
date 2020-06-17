using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnEntityAttackDef : CBTTaskAttackDef
	{
		[RED("ressourceName")] 		public CBehTreeValCName RessourceName { get; set;}

		[RED("spawnAnimEventName")] 		public CName SpawnAnimEventName { get; set;}

		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("offsetVector")] 		public Vector OffsetVector { get; set;}

		[RED("completeAfterSpawn")] 		public CBool CompleteAfterSpawn { get; set;}

		public CBTTaskSpawnEntityAttackDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSpawnEntityAttackDef(cr2w);

	}
}