using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskPullObjectsFromGroundAndShootDef : IBehTreeTaskDefinition
	{
		[RED("createEntityResourceName")] 		public CName CreateEntityResourceName { get; set;}

		[RED("zAxisSpawnOffset")] 		public CFloat ZAxisSpawnOffset { get; set;}

		[RED("raiseObjectsToCapsuleHeightRatio")] 		public CFloat RaiseObjectsToCapsuleHeightRatio { get; set;}

		[RED("raiseObjectsHeightNoise")] 		public CFloat RaiseObjectsHeightNoise { get; set;}

		[RED("numberToSpawn")] 		public CInt32 NumberToSpawn { get; set;}

		[RED("numberOfCircles")] 		public CInt32 NumberOfCircles { get; set;}

		[RED("spawnPositionPattern")] 		public CEnum<ESpawnPositionPattern> SpawnPositionPattern { get; set;}

		[RED("spawnRotation")] 		public CEnum<ESpawnRotation> SpawnRotation { get; set;}

		[RED("spawnInTargetDirection")] 		public CBool SpawnInTargetDirection { get; set;}

		[RED("spawnObjectsInConeAngle")] 		public CFloat SpawnObjectsInConeAngle { get; set;}

		[RED("randomnessInCircles")] 		public CFloat RandomnessInCircles { get; set;}

		[RED("useRandomSpaceBetweenSpawns")] 		public CBool UseRandomSpaceBetweenSpawns { get; set;}

		[RED("spawnRadiusMin")] 		public CFloat SpawnRadiusMin { get; set;}

		[RED("spawnRadiusMax")] 		public CFloat SpawnRadiusMax { get; set;}

		[RED("spawnInRandomOrder")] 		public CBool SpawnInRandomOrder { get; set;}

		[RED("delayBetweenSpawn")] 		public CFloat DelayBetweenSpawn { get; set;}

		[RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[RED("activateAfter")] 		public CFloat ActivateAfter { get; set;}

		[RED("shootEntityOnAnimEvent")] 		public CName ShootEntityOnAnimEvent { get; set;}

		[RED("shootEntityAfter")] 		public CFloat ShootEntityAfter { get; set;}

		[RED("drawSpeedLimit")] 		public CFloat DrawSpeedLimit { get; set;}

		[RED("calculateSpeedFromPullDuration")] 		public CFloat CalculateSpeedFromPullDuration { get; set;}

		[RED("drawEntityRotationSpeed")] 		public CFloat DrawEntityRotationSpeed { get; set;}

		[RED("shootAtLookatTarget")] 		public CBool ShootAtLookatTarget { get; set;}

		[RED("shootEntitiesInRandomOrder")] 		public CBool ShootEntitiesInRandomOrder { get; set;}

		[RED("shootInAllDirections")] 		public CBool ShootInAllDirections { get; set;}

		[RED("completeTaskAfterShooting")] 		public CBool CompleteTaskAfterShooting { get; set;}

		[RED("shootDirectionNoise")] 		public CFloat ShootDirectionNoise { get; set;}

		[RED("shootEntitiesInterval")] 		public CFloat ShootEntitiesInterval { get; set;}

		[RED("playEffectOnEntityCreation")] 		public CName PlayEffectOnEntityCreation { get; set;}

		[RED("stopEffectOnDeactivate")] 		public CName StopEffectOnDeactivate { get; set;}

		public BTTaskPullObjectsFromGroundAndShootDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskPullObjectsFromGroundAndShootDef(cr2w);

	}
}