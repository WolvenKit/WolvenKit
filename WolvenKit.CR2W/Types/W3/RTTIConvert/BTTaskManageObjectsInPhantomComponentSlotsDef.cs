using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageObjectsInPhantomComponentSlotsDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("checkDistanceOnIsAvailable")] 		public CBool CheckDistanceOnIsAvailable { get; set;}

		[Ordinal(0)] [RED("createEntityResourceNames", 2,0)] 		public CArray<CName> CreateEntityResourceNames { get; set;}

		[Ordinal(0)] [RED("attachSlotNames", 2,0)] 		public CArray<CName> AttachSlotNames { get; set;}

		[Ordinal(0)] [RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("drawEntitiesFromArea")] 		public CBool DrawEntitiesFromArea { get; set;}

		[Ordinal(0)] [RED("snapDrawnEntityToGround")] 		public CBool SnapDrawnEntityToGround { get; set;}

		[Ordinal(0)] [RED("shootAtLookatTarget")] 		public CBool ShootAtLookatTarget { get; set;}

		[Ordinal(0)] [RED("shootAllDrawnEntitiesAtOnce")] 		public CBool ShootAllDrawnEntitiesAtOnce { get; set;}

		[Ordinal(0)] [RED("drawEntitiesRadius")] 		public CFloat DrawEntitiesRadius { get; set;}

		[Ordinal(0)] [RED("drawEntitiesTag")] 		public CName DrawEntitiesTag { get; set;}

		[Ordinal(0)] [RED("drawSpeedLimit")] 		public CFloat DrawSpeedLimit { get; set;}

		[Ordinal(0)] [RED("destroyEntityOnAnimEvent")] 		public CName DestroyEntityOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("shootEntityOnAnimEvent")] 		public CName ShootEntityOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("disperseObjectsOnAnimEvent")] 		public CName DisperseObjectsOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("playEffectOnEntityPull")] 		public CName PlayEffectOnEntityPull { get; set;}

		[Ordinal(0)] [RED("playEffectOnEntityAttach")] 		public CName PlayEffectOnEntityAttach { get; set;}

		[Ordinal(0)] [RED("playEffectOnDestroyEntity")] 		public CName PlayEffectOnDestroyEntity { get; set;}

		[Ordinal(0)] [RED("playEffectOnDisperseObjects")] 		public CName PlayEffectOnDisperseObjects { get; set;}

		public BTTaskManageObjectsInPhantomComponentSlotsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageObjectsInPhantomComponentSlotsDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}