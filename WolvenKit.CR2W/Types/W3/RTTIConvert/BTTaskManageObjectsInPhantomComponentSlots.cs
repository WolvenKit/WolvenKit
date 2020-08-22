using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageObjectsInPhantomComponentSlots : IBehTreeTask
	{
		[RED("checkDistanceOnIsAvailable")] 		public CBool CheckDistanceOnIsAvailable { get; set;}

		[RED("createEntityResourceNames", 2,0)] 		public CArray<CName> CreateEntityResourceNames { get; set;}

		[RED("attachSlotNames", 2,0)] 		public CArray<CName> AttachSlotNames { get; set;}

		[RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[RED("drawEntitiesFromArea")] 		public CBool DrawEntitiesFromArea { get; set;}

		[RED("drawEntitiesRadius")] 		public CFloat DrawEntitiesRadius { get; set;}

		[RED("drawEntitiesTag")] 		public CName DrawEntitiesTag { get; set;}

		[RED("drawSpeedLimit")] 		public CFloat DrawSpeedLimit { get; set;}

		[RED("snapDrawnEntityToGround")] 		public CBool SnapDrawnEntityToGround { get; set;}

		[RED("shootAtLookatTarget")] 		public CBool ShootAtLookatTarget { get; set;}

		[RED("destroyEntityOnAnimEvent")] 		public CName DestroyEntityOnAnimEvent { get; set;}

		[RED("shootEntityOnAnimEvent")] 		public CName ShootEntityOnAnimEvent { get; set;}

		[RED("shootAllDrawnEntitiesAtOnce")] 		public CBool ShootAllDrawnEntitiesAtOnce { get; set;}

		[RED("disperseObjectsOnAnimEvent")] 		public CName DisperseObjectsOnAnimEvent { get; set;}

		[RED("playEffectOnEntityPull")] 		public CName PlayEffectOnEntityPull { get; set;}

		[RED("playEffectOnEntityAttach")] 		public CName PlayEffectOnEntityAttach { get; set;}

		[RED("playEffectOnDestroyEntity")] 		public CName PlayEffectOnDestroyEntity { get; set;}

		[RED("playEffectOnDisperseObjects")] 		public CName PlayEffectOnDisperseObjects { get; set;}

		[RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		[RED("m_CreateEntityTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> M_CreateEntityTemplates { get; set;}

		[RED("m_EntitiesDrawnFromArea", 2,0)] 		public CArray<CHandle<CEntity>> M_EntitiesDrawnFromArea { get; set;}

		[RED("m_CurveComponents", 2,0)] 		public CArray<CHandle<CComponent>> M_CurveComponents { get; set;}

		[RED("m_activateEventReceived")] 		public CBool M_activateEventReceived { get; set;}

		[RED("m_destroyEntityEventReceived")] 		public CBool M_destroyEntityEventReceived { get; set;}

		[RED("m_disperceObjectsEventReceived")] 		public CBool M_disperceObjectsEventReceived { get; set;}

		[RED("m_shootEntityEventReceived")] 		public CBool M_shootEntityEventReceived { get; set;}

		[RED("m_entityResourceNameFilled")] 		public CBool M_entityResourceNameFilled { get; set;}

		[RED("m_prevDesiredAffectedEntityPos")] 		public Vector M_prevDesiredAffectedEntityPos { get; set;}

		[RED("m_prevSpeed")] 		public CFloat M_prevSpeed { get; set;}

		[RED("m_ClosestSlot")] 		public CName M_ClosestSlot { get; set;}

		[RED("m_attachEntitiesArray", 2,0)] 		public CArray<CHandle<CEntity>> M_attachEntitiesArray { get; set;}

		[RED("m_collisionGroups", 2,0)] 		public CArray<CName> M_collisionGroups { get; set;}

		[RED("m_drawnEntities")] 		public CInt32 M_drawnEntities { get; set;}

		[RED("m_checkedForEntities")] 		public CBool M_checkedForEntities { get; set;}

		public BTTaskManageObjectsInPhantomComponentSlots(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageObjectsInPhantomComponentSlots(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}