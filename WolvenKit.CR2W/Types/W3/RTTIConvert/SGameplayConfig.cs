using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayConfig : CVariable
	{
		[Ordinal(0)] [RED("("gameCamera")] 		public SGameplayConfigGameCamera GameCamera { get; set;}

		[Ordinal(0)] [RED("("LOD")] 		public SGameplayLODConfig LOD { get; set;}

		[Ordinal(0)] [RED("("debugA")] 		public CFloat DebugA { get; set;}

		[Ordinal(0)] [RED("("debugB")] 		public CFloat DebugB { get; set;}

		[Ordinal(0)] [RED("("debugC")] 		public CFloat DebugC { get; set;}

		[Ordinal(0)] [RED("("debugD")] 		public CFloat DebugD { get; set;}

		[Ordinal(0)] [RED("("debugE")] 		public CFloat DebugE { get; set;}

		[Ordinal(0)] [RED("("debugF")] 		public CFloat DebugF { get; set;}

		[Ordinal(0)] [RED("("debugG")] 		public CFloat DebugG { get; set;}

		[Ordinal(0)] [RED("("horseProp")] 		public CBool HorseProp { get; set;}

		[Ordinal(0)] [RED("("horseSpeedCtrl")] 		public CBool HorseSpeedCtrl { get; set;}

		[Ordinal(0)] [RED("("horseSpeedInc")] 		public CFloat HorseSpeedInc { get; set;}

		[Ordinal(0)] [RED("("horseSpeedDec")] 		public CFloat HorseSpeedDec { get; set;}

		[Ordinal(0)] [RED("("horseSpeedStep")] 		public CFloat HorseSpeedStep { get; set;}

		[Ordinal(0)] [RED("("horseInputCooldown")] 		public CFloat HorseInputCooldown { get; set;}

		[Ordinal(0)] [RED("("horseStaminaInc")] 		public CFloat HorseStaminaInc { get; set;}

		[Ordinal(0)] [RED("("horseStaminaDec")] 		public CFloat HorseStaminaDec { get; set;}

		[Ordinal(0)] [RED("("horseStaminaCooldown")] 		public CFloat HorseStaminaCooldown { get; set;}

		[Ordinal(0)] [RED("("horseSpeedDecCooldown")] 		public CFloat HorseSpeedDecCooldown { get; set;}

		[Ordinal(0)] [RED("("horsePathFactor")] 		public CFloat HorsePathFactor { get; set;}

		[Ordinal(0)] [RED("("horsePathDamping")] 		public CFloat HorsePathDamping { get; set;}

		[Ordinal(0)] [RED("("horseRoadSearchRadius")] 		public CFloat HorseRoadSearchRadius { get; set;}

		[Ordinal(0)] [RED("("horseRoadSearchDistanceSlow")] 		public CFloat HorseRoadSearchDistanceSlow { get; set;}

		[Ordinal(0)] [RED("("horseRoadSearchDistanceFast")] 		public CFloat HorseRoadSearchDistanceFast { get; set;}

		[Ordinal(0)] [RED("("horseRoadSelectionAngleCoeff")] 		public CFloat HorseRoadSelectionAngleCoeff { get; set;}

		[Ordinal(0)] [RED("("horseRoadSelectionDistanceCoeff")] 		public CFloat HorseRoadSelectionDistanceCoeff { get; set;}

		[Ordinal(0)] [RED("("horseRoadSelectionCurrentRoadPreferenceCoeff")] 		public CFloat HorseRoadSelectionCurrentRoadPreferenceCoeff { get; set;}

		[Ordinal(0)] [RED("("horseRoadSelectionTurnAmountFeeCoeff")] 		public CFloat HorseRoadSelectionTurnAmountFeeCoeff { get; set;}

		[Ordinal(0)] [RED("("horseRoadFollowingCooldownTime")] 		public CFloat HorseRoadFollowingCooldownTime { get; set;}

		[Ordinal(0)] [RED("("horseRoadFollowingCooldownDistance")] 		public CFloat HorseRoadFollowingCooldownDistance { get; set;}

		[Ordinal(0)] [RED("("strayActorDespawnDistance")] 		public CFloat StrayActorDespawnDistance { get; set;}

		[Ordinal(0)] [RED("("strayActorMaxHoursToKeep")] 		public CInt32 StrayActorMaxHoursToKeep { get; set;}

		[Ordinal(0)] [RED("("strayActorMaxActorsToKeep")] 		public CInt32 StrayActorMaxActorsToKeep { get; set;}

		[Ordinal(0)] [RED("("playerPreviewInventory")] 		public CInt32 PlayerPreviewInventory { get; set;}

		[Ordinal(0)] [RED("("interactionTestCameraRange")] 		public CBool InteractionTestCameraRange { get; set;}

		[Ordinal(0)] [RED("("interactionTestCameraRangeAngle")] 		public CFloat InteractionTestCameraRangeAngle { get; set;}

		[Ordinal(0)] [RED("("interactionTestPlayerRange")] 		public CBool InteractionTestPlayerRange { get; set;}

		[Ordinal(0)] [RED("("interactionTestPlayerRangeAngle")] 		public CFloat InteractionTestPlayerRangeAngle { get; set;}

		[Ordinal(0)] [RED("("interactionTestIsInPlayerRadius")] 		public CBool InteractionTestIsInPlayerRadius { get; set;}

		[Ordinal(0)] [RED("("interactionTestPlayerRadius")] 		public CFloat InteractionTestPlayerRadius { get; set;}

		[Ordinal(0)] [RED("("forceLookAtPlayer")] 		public CBool ForceLookAtPlayer { get; set;}

		[Ordinal(0)] [RED("("forceLookAtPlayerDist")] 		public CFloat ForceLookAtPlayerDist { get; set;}

		[Ordinal(0)] [RED("("useBehaviorLod")] 		public CBool UseBehaviorLod { get; set;}

		[Ordinal(0)] [RED("("forceBehaviorLod")] 		public CBool ForceBehaviorLod { get; set;}

		[Ordinal(0)] [RED("("forceBehaviorLodLevel")] 		public CInt32 ForceBehaviorLodLevel { get; set;}

		[Ordinal(0)] [RED("("logMissingAnimations")] 		public CBool LogMissingAnimations { get; set;}

		[Ordinal(0)] [RED("("logRequestedAnimations")] 		public CBool LogRequestedAnimations { get; set;}

		[Ordinal(0)] [RED("("logSampledAnimations")] 		public CBool LogSampledAnimations { get; set;}

		[Ordinal(0)] [RED("("animationMultiUpdate")] 		public CBool AnimationMultiUpdate { get; set;}

		[Ordinal(0)] [RED("("animationAsyncUpdate")] 		public CBool AnimationAsyncUpdate { get; set;}

		[Ordinal(0)] [RED("("animationAsyncJobs")] 		public CBool AnimationAsyncJobs { get; set;}

		[Ordinal(0)] [RED("("animationCanUseAsyncJobs")] 		public CBool AnimationCanUseAsyncJobs { get; set;}

		[Ordinal(0)] [RED("("animationAsyncJobsUpdateFrustum")] 		public CBool AnimationAsyncJobsUpdateFrustum { get; set;}

		[Ordinal(0)] [RED("("useWorkFreezing")] 		public CBool UseWorkFreezing { get; set;}

		[Ordinal(0)] [RED("("streamOnlyVisibleLayers")] 		public CBool StreamOnlyVisibleLayers { get; set;}

		[Ordinal(0)] [RED("("workFreezingRadiusForInvisibleActors")] 		public CFloat WorkFreezingRadiusForInvisibleActors { get; set;}

		[Ordinal(0)] [RED("("workSynchronization")] 		public CBool WorkSynchronization { get; set;}

		[Ordinal(0)] [RED("("workResetInFreezing")] 		public CBool WorkResetInFreezing { get; set;}

		[Ordinal(0)] [RED("("workFreezingDelay")] 		public CFloat WorkFreezingDelay { get; set;}

		[Ordinal(0)] [RED("("workMaxFreezingTime")] 		public CFloat WorkMaxFreezingTime { get; set;}

		[Ordinal(0)] [RED("("workAnimSpeedMulMin")] 		public CFloat WorkAnimSpeedMulMin { get; set;}

		[Ordinal(0)] [RED("("workAnimSpeedMulMax")] 		public CFloat WorkAnimSpeedMulMax { get; set;}

		[Ordinal(0)] [RED("("workMaxAnimOffset")] 		public CFloat WorkMaxAnimOffset { get; set;}

		[Ordinal(0)] [RED("("lookAtConfig")] 		public SGameplayConfigLookAts LookAtConfig { get; set;}

		[Ordinal(0)] [RED("("cameraHidePlayerDistMin")] 		public CFloat CameraHidePlayerDistMin { get; set;}

		[Ordinal(0)] [RED("("cameraHidePlayerDistMax")] 		public CFloat CameraHidePlayerDistMax { get; set;}

		[Ordinal(0)] [RED("("cameraHidePlayerSwordsDistMin")] 		public CFloat CameraHidePlayerSwordsDistMin { get; set;}

		[Ordinal(0)] [RED("("cameraHidePlayerSwordsDistMax")] 		public CFloat CameraHidePlayerSwordsDistMax { get; set;}

		[Ordinal(0)] [RED("("cameraHidePlayerSwordsAngleMin")] 		public CFloat CameraHidePlayerSwordsAngleMin { get; set;}

		[Ordinal(0)] [RED("("cameraHidePlayerSwordsAngleMax")] 		public CFloat CameraHidePlayerSwordsAngleMax { get; set;}

		[Ordinal(0)] [RED("("cameraPositionDamp")] 		public CBool CameraPositionDamp { get; set;}

		[Ordinal(0)] [RED("("cameraPositionDampLength")] 		public CFloat CameraPositionDampLength { get; set;}

		[Ordinal(0)] [RED("("cameraPositionDampLengthOffset")] 		public CFloat CameraPositionDampLengthOffset { get; set;}

		[Ordinal(0)] [RED("("cameraPositionDampSpeed")] 		public CFloat CameraPositionDampSpeed { get; set;}

		[Ordinal(0)] [RED("("processNpcsAndCameraCollisions")] 		public CBool ProcessNpcsAndCameraCollisions { get; set;}

		[Ordinal(0)] [RED("("physicsTerrainAdditionalElevation")] 		public CFloat PhysicsTerrainAdditionalElevation { get; set;}

		[Ordinal(0)] [RED("("physicsTerrainThickness")] 		public CFloat PhysicsTerrainThickness { get; set;}

		[Ordinal(0)] [RED("("physicsKillingZVelocity")] 		public CFloat PhysicsKillingZVelocity { get; set;}

		[Ordinal(0)] [RED("("physicsTerrainDebugMaxSlope")] 		public CFloat PhysicsTerrainDebugMaxSlope { get; set;}

		[Ordinal(0)] [RED("("physicsTerrainDebugRange")] 		public CFloat PhysicsTerrainDebugRange { get; set;}

		[Ordinal(0)] [RED("("physicsCollisionPredictionTime")] 		public CFloat PhysicsCollisionPredictionTime { get; set;}

		[Ordinal(0)] [RED("("physicsCollisionPredictionSteps")] 		public CUInt32 PhysicsCollisionPredictionSteps { get; set;}

		[Ordinal(0)] [RED("("physicsCCTMaxDisp")] 		public CFloat PhysicsCCTMaxDisp { get; set;}

		[Ordinal(0)] [RED("("virtualRadiusTime")] 		public CFloat VirtualRadiusTime { get; set;}

		[Ordinal(0)] [RED("("movingSwimmingOffset")] 		public CFloat MovingSwimmingOffset { get; set;}

		[Ordinal(0)] [RED("("emergeSpeed")] 		public CFloat EmergeSpeed { get; set;}

		[Ordinal(0)] [RED("("submergeSpeed")] 		public CFloat SubmergeSpeed { get; set;}

		[Ordinal(0)] [RED("("terrainInfluenceLimitMin")] 		public CFloat TerrainInfluenceLimitMin { get; set;}

		[Ordinal(0)] [RED("("terrainInfluenceLimitMax")] 		public CFloat TerrainInfluenceLimitMax { get; set;}

		[Ordinal(0)] [RED("("terrainInfluenceMul")] 		public CFloat TerrainInfluenceMul { get; set;}

		[Ordinal(0)] [RED("("slidingLimitMin")] 		public CFloat SlidingLimitMin { get; set;}

		[Ordinal(0)] [RED("("slidingLimitMax")] 		public CFloat SlidingLimitMax { get; set;}

		[Ordinal(0)] [RED("("slidingDamping")] 		public CFloat SlidingDamping { get; set;}

		[Ordinal(0)] [RED("("maxPlatformDisplacement")] 		public CFloat MaxPlatformDisplacement { get; set;}

		[Ordinal(0)] [RED("("showSegments")] 		public CBool ShowSegments { get; set;}

		[Ordinal(0)] [RED("("showRotations")] 		public CBool ShowRotations { get; set;}

		[Ordinal(0)] [RED("("showNodes")] 		public CBool ShowNodes { get; set;}

		[Ordinal(0)] [RED("("curvePrecision")] 		public CInt32 CurvePrecision { get; set;}

		[Ordinal(0)] [RED("("timeScale")] 		public CFloat TimeScale { get; set;}

		[Ordinal(0)] [RED("("gcAfterCutscenesWithCamera")] 		public CBool GcAfterCutscenesWithCamera { get; set;}

		[Ordinal(0)] [RED("("gcAfterNotGameplayScenes")] 		public CBool GcAfterNotGameplayScenes { get; set;}

		[Ordinal(0)] [RED("("autosaveCooldown")] 		public CFloat AutosaveCooldown { get; set;}

		[Ordinal(0)] [RED("("autosaveDelay")] 		public CFloat AutosaveDelay { get; set;}

		[Ordinal(0)] [RED("("doNotClickMe")] 		public CBool DoNotClickMe { get; set;}

		[Ordinal(0)] [RED("("disableResetInput")] 		public CBool DisableResetInput { get; set;}

		[Ordinal(0)] [RED("("enableMeshFlushInScenes")] 		public CBool EnableMeshFlushInScenes { get; set;}

		[Ordinal(0)] [RED("("enableSceneRewind")] 		public CBool EnableSceneRewind { get; set;}

		[Ordinal(0)] [RED("("enableTextureFlushInScenes")] 		public CBool EnableTextureFlushInScenes { get; set;}

		[Ordinal(0)] [RED("("enableAnimationFlushInScenes")] 		public CBool EnableAnimationFlushInScenes { get; set;}

		[Ordinal(0)] [RED("("enableSimplePriorityLoadingInScenes")] 		public CBool EnableSimplePriorityLoadingInScenes { get; set;}

		[Ordinal(0)] [RED("("useFrozenFrameInsteadOfBlackscreen")] 		public CBool UseFrozenFrameInsteadOfBlackscreen { get; set;}

		[Ordinal(0)] [RED("("sceneIgnoreInputDuration")] 		public CFloat SceneIgnoreInputDuration { get; set;}

		[Ordinal(0)] [RED("("movementTorsoDamp")] 		public CFloat MovementTorsoDamp { get; set;}

		[Ordinal(0)] [RED("("movementRotDamp")] 		public CFloat MovementRotDamp { get; set;}

		[Ordinal(0)] [RED("("movementSmoothing")] 		public CFloat MovementSmoothing { get; set;}

		[Ordinal(0)] [RED("("movementSmoothingOnHorse")] 		public CFloat MovementSmoothingOnHorse { get; set;}

		[Ordinal(0)] [RED("("idUseNewVoicePipeline")] 		public CBool IdUseNewVoicePipeline { get; set;}

		[Ordinal(0)] [RED("("woundDistanceWeight")] 		public CFloat WoundDistanceWeight { get; set;}

		[Ordinal(0)] [RED("("woundDirectionWeight")] 		public CFloat WoundDirectionWeight { get; set;}

		public SGameplayConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}