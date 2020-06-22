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
		[RED("checkDistanceOnIsAvailable")] 		public CBool CheckDistanceOnIsAvailable { get; set;}

		[RED("createEntityResourceNames", 2,0)] 		public CArray<CName> CreateEntityResourceNames { get; set;}

		[RED("attachSlotNames", 2,0)] 		public CArray<CName> AttachSlotNames { get; set;}

		[RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[RED("drawEntitiesFromArea")] 		public CBool DrawEntitiesFromArea { get; set;}

		[RED("snapDrawnEntityToGround")] 		public CBool SnapDrawnEntityToGround { get; set;}

		[RED("shootAtLookatTarget")] 		public CBool ShootAtLookatTarget { get; set;}

		[RED("shootAllDrawnEntitiesAtOnce")] 		public CBool ShootAllDrawnEntitiesAtOnce { get; set;}

		[RED("drawEntitiesRadius")] 		public CFloat DrawEntitiesRadius { get; set;}

		[RED("drawEntitiesTag")] 		public CName DrawEntitiesTag { get; set;}

		[RED("drawSpeedLimit")] 		public CFloat DrawSpeedLimit { get; set;}

		[RED("destroyEntityOnAnimEvent")] 		public CName DestroyEntityOnAnimEvent { get; set;}

		[RED("shootEntityOnAnimEvent")] 		public CName ShootEntityOnAnimEvent { get; set;}

		[RED("disperseObjectsOnAnimEvent")] 		public CName DisperseObjectsOnAnimEvent { get; set;}

		[RED("playEffectOnEntityPull")] 		public CName PlayEffectOnEntityPull { get; set;}

		[RED("playEffectOnEntityAttach")] 		public CName PlayEffectOnEntityAttach { get; set;}

		[RED("playEffectOnDestroyEntity")] 		public CName PlayEffectOnDestroyEntity { get; set;}

		[RED("playEffectOnDisperseObjects")] 		public CName PlayEffectOnDisperseObjects { get; set;}

		public BTTaskManageObjectsInPhantomComponentSlotsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageObjectsInPhantomComponentSlotsDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}