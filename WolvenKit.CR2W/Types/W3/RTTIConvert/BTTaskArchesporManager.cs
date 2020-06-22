using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskArchesporManager : IBehTreeTask
	{
		[RED("data")] 		public CHandle<CArchesporeAICombatStorage> Data { get; set;}

		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[RED("allBaseEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> AllBaseEntities { get; set;}

		[RED("usedPos", 2,0)] 		public CArray<Vector> UsedPos { get; set;}

		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("anchorPos")] 		public Vector AnchorPos { get; set;}

		[RED("privateBulb")] 		public CHandle<W3ArchesporBulb> PrivateBulb { get; set;}

		[RED("guardArea")] 		public CHandle<CAreaComponent> GuardArea { get; set;}

		[RED("losTestCollisionGroups", 2,0)] 		public CArray<CName> LosTestCollisionGroups { get; set;}

		[RED("baseEntitiesSearchingRange")] 		public CFloat BaseEntitiesSearchingRange { get; set;}

		[RED("baseEntityTag")] 		public CName BaseEntityTag { get; set;}

		[RED("resourceName")] 		public CString ResourceName { get; set;}

		[RED("baseEntitiesToSpawnCount")] 		public CInt32 BaseEntitiesToSpawnCount { get; set;}

		[RED("minDistFromOwner")] 		public CFloat MinDistFromOwner { get; set;}

		[RED("maxDistFromOwner")] 		public CFloat MaxDistFromOwner { get; set;}

		[RED("minDistFromEachOther")] 		public CFloat MinDistFromEachOther { get; set;}

		[RED("maxDistFromAnchor")] 		public CFloat MaxDistFromAnchor { get; set;}

		[RED("spawnEntitiesAroundPlayer")] 		public CBool SpawnEntitiesAroundPlayer { get; set;}

		public BTTaskArchesporManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskArchesporManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}