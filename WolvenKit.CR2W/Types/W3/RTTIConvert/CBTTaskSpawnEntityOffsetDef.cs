using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnEntityOffsetDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(1)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(2)] [RED("resourceName")] 		public CBehTreeValCName ResourceName { get; set;}

		[Ordinal(3)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(4)] [RED("positionOffset")] 		public Vector PositionOffset { get; set;}

		[Ordinal(5)] [RED("completeAfterSpawn")] 		public CBool CompleteAfterSpawn { get; set;}

		[Ordinal(6)] [RED("complete")] 		public CBool Complete { get; set;}

		[Ordinal(7)] [RED("spawnEntityOnAnimEvent")] 		public CBool SpawnEntityOnAnimEvent { get; set;}

		[Ordinal(8)] [RED("spawnAnimEventName")] 		public CName SpawnAnimEventName { get; set;}

		[Ordinal(9)] [RED("addEntityToSummonerComponent")] 		public CBool AddEntityToSummonerComponent { get; set;}

		[Ordinal(10)] [RED("addTagToEntity")] 		public CBool AddTagToEntity { get; set;}

		[Ordinal(11)] [RED("tagToAdd")] 		public CName TagToAdd { get; set;}

		[Ordinal(12)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(13)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(14)] [RED("destroyTaggedEntitiesOnDeactivate")] 		public CBool DestroyTaggedEntitiesOnDeactivate { get; set;}

		[Ordinal(15)] [RED("destroyEntityAfter")] 		public CFloat DestroyEntityAfter { get; set;}

		[Ordinal(16)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(17)] [RED("entities", 2,0)] 		public CArray<CHandle<CEntity>> Entities { get; set;}

		[Ordinal(18)] [RED("spawnEntityAtNode")] 		public CBool SpawnEntityAtNode { get; set;}

		[Ordinal(19)] [RED("tagToFindNode")] 		public CName TagToFindNode { get; set;}

		public CBTTaskSpawnEntityOffsetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnEntityOffsetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}