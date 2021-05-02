using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageObjectsInPhantomComponentSlotsDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("checkDistanceOnIsAvailable")] 		public CBool CheckDistanceOnIsAvailable { get; set;}

		[Ordinal(2)] [RED("createEntityResourceNames", 2,0)] 		public CArray<CName> CreateEntityResourceNames { get; set;}

		[Ordinal(3)] [RED("attachSlotNames", 2,0)] 		public CArray<CName> AttachSlotNames { get; set;}

		[Ordinal(4)] [RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[Ordinal(5)] [RED("drawEntitiesFromArea")] 		public CBool DrawEntitiesFromArea { get; set;}

		[Ordinal(6)] [RED("snapDrawnEntityToGround")] 		public CBool SnapDrawnEntityToGround { get; set;}

		[Ordinal(7)] [RED("shootAtLookatTarget")] 		public CBool ShootAtLookatTarget { get; set;}

		[Ordinal(8)] [RED("shootAllDrawnEntitiesAtOnce")] 		public CBool ShootAllDrawnEntitiesAtOnce { get; set;}

		[Ordinal(9)] [RED("drawEntitiesRadius")] 		public CFloat DrawEntitiesRadius { get; set;}

		[Ordinal(10)] [RED("drawEntitiesTag")] 		public CName DrawEntitiesTag { get; set;}

		[Ordinal(11)] [RED("drawSpeedLimit")] 		public CFloat DrawSpeedLimit { get; set;}

		[Ordinal(12)] [RED("destroyEntityOnAnimEvent")] 		public CName DestroyEntityOnAnimEvent { get; set;}

		[Ordinal(13)] [RED("shootEntityOnAnimEvent")] 		public CName ShootEntityOnAnimEvent { get; set;}

		[Ordinal(14)] [RED("disperseObjectsOnAnimEvent")] 		public CName DisperseObjectsOnAnimEvent { get; set;}

		[Ordinal(15)] [RED("playEffectOnEntityPull")] 		public CName PlayEffectOnEntityPull { get; set;}

		[Ordinal(16)] [RED("playEffectOnEntityAttach")] 		public CName PlayEffectOnEntityAttach { get; set;}

		[Ordinal(17)] [RED("playEffectOnDestroyEntity")] 		public CName PlayEffectOnDestroyEntity { get; set;}

		[Ordinal(18)] [RED("playEffectOnDisperseObjects")] 		public CName PlayEffectOnDisperseObjects { get; set;}

		public BTTaskManageObjectsInPhantomComponentSlotsDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageObjectsInPhantomComponentSlotsDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}