using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskPullObjectsFromGroundAndShootDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("createEntityResourceName")] 		public CName CreateEntityResourceName { get; set;}

		[Ordinal(2)] [RED("zAxisSpawnOffset")] 		public CFloat ZAxisSpawnOffset { get; set;}

		[Ordinal(3)] [RED("raiseObjectsToCapsuleHeightRatio")] 		public CFloat RaiseObjectsToCapsuleHeightRatio { get; set;}

		[Ordinal(4)] [RED("raiseObjectsHeightNoise")] 		public CFloat RaiseObjectsHeightNoise { get; set;}

		[Ordinal(5)] [RED("numberToSpawn")] 		public CInt32 NumberToSpawn { get; set;}

		[Ordinal(6)] [RED("numberOfCircles")] 		public CInt32 NumberOfCircles { get; set;}

		[Ordinal(7)] [RED("spawnPositionPattern")] 		public CEnum<ESpawnPositionPattern> SpawnPositionPattern { get; set;}

		[Ordinal(8)] [RED("spawnRotation")] 		public CEnum<ESpawnRotation> SpawnRotation { get; set;}

		[Ordinal(9)] [RED("spawnInTargetDirection")] 		public CBool SpawnInTargetDirection { get; set;}

		[Ordinal(10)] [RED("spawnObjectsInConeAngle")] 		public CFloat SpawnObjectsInConeAngle { get; set;}

		[Ordinal(11)] [RED("randomnessInCircles")] 		public CFloat RandomnessInCircles { get; set;}

		[Ordinal(12)] [RED("useRandomSpaceBetweenSpawns")] 		public CBool UseRandomSpaceBetweenSpawns { get; set;}

		[Ordinal(13)] [RED("spawnRadiusMin")] 		public CFloat SpawnRadiusMin { get; set;}

		[Ordinal(14)] [RED("spawnRadiusMax")] 		public CFloat SpawnRadiusMax { get; set;}

		[Ordinal(15)] [RED("spawnInRandomOrder")] 		public CBool SpawnInRandomOrder { get; set;}

		[Ordinal(16)] [RED("delayBetweenSpawn")] 		public CFloat DelayBetweenSpawn { get; set;}

		[Ordinal(17)] [RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[Ordinal(18)] [RED("activateAfter")] 		public CFloat ActivateAfter { get; set;}

		[Ordinal(19)] [RED("shootEntityOnAnimEvent")] 		public CName ShootEntityOnAnimEvent { get; set;}

		[Ordinal(20)] [RED("shootEntityAfter")] 		public CFloat ShootEntityAfter { get; set;}

		[Ordinal(21)] [RED("drawSpeedLimit")] 		public CFloat DrawSpeedLimit { get; set;}

		[Ordinal(22)] [RED("calculateSpeedFromPullDuration")] 		public CFloat CalculateSpeedFromPullDuration { get; set;}

		[Ordinal(23)] [RED("drawEntityRotationSpeed")] 		public CFloat DrawEntityRotationSpeed { get; set;}

		[Ordinal(24)] [RED("shootAtLookatTarget")] 		public CBool ShootAtLookatTarget { get; set;}

		[Ordinal(25)] [RED("shootEntitiesInRandomOrder")] 		public CBool ShootEntitiesInRandomOrder { get; set;}

		[Ordinal(26)] [RED("shootInAllDirections")] 		public CBool ShootInAllDirections { get; set;}

		[Ordinal(27)] [RED("completeTaskAfterShooting")] 		public CBool CompleteTaskAfterShooting { get; set;}

		[Ordinal(28)] [RED("shootDirectionNoise")] 		public CFloat ShootDirectionNoise { get; set;}

		[Ordinal(29)] [RED("shootEntitiesInterval")] 		public CFloat ShootEntitiesInterval { get; set;}

		[Ordinal(30)] [RED("playEffectOnEntityCreation")] 		public CName PlayEffectOnEntityCreation { get; set;}

		[Ordinal(31)] [RED("stopEffectOnDeactivate")] 		public CName StopEffectOnDeactivate { get; set;}

		public BTTaskPullObjectsFromGroundAndShootDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskPullObjectsFromGroundAndShootDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}