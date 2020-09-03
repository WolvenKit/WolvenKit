using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnEntityAttackDef : CBTTaskAttackDef
	{
		[Ordinal(1)] [RED("ressourceName")] 		public CBehTreeValCName RessourceName { get; set;}

		[Ordinal(2)] [RED("spawnAnimEventName")] 		public CName SpawnAnimEventName { get; set;}

		[Ordinal(3)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(4)] [RED("offsetVector")] 		public Vector OffsetVector { get; set;}

		[Ordinal(5)] [RED("completeAfterSpawn")] 		public CBool CompleteAfterSpawn { get; set;}

		public CBTTaskSpawnEntityAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnEntityAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}