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
		[Ordinal(0)] [RED("data")] 		public CHandle<CArchesporeAICombatStorage> Data { get; set;}

		[Ordinal(0)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(0)] [RED("allBaseEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> AllBaseEntities { get; set;}

		[Ordinal(0)] [RED("usedPos", 2,0)] 		public CArray<Vector> UsedPos { get; set;}

		[Ordinal(0)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(0)] [RED("anchorPos")] 		public Vector AnchorPos { get; set;}

		[Ordinal(0)] [RED("privateBulb")] 		public CHandle<W3ArchesporBulb> PrivateBulb { get; set;}

		[Ordinal(0)] [RED("guardArea")] 		public CHandle<CAreaComponent> GuardArea { get; set;}

		[Ordinal(0)] [RED("losTestCollisionGroups", 2,0)] 		public CArray<CName> LosTestCollisionGroups { get; set;}

		[Ordinal(0)] [RED("baseEntitiesSearchingRange")] 		public CFloat BaseEntitiesSearchingRange { get; set;}

		[Ordinal(0)] [RED("baseEntityTag")] 		public CName BaseEntityTag { get; set;}

		[Ordinal(0)] [RED("resourceName")] 		public CString ResourceName { get; set;}

		[Ordinal(0)] [RED("baseEntitiesToSpawnCount")] 		public CInt32 BaseEntitiesToSpawnCount { get; set;}

		[Ordinal(0)] [RED("minDistFromOwner")] 		public CFloat MinDistFromOwner { get; set;}

		[Ordinal(0)] [RED("maxDistFromOwner")] 		public CFloat MaxDistFromOwner { get; set;}

		[Ordinal(0)] [RED("minDistFromEachOther")] 		public CFloat MinDistFromEachOther { get; set;}

		[Ordinal(0)] [RED("maxDistFromAnchor")] 		public CFloat MaxDistFromAnchor { get; set;}

		[Ordinal(0)] [RED("spawnEntitiesAroundPlayer")] 		public CBool SpawnEntitiesAroundPlayer { get; set;}

		public BTTaskArchesporManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskArchesporManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}