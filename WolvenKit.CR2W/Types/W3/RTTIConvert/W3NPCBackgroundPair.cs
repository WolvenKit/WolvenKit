using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3NPCBackgroundPair : CGameplayEntity
	{
		[RED("work")] 		public CEnum<EBackgroundNPCWork_Paired> Work { get; set;}

		[RED("entitiesToSpawn", 2,0)] 		public CArray<SBackgroundPairSpawnedEntity> EntitiesToSpawn { get; set;}

		[RED("spawnedEntities", 2,0)] 		public CArray<CHandle<CEntity>> SpawnedEntities { get; set;}

		[RED("currentAttachments", 2,0)] 		public CArray<CHandle<CEntity>> CurrentAttachments { get; set;}

		[RED("slave")] 		public CHandle<W3NPCBackground> Slave { get; set;}

		[RED("master")] 		public CHandle<W3NPCBackground> Master { get; set;}

		[RED("mountEvents", 2,0)] 		public CArray<SMountEvent> MountEvents { get; set;}

		[RED("masterAC")] 		public CHandle<CAnimatedComponent> MasterAC { get; set;}

		[RED("slaveAC")] 		public CHandle<CAnimatedComponent> SlaveAC { get; set;}

		public W3NPCBackgroundPair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3NPCBackgroundPair(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}