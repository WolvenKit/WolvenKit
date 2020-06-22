using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayConfig : CVariable
	{
		[RED("gameCamera")] 		public SGameplayConfigGameCamera GameCamera { get; set;}

		[RED("LOD")] 		public SGameplayLODConfig LOD { get; set;}

		[RED("debugA")] 		public CFloat DebugA { get; set;}

		[RED("debugB")] 		public CFloat DebugB { get; set;}

		[RED("debugC")] 		public CFloat DebugC { get; set;}

		[RED("debugD")] 		public CFloat DebugD { get; set;}

		[RED("debugE")] 		public CFloat DebugE { get; set;}

		[RED("debugF")] 		public CFloat DebugF { get; set;}

		[RED("debugG")] 		public CFloat DebugG { get; set;}

		[RED("horseProp")] 		public CBool HorseProp { get; set;}

		[RED("horseSpeedCtrl")] 		public CBool HorseSpeedCtrl { get; set;}

		[RED("horseSpeedInc")] 		public CFloat HorseSpeedInc { get; set;}

		[RED("horseSpeedDec")] 		public CFloat HorseSpeedDec { get; set;}

		[RED("horseSpeedStep")] 		public CFloat HorseSpeedStep { get; set;}

		[RED("horseInputCooldown")] 		public CFloat HorseInputCooldown { get; set;}

		[RED("horseStaminaInc")] 		public CFloat HorseStaminaInc { get; set;}

		[RED("horseStaminaDec")] 		public CFloat HorseStaminaDec { get; set;}

		[RED("horseStaminaCooldown")] 		public CFloat HorseStaminaCooldown { get; set;}

		[RED("horseSpeedDecCooldown")] 		public CFloat HorseSpeedDecCooldown { get; set;}

		[RED("horsePathFactor")] 		public CFloat HorsePathFactor { get; set;}

		[RED("horsePathDamping")] 		public CFloat HorsePathDamping { get; set;}

		[RED("horseRoadSearchRadius")] 		public CFloat HorseRoadSearchRadius { get; set;}

		[RED("horseRoadSearchDistanceSlow")] 		public CFloat HorseRoadSearchDistanceSlow { get; set;}

		[RED("horseRoadSearchDistanceFast")] 		public CFloat HorseRoadSearchDistanceFast { get; set;}

		[RED("horseRoadSelectionAngleCoeff")] 		public CFloat HorseRoadSelectionAngleCoeff { get; set;}

		[RED("horseRoadSelectionDistanceCoeff")] 		public CFloat HorseRoadSelectionDistanceCoeff { get; set;}

		[RED("horseRoadSelectionCurrentRoadPreferenceCoeff")] 		public CFloat HorseRoadSelectionCurrentRoadPreferenceCoeff { get; set;}

		[RED("horseRoadSelectionTurnAmountFeeCoeff")] 		public CFloat HorseRoadSelectionTurnAmountFeeCoeff { get; set;}

		[RED("horseRoadFollowingCooldownTime")] 		public CFloat HorseRoadFollowingCooldownTime { get; set;}

		[RED("horseRoadFollowingCooldownDistance")] 		public CFloat HorseRoadFollowingCooldownDistance { get; set;}

		[RED("strayActorDespawnDistance")] 		public CFloat StrayActorDespawnDistance { get; set;}

		[RED("strayActorMaxHoursToKeep")] 		public CInt32 StrayActorMaxHoursToKeep { get; set;}

		[RED("strayActorMaxActorsToKeep")] 		public CInt32 StrayActorMaxActorsToKeep { get; set;}

		[RED("playerPreviewInventory")] 		public CInt32 PlayerPreviewInventory { get; set;}

		[RED("interactionTestCameraRange")] 		public CBool InteractionTestCameraRange { get; set;}

		[RED("interactionTestCameraRangeAngle")] 		public CFloat InteractionTestCameraRangeAngle { get; set;}

		[RED("interactionTestPlayerRange")] 		public CBool InteractionTestPlayerRange { get; set;}

		[RED("interactionTestPlayerRangeAngle")] 		public CFloat InteractionTestPlayerRangeAngle { get; set;}

		[RED("interactionTestIsInPlayerRadius")] 		public CBool InteractionTestIsInPlayerRadius { get; set;}

		[RED("interactionTestPlayerRadius")] 		public CFloat InteractionTestPlayerRadius { get; set;}

		[RED("forceLookAtPlayer")] 		public CBool ForceLookAtPlayer { get; set;}

		[RED("forceLookAtPlayerDist")] 		public CFloat ForceLookAtPlayerDist { get; set;}

		[RED("useBehaviorLod")] 		public CBool UseBehaviorLod { get; set;}

		[RED("forceBehaviorLod")] 		public CBool ForceBehaviorLod { get; set;}

		[RED("forceBehaviorLodLevel")] 		public CInt32 ForceBehaviorLodLevel { get; set;}

		[RED("logMissingAnimations")] 		public CBool LogMissingAnimations { get; set;}

		[RED("logRequestedAnimations")] 		public CBool LogRequestedAnimations { get; set;}

		[RED("logSampledAnimations")] 		public CBool LogSampledAnimations { get; set;}

		[RED("animationMultiUpdate")] 		public CBool AnimationMultiUpdate { get; set;}

		[RED("animationAsyncUpdate")] 		public CBool AnimationAsyncUpdate { get; set;}

		[RED("animationAsyncJobs")] 		public CBool AnimationAsyncJobs { get; set;}

		[RED("animationCanUseAsyncJobs")] 		public CBool AnimationCanUseAsyncJobs { get; set;}

		[RED("animationAsyncJobsUpdateFrustum")] 		public CBool AnimationAsyncJobsUpdateFrustum { get; set;}

		[RED("useWorkFreezing")] 		public CBool UseWorkFreezing { get; set;}

		[RED("streamOnlyVisibleLayers")] 		public CBool StreamOnlyVisibleLayers { get; set;}

		[RED("workFreezingRadiusForInvisibleActors")] 		public CFloat WorkFreezingRadiusForInvisibleActors { get; set;}

		[RED("workSynchronization")] 		public CBool WorkSynchronization { get; set;}

		[RED("workResetInFreezing")] 		public CBool WorkResetInFreezing { get; set;}

		[RED("workFreezingDelay")] 		public CFloat WorkFreezingDelay { get; set;}

		[RED("workMaxFreezingTime")] 		public CFloat WorkMaxFreezingTime { get; set;}

		[RED("workAnimSpeedMulMin")] 		public CFloat WorkAnimSpeedMulMin { get; set;}

		[RED("workAnimSpeedMulMax")] 		public CFloat WorkAnimSpeedMulMax { get; set;}

		[RED("workMaxAnimOffset")] 		public CFloat WorkMaxAnimOffset { get; set;}

		[RED("lookAtConfig")] 		public SGameplayConfigLookAts LookAtConfig { get; set;}

		[RED("cameraHidePlayerDistMin")] 		public CFloat CameraHidePlayerDistMin { get; set;}

		[RED("cameraHidePlayerDistMax")] 		public CFloat CameraHidePlayerDistMax { get; set;}

		[RED("cameraHidePlayerSwordsDistMin")] 		public CFloat CameraHidePlayerSwordsDistMin { get; set;}

		[RED("cameraHidePlayerSwordsDistMax")] 		public CFloat CameraHidePlayerSwordsDistMax { get; set;}

		[RED("cameraHidePlayerSwordsAngleMin")] 		public CFloat CameraHidePlayerSwordsAngleMin { get; set;}

		[RED("cameraHidePlayerSwordsAngleMax")] 		public CFloat CameraHidePlayerSwordsAngleMax { get; set;}

		[RED("cameraPositionDamp")] 		public CBool CameraPositionDamp { get; set;}

		[RED("cameraPositionDampLength")] 		public CFloat CameraPositionDampLength { get; set;}

		[RED("cameraPositionDampLengthOffset")] 		public CFloat CameraPositionDampLengthOffset { get; set;}

		[RED("cameraPositionDampSpeed")] 		public CFloat CameraPositionDampSpeed { get; set;}

		[RED("processNpcsAndCameraCollisions")] 		public CBool ProcessNpcsAndCameraCollisions { get; set;}

		[RED("physicsTerrainAdditionalElevation")] 		public CFloat PhysicsTerrainAdditionalElevation { get; set;}

		[RED("physicsTerrainThickness")] 		public CFloat PhysicsTerrainThickness { get; set;}

		[RED("physicsKillingZVelocity")] 		public CFloat PhysicsKillingZVelocity { get; set;}

		[RED("physicsTerrainDebugMaxSlope")] 		public CFloat PhysicsTerrainDebugMaxSlope { get; set;}

		[RED("physicsTerrainDebugRange")] 		public CFloat PhysicsTerrainDebugRange { get; set;}

		[RED("physicsCollisionPredictionTime")] 		public CFloat PhysicsCollisionPredictionTime { get; set;}

		[RED("physicsCollisionPredictionSteps")] 		public CUInt32 PhysicsCollisionPredictionSteps { get; set;}

		[RED("physicsCCTMaxDisp")] 		public CFloat PhysicsCCTMaxDisp { get; set;}

		[RED("virtualRadiusTime")] 		public CFloat VirtualRadiusTime { get; set;}

		[RED("movingSwimmingOffset")] 		public CFloat MovingSwimmingOffset { get; set;}

		[RED("emergeSpeed")] 		public CFloat EmergeSpeed { get; set;}

		[RED("submergeSpeed")] 		public CFloat SubmergeSpeed { get; set;}

		[RED("terrainInfluenceLimitMin")] 		public CFloat TerrainInfluenceLimitMin { get; set;}

		[RED("terrainInfluenceLimitMax")] 		public CFloat TerrainInfluenceLimitMax { get; set;}

		[RED("terrainInfluenceMul")] 		public CFloat TerrainInfluenceMul { get; set;}

		[RED("slidingLimitMin")] 		public CFloat SlidingLimitMin { get; set;}

		[RED("slidingLimitMax")] 		public CFloat SlidingLimitMax { get; set;}

		[RED("slidingDamping")] 		public CFloat SlidingDamping { get; set;}

		[RED("maxPlatformDisplacement")] 		public CFloat MaxPlatformDisplacement { get; set;}

		[RED("showSegments")] 		public CBool ShowSegments { get; set;}

		[RED("showRotations")] 		public CBool ShowRotations { get; set;}

		[RED("showNodes")] 		public CBool ShowNodes { get; set;}

		[RED("curvePrecision")] 		public CInt32 CurvePrecision { get; set;}

		[RED("timeScale")] 		public CFloat TimeScale { get; set;}

		[RED("gcAfterCutscenesWithCamera")] 		public CBool GcAfterCutscenesWithCamera { get; set;}

		[RED("gcAfterNotGameplayScenes")] 		public CBool GcAfterNotGameplayScenes { get; set;}

		[RED("autosaveCooldown")] 		public CFloat AutosaveCooldown { get; set;}

		[RED("autosaveDelay")] 		public CFloat AutosaveDelay { get; set;}

		[RED("doNotClickMe")] 		public CBool DoNotClickMe { get; set;}

		[RED("disableResetInput")] 		public CBool DisableResetInput { get; set;}

		[RED("enableMeshFlushInScenes")] 		public CBool EnableMeshFlushInScenes { get; set;}

		[RED("enableSceneRewind")] 		public CBool EnableSceneRewind { get; set;}

		[RED("enableTextureFlushInScenes")] 		public CBool EnableTextureFlushInScenes { get; set;}

		[RED("enableAnimationFlushInScenes")] 		public CBool EnableAnimationFlushInScenes { get; set;}

		[RED("enableSimplePriorityLoadingInScenes")] 		public CBool EnableSimplePriorityLoadingInScenes { get; set;}

		[RED("useFrozenFrameInsteadOfBlackscreen")] 		public CBool UseFrozenFrameInsteadOfBlackscreen { get; set;}

		[RED("sceneIgnoreInputDuration")] 		public CFloat SceneIgnoreInputDuration { get; set;}

		[RED("movementTorsoDamp")] 		public CFloat MovementTorsoDamp { get; set;}

		[RED("movementRotDamp")] 		public CFloat MovementRotDamp { get; set;}

		[RED("movementSmoothing")] 		public CFloat MovementSmoothing { get; set;}

		[RED("movementSmoothingOnHorse")] 		public CFloat MovementSmoothingOnHorse { get; set;}

		[RED("idUseNewVoicePipeline")] 		public CBool IdUseNewVoicePipeline { get; set;}

		[RED("woundDistanceWeight")] 		public CFloat WoundDistanceWeight { get; set;}

		[RED("woundDirectionWeight")] 		public CFloat WoundDirectionWeight { get; set;}

		public SGameplayConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}