using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskPullObjectsFromGroundAndShoot : IBehTreeTask
	{
		[RED("createEntityResourceName")] 		public CName CreateEntityResourceName { get; set;}

		[RED("numberToSpawn")] 		public CInt32 NumberToSpawn { get; set;}

		[RED("numberOfCircles")] 		public CInt32 NumberOfCircles { get; set;}

		[RED("spawnPositionPattern")] 		public CEnum<ESpawnPositionPattern> SpawnPositionPattern { get; set;}

		[RED("spawnRotation")] 		public CEnum<ESpawnRotation> SpawnRotation { get; set;}

		[RED("spawnInTargetDirection")] 		public CBool SpawnInTargetDirection { get; set;}

		[RED("zAxisSpawnOffset")] 		public CFloat ZAxisSpawnOffset { get; set;}

		[RED("raiseObjectsToCapsuleHeightRatio")] 		public CFloat RaiseObjectsToCapsuleHeightRatio { get; set;}

		[RED("raiseObjectsHeightNoise")] 		public CFloat RaiseObjectsHeightNoise { get; set;}

		[RED("spawnObjectsInConeAngle")] 		public CFloat SpawnObjectsInConeAngle { get; set;}

		[RED("randomnessInCircles")] 		public CFloat RandomnessInCircles { get; set;}

		[RED("useRandomSpaceBetweenSpawns")] 		public CBool UseRandomSpaceBetweenSpawns { get; set;}

		[RED("spawnRadiusMin")] 		public CFloat SpawnRadiusMin { get; set;}

		[RED("spawnRadiusMax")] 		public CFloat SpawnRadiusMax { get; set;}

		[RED("spawnInRandomOrder")] 		public CBool SpawnInRandomOrder { get; set;}

		[RED("delayBetweenSpawn")] 		public CFloat DelayBetweenSpawn { get; set;}

		[RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[RED("activateAfter")] 		public CFloat ActivateAfter { get; set;}

		[RED("calculateSpeedFromPullDuration")] 		public CFloat CalculateSpeedFromPullDuration { get; set;}

		[RED("drawSpeedLimit")] 		public CFloat DrawSpeedLimit { get; set;}

		[RED("drawEntityRotationSpeed")] 		public CFloat DrawEntityRotationSpeed { get; set;}

		[RED("completeTaskAfterShooting")] 		public CBool CompleteTaskAfterShooting { get; set;}

		[RED("shootEntitiesInRandomOrder")] 		public CBool ShootEntitiesInRandomOrder { get; set;}

		[RED("shootAtLookatTarget")] 		public CBool ShootAtLookatTarget { get; set;}

		[RED("shootInAllDirections")] 		public CBool ShootInAllDirections { get; set;}

		[RED("shootDirectionNoise")] 		public CFloat ShootDirectionNoise { get; set;}

		[RED("shootEntityOnAnimEvent")] 		public CName ShootEntityOnAnimEvent { get; set;}

		[RED("shootEntityAfter")] 		public CFloat ShootEntityAfter { get; set;}

		[RED("shootEntitiesInterval")] 		public CFloat ShootEntitiesInterval { get; set;}

		[RED("playEffectOnEntityCreation")] 		public CName PlayEffectOnEntityCreation { get; set;}

		[RED("stopEffectOnDeactivate")] 		public CName StopEffectOnDeactivate { get; set;}

		[RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		[RED("m_CreateEntityTemplate")] 		public CHandle<CEntityTemplate> M_CreateEntityTemplate { get; set;}

		[RED("m_CreatedEntities", 2,0)] 		public CArray<CHandle<CEntity>> M_CreatedEntities { get; set;}

		[RED("m_entitiesToPull", 2,0)] 		public CArray<CHandle<CEntity>> M_entitiesToPull { get; set;}

		[RED("m_entitiesToShoot", 2,0)] 		public CArray<CHandle<CEntity>> M_entitiesToShoot { get; set;}

		[RED("m_activateEventReceived")] 		public CBool M_activateEventReceived { get; set;}

		[RED("m_shootEntityEventReceived")] 		public CBool M_shootEntityEventReceived { get; set;}

		[RED("m_aardHitEventReceived")] 		public CBool M_aardHitEventReceived { get; set;}

		[RED("m_initialPosArray", 2,0)] 		public CArray<Vector> M_initialPosArray { get; set;}

		[RED("m_finalPosArray", 2,0)] 		public CArray<Vector> M_finalPosArray { get; set;}

		[RED("m_prevSpeed")] 		public CFloat M_prevSpeed { get; set;}

		[RED("m_lastShootTime")] 		public CFloat M_lastShootTime { get; set;}

		[RED("m_collisionGroups", 2,0)] 		public CArray<CName> M_collisionGroups { get; set;}

		[RED("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		public BTTaskPullObjectsFromGroundAndShoot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskPullObjectsFromGroundAndShoot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}