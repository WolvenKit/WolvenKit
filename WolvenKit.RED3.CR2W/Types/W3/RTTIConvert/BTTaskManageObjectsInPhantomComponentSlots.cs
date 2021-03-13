using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageObjectsInPhantomComponentSlots : IBehTreeTask
	{
		[Ordinal(1)] [RED("checkDistanceOnIsAvailable")] 		public CBool CheckDistanceOnIsAvailable { get; set;}

		[Ordinal(2)] [RED("createEntityResourceNames", 2,0)] 		public CArray<CName> CreateEntityResourceNames { get; set;}

		[Ordinal(3)] [RED("attachSlotNames", 2,0)] 		public CArray<CName> AttachSlotNames { get; set;}

		[Ordinal(4)] [RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[Ordinal(5)] [RED("drawEntitiesFromArea")] 		public CBool DrawEntitiesFromArea { get; set;}

		[Ordinal(6)] [RED("drawEntitiesRadius")] 		public CFloat DrawEntitiesRadius { get; set;}

		[Ordinal(7)] [RED("drawEntitiesTag")] 		public CName DrawEntitiesTag { get; set;}

		[Ordinal(8)] [RED("drawSpeedLimit")] 		public CFloat DrawSpeedLimit { get; set;}

		[Ordinal(9)] [RED("snapDrawnEntityToGround")] 		public CBool SnapDrawnEntityToGround { get; set;}

		[Ordinal(10)] [RED("shootAtLookatTarget")] 		public CBool ShootAtLookatTarget { get; set;}

		[Ordinal(11)] [RED("destroyEntityOnAnimEvent")] 		public CName DestroyEntityOnAnimEvent { get; set;}

		[Ordinal(12)] [RED("shootEntityOnAnimEvent")] 		public CName ShootEntityOnAnimEvent { get; set;}

		[Ordinal(13)] [RED("shootAllDrawnEntitiesAtOnce")] 		public CBool ShootAllDrawnEntitiesAtOnce { get; set;}

		[Ordinal(14)] [RED("disperseObjectsOnAnimEvent")] 		public CName DisperseObjectsOnAnimEvent { get; set;}

		[Ordinal(15)] [RED("playEffectOnEntityPull")] 		public CName PlayEffectOnEntityPull { get; set;}

		[Ordinal(16)] [RED("playEffectOnEntityAttach")] 		public CName PlayEffectOnEntityAttach { get; set;}

		[Ordinal(17)] [RED("playEffectOnDestroyEntity")] 		public CName PlayEffectOnDestroyEntity { get; set;}

		[Ordinal(18)] [RED("playEffectOnDisperseObjects")] 		public CName PlayEffectOnDisperseObjects { get; set;}

		[Ordinal(19)] [RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		[Ordinal(20)] [RED("m_CreateEntityTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> M_CreateEntityTemplates { get; set;}

		[Ordinal(21)] [RED("m_EntitiesDrawnFromArea", 2,0)] 		public CArray<CHandle<CEntity>> M_EntitiesDrawnFromArea { get; set;}

		[Ordinal(22)] [RED("m_CurveComponents", 2,0)] 		public CArray<CHandle<CComponent>> M_CurveComponents { get; set;}

		[Ordinal(23)] [RED("m_activateEventReceived")] 		public CBool M_activateEventReceived { get; set;}

		[Ordinal(24)] [RED("m_destroyEntityEventReceived")] 		public CBool M_destroyEntityEventReceived { get; set;}

		[Ordinal(25)] [RED("m_disperceObjectsEventReceived")] 		public CBool M_disperceObjectsEventReceived { get; set;}

		[Ordinal(26)] [RED("m_shootEntityEventReceived")] 		public CBool M_shootEntityEventReceived { get; set;}

		[Ordinal(27)] [RED("m_entityResourceNameFilled")] 		public CBool M_entityResourceNameFilled { get; set;}

		[Ordinal(28)] [RED("m_prevDesiredAffectedEntityPos")] 		public Vector M_prevDesiredAffectedEntityPos { get; set;}

		[Ordinal(29)] [RED("m_prevSpeed")] 		public CFloat M_prevSpeed { get; set;}

		[Ordinal(30)] [RED("m_ClosestSlot")] 		public CName M_ClosestSlot { get; set;}

		[Ordinal(31)] [RED("m_attachEntitiesArray", 2,0)] 		public CArray<CHandle<CEntity>> M_attachEntitiesArray { get; set;}

		[Ordinal(32)] [RED("m_collisionGroups", 2,0)] 		public CArray<CName> M_collisionGroups { get; set;}

		[Ordinal(33)] [RED("m_drawnEntities")] 		public CInt32 M_drawnEntities { get; set;}

		[Ordinal(34)] [RED("m_checkedForEntities")] 		public CBool M_checkedForEntities { get; set;}

		public BTTaskManageObjectsInPhantomComponentSlots(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageObjectsInPhantomComponentSlots(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}