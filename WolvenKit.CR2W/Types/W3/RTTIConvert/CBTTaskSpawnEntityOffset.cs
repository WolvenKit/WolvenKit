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
		[RED("positionOffset")] 		public Vector PositionOffset { get; set;}

		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[RED("resourceName")] 		public CName ResourceName { get; set;}

		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("completeAfterSpawn")] 		public CBool CompleteAfterSpawn { get; set;}

		[RED("complete")] 		public CBool Complete { get; set;}

		[RED("spawnEntityOnAnimEvent")] 		public CBool SpawnEntityOnAnimEvent { get; set;}

		[RED("addEntityToSummonerComponent")] 		public CBool AddEntityToSummonerComponent { get; set;}

		[RED("spawnAnimEventName")] 		public CName SpawnAnimEventName { get; set;}

		[RED("tagToAdd")] 		public CName TagToAdd { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("addTagToEntity")] 		public CBool AddTagToEntity { get; set;}

		[RED("destroyTaggedEntitiesOnDeactivate")] 		public CBool DestroyTaggedEntitiesOnDeactivate { get; set;}

		[RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[RED("entities", 2,0)] 		public CArray<CHandle<CEntity>> Entities { get; set;}

		[RED("destroyEntityAfter")] 		public CFloat DestroyEntityAfter { get; set;}

		[RED("spawnEntityAtNode")] 		public CBool SpawnEntityAtNode { get; set;}

		[RED("tagToFindNode")] 		public CName TagToFindNode { get; set;}

		[RED("m_summonerComponent")] 		public CHandle<W3SummonerComponent> M_summonerComponent { get; set;}

		[RED("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		public CBTTaskSpawnEntityOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnEntityOffset(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}