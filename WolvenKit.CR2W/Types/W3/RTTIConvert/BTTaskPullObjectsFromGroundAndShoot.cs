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
		[Ordinal(0)] [RED("createEntityResourceName")] 		public CName CreateEntityResourceName { get; set;}

		[Ordinal(0)] [RED("numberToSpawn")] 		public CInt32 NumberToSpawn { get; set;}

		[Ordinal(0)] [RED("numberOfCircles")] 		public CInt32 NumberOfCircles { get; set;}

		[Ordinal(0)] [RED("spawnPositionPattern")] 		public CEnum<ESpawnPositionPattern> SpawnPositionPattern { get; set;}

		[Ordinal(0)] [RED("spawnRotation")] 		public CEnum<ESpawnRotation> SpawnRotation { get; set;}

		[Ordinal(0)] [RED("spawnInTargetDirection")] 		public CBool SpawnInTargetDirection { get; set;}

		[Ordinal(0)] [RED("zAxisSpawnOffset")] 		public CFloat ZAxisSpawnOffset { get; set;}

		[Ordinal(0)] [RED("raiseObjectsToCapsuleHeightRatio")] 		public CFloat RaiseObjectsToCapsuleHeightRatio { get; set;}

		[Ordinal(0)] [RED("raiseObjectsHeightNoise")] 		public CFloat RaiseObjectsHeightNoise { get; set;}

		[Ordinal(0)] [RED("spawnObjectsInConeAngle")] 		public CFloat SpawnObjectsInConeAngle { get; set;}

		[Ordinal(0)] [RED("randomnessInCircles")] 		public CFloat RandomnessInCircles { get; set;}

		[Ordinal(0)] [RED("useRandomSpaceBetweenSpawns")] 		public CBool UseRandomSpaceBetweenSpawns { get; set;}

		[Ordinal(0)] [RED("spawnRadiusMin")] 		public CFloat SpawnRadiusMin { get; set;}

		[Ordinal(0)] [RED("spawnRadiusMax")] 		public CFloat SpawnRadiusMax { get; set;}

		[Ordinal(0)] [RED("spawnInRandomOrder")] 		public CBool SpawnInRandomOrder { get; set;}

		[Ordinal(0)] [RED("delayBetweenSpawn")] 		public CFloat DelayBetweenSpawn { get; set;}

		[Ordinal(0)] [RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("activateAfter")] 		public CFloat ActivateAfter { get; set;}

		[Ordinal(0)] [RED("calculateSpeedFromPullDuration")] 		public CFloat CalculateSpeedFromPullDuration { get; set;}

		[Ordinal(0)] [RED("drawSpeedLimit")] 		public CFloat DrawSpeedLimit { get; set;}

		[Ordinal(0)] [RED("drawEntityRotationSpeed")] 		public CFloat DrawEntityRotationSpeed { get; set;}

		[Ordinal(0)] [RED("completeTaskAfterShooting")] 		public CBool CompleteTaskAfterShooting { get; set;}

		[Ordinal(0)] [RED("shootEntitiesInRandomOrder")] 		public CBool ShootEntitiesInRandomOrder { get; set;}

		[Ordinal(0)] [RED("shootAtLookatTarget")] 		public CBool ShootAtLookatTarget { get; set;}

		[Ordinal(0)] [RED("shootInAllDirections")] 		public CBool ShootInAllDirections { get; set;}

		[Ordinal(0)] [RED("shootDirectionNoise")] 		public CFloat ShootDirectionNoise { get; set;}

		[Ordinal(0)] [RED("shootEntityOnAnimEvent")] 		public CName ShootEntityOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("shootEntityAfter")] 		public CFloat ShootEntityAfter { get; set;}

		[Ordinal(0)] [RED("shootEntitiesInterval")] 		public CFloat ShootEntitiesInterval { get; set;}

		[Ordinal(0)] [RED("playEffectOnEntityCreation")] 		public CName PlayEffectOnEntityCreation { get; set;}

		[Ordinal(0)] [RED("stopEffectOnDeactivate")] 		public CName StopEffectOnDeactivate { get; set;}

		[Ordinal(0)] [RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		[Ordinal(0)] [RED("m_CreateEntityTemplate")] 		public CHandle<CEntityTemplate> M_CreateEntityTemplate { get; set;}

		[Ordinal(0)] [RED("m_CreatedEntities", 2,0)] 		public CArray<CHandle<CEntity>> M_CreatedEntities { get; set;}

		[Ordinal(0)] [RED("m_entitiesToPull", 2,0)] 		public CArray<CHandle<CEntity>> M_entitiesToPull { get; set;}

		[Ordinal(0)] [RED("m_entitiesToShoot", 2,0)] 		public CArray<CHandle<CEntity>> M_entitiesToShoot { get; set;}

		[Ordinal(0)] [RED("m_activateEventReceived")] 		public CBool M_activateEventReceived { get; set;}

		[Ordinal(0)] [RED("m_shootEntityEventReceived")] 		public CBool M_shootEntityEventReceived { get; set;}

		[Ordinal(0)] [RED("m_aardHitEventReceived")] 		public CBool M_aardHitEventReceived { get; set;}

		[Ordinal(0)] [RED("m_initialPosArray", 2,0)] 		public CArray<Vector> M_initialPosArray { get; set;}

		[Ordinal(0)] [RED("m_finalPosArray", 2,0)] 		public CArray<Vector> M_finalPosArray { get; set;}

		[Ordinal(0)] [RED("m_prevSpeed")] 		public CFloat M_prevSpeed { get; set;}

		[Ordinal(0)] [RED("m_lastShootTime")] 		public CFloat M_lastShootTime { get; set;}

		[Ordinal(0)] [RED("m_collisionGroups", 2,0)] 		public CArray<CName> M_collisionGroups { get; set;}

		[Ordinal(0)] [RED("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		public BTTaskPullObjectsFromGroundAndShoot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskPullObjectsFromGroundAndShoot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}