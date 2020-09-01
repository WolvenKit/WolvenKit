using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnEntityOffset : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(0)] [RED("positionOffset")] 		public Vector PositionOffset { get; set;}

		[Ordinal(0)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(0)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(0)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(0)] [RED("completeAfterSpawn")] 		public CBool CompleteAfterSpawn { get; set;}

		[Ordinal(0)] [RED("complete")] 		public CBool Complete { get; set;}

		[Ordinal(0)] [RED("spawnEntityOnAnimEvent")] 		public CBool SpawnEntityOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("addEntityToSummonerComponent")] 		public CBool AddEntityToSummonerComponent { get; set;}

		[Ordinal(0)] [RED("spawnAnimEventName")] 		public CName SpawnAnimEventName { get; set;}

		[Ordinal(0)] [RED("tagToAdd")] 		public CName TagToAdd { get; set;}

		[Ordinal(0)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("addTagToEntity")] 		public CBool AddTagToEntity { get; set;}

		[Ordinal(0)] [RED("destroyTaggedEntitiesOnDeactivate")] 		public CBool DestroyTaggedEntitiesOnDeactivate { get; set;}

		[Ordinal(0)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(0)] [RED("entities", 2,0)] 		public CArray<CHandle<CEntity>> Entities { get; set;}

		[Ordinal(0)] [RED("destroyEntityAfter")] 		public CFloat DestroyEntityAfter { get; set;}

		[Ordinal(0)] [RED("spawnEntityAtNode")] 		public CBool SpawnEntityAtNode { get; set;}

		[Ordinal(0)] [RED("tagToFindNode")] 		public CName TagToFindNode { get; set;}

		[Ordinal(0)] [RED("m_summonerComponent")] 		public CHandle<W3SummonerComponent> M_summonerComponent { get; set;}

		[Ordinal(0)] [RED("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		public CBTTaskSpawnEntityOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnEntityOffset(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}