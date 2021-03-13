using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayConfig : CVariable
	{
		[Ordinal(1)] [RED("gameCamera")] 		public SGameplayConfigGameCamera GameCamera { get; set;}

		[Ordinal(2)] [RED("LOD")] 		public SGameplayLODConfig LOD { get; set;}

		[Ordinal(3)] [RED("debugA")] 		public CFloat DebugA { get; set;}

		[Ordinal(4)] [RED("debugB")] 		public CFloat DebugB { get; set;}

		[Ordinal(5)] [RED("debugC")] 		public CFloat DebugC { get; set;}

		[Ordinal(6)] [RED("debugD")] 		public CFloat DebugD { get; set;}

		[Ordinal(7)] [RED("debugE")] 		public CFloat DebugE { get; set;}

		[Ordinal(8)] [RED("debugF")] 		public CFloat DebugF { get; set;}

		[Ordinal(9)] [RED("debugG")] 		public CFloat DebugG { get; set;}

		[Ordinal(10)] [RED("horseProp")] 		public CBool HorseProp { get; set;}

		[Ordinal(11)] [RED("horseSpeedCtrl")] 		public CBool HorseSpeedCtrl { get; set;}

		[Ordinal(12)] [RED("horseSpeedInc")] 		public CFloat HorseSpeedInc { get; set;}

		[Ordinal(13)] [RED("horseSpeedDec")] 		public CFloat HorseSpeedDec { get; set;}

		[Ordinal(14)] [RED("horseSpeedStep")] 		public CFloat HorseSpeedStep { get; set;}

		[Ordinal(15)] [RED("horseInputCooldown")] 		public CFloat HorseInputCooldown { get; set;}

		[Ordinal(16)] [RED("horseStaminaInc")] 		public CFloat HorseStaminaInc { get; set;}

		[Ordinal(17)] [RED("horseStaminaDec")] 		public CFloat HorseStaminaDec { get; set;}

		[Ordinal(18)] [RED("horseStaminaCooldown")] 		public CFloat HorseStaminaCooldown { get; set;}

		[Ordinal(19)] [RED("horseSpeedDecCooldown")] 		public CFloat HorseSpeedDecCooldown { get; set;}

		[Ordinal(20)] [RED("horsePathFactor")] 		public CFloat HorsePathFactor { get; set;}

		[Ordinal(21)] [RED("horsePathDamping")] 		public CFloat HorsePathDamping { get; set;}

		[Ordinal(22)] [RED("horseRoadSearchRadius")] 		public CFloat HorseRoadSearchRadius { get; set;}

		[Ordinal(23)] [RED("horseRoadSearchDistanceSlow")] 		public CFloat HorseRoadSearchDistanceSlow { get; set;}

		[Ordinal(24)] [RED("horseRoadSearchDistanceFast")] 		public CFloat HorseRoadSearchDistanceFast { get; set;}

		[Ordinal(25)] [RED("horseRoadSelectionAngleCoeff")] 		public CFloat HorseRoadSelectionAngleCoeff { get; set;}

		[Ordinal(26)] [RED("horseRoadSelectionDistanceCoeff")] 		public CFloat HorseRoadSelectionDistanceCoeff { get; set;}

		[Ordinal(27)] [RED("horseRoadSelectionCurrentRoadPreferenceCoeff")] 		public CFloat HorseRoadSelectionCurrentRoadPreferenceCoeff { get; set;}

		[Ordinal(28)] [RED("horseRoadSelectionTurnAmountFeeCoeff")] 		public CFloat HorseRoadSelectionTurnAmountFeeCoeff { get; set;}

		[Ordinal(29)] [RED("horseRoadFollowingCooldownTime")] 		public CFloat HorseRoadFollowingCooldownTime { get; set;}

		[Ordinal(30)] [RED("horseRoadFollowingCooldownDistance")] 		public CFloat HorseRoadFollowingCooldownDistance { get; set;}

		[Ordinal(31)] [RED("strayActorDespawnDistance")] 		public CFloat StrayActorDespawnDistance { get; set;}

		[Ordinal(32)] [RED("strayActorMaxHoursToKeep")] 		public CInt32 StrayActorMaxHoursToKeep { get; set;}

		[Ordinal(33)] [RED("strayActorMaxActorsToKeep")] 		public CInt32 StrayActorMaxActorsToKeep { get; set;}

		[Ordinal(34)] [RED("playerPreviewInventory")] 		public CInt32 PlayerPreviewInventory { get; set;}

		[Ordinal(35)] [RED("interactionTestCameraRange")] 		public CBool InteractionTestCameraRange { get; set;}

		[Ordinal(36)] [RED("interactionTestCameraRangeAngle")] 		public CFloat InteractionTestCameraRangeAngle { get; set;}

		[Ordinal(37)] [RED("interactionTestPlayerRange")] 		public CBool InteractionTestPlayerRange { get; set;}

		[Ordinal(38)] [RED("interactionTestPlayerRangeAngle")] 		public CFloat InteractionTestPlayerRangeAngle { get; set;}

		[Ordinal(39)] [RED("interactionTestIsInPlayerRadius")] 		public CBool InteractionTestIsInPlayerRadius { get; set;}

		[Ordinal(40)] [RED("interactionTestPlayerRadius")] 		public CFloat InteractionTestPlayerRadius { get; set;}

		[Ordinal(41)] [RED("forceLookAtPlayer")] 		public CBool ForceLookAtPlayer { get; set;}

		[Ordinal(42)] [RED("forceLookAtPlayerDist")] 		public CFloat ForceLookAtPlayerDist { get; set;}

		[Ordinal(43)] [RED("useBehaviorLod")] 		public CBool UseBehaviorLod { get; set;}

		[Ordinal(44)] [RED("forceBehaviorLod")] 		public CBool ForceBehaviorLod { get; set;}

		[Ordinal(45)] [RED("forceBehaviorLodLevel")] 		public CInt32 ForceBehaviorLodLevel { get; set;}

		[Ordinal(46)] [RED("logMissingAnimations")] 		public CBool LogMissingAnimations { get; set;}

		[Ordinal(47)] [RED("logRequestedAnimations")] 		public CBool LogRequestedAnimations { get; set;}

		[Ordinal(48)] [RED("logSampledAnimations")] 		public CBool LogSampledAnimations { get; set;}

		[Ordinal(49)] [RED("animationMultiUpdate")] 		public CBool AnimationMultiUpdate { get; set;}

		[Ordinal(50)] [RED("animationAsyncUpdate")] 		public CBool AnimationAsyncUpdate { get; set;}

		[Ordinal(51)] [RED("animationAsyncJobs")] 		public CBool AnimationAsyncJobs { get; set;}

		[Ordinal(52)] [RED("animationCanUseAsyncJobs")] 		public CBool AnimationCanUseAsyncJobs { get; set;}

		[Ordinal(53)] [RED("animationAsyncJobsUpdateFrustum")] 		public CBool AnimationAsyncJobsUpdateFrustum { get; set;}

		[Ordinal(54)] [RED("useWorkFreezing")] 		public CBool UseWorkFreezing { get; set;}

		[Ordinal(55)] [RED("streamOnlyVisibleLayers")] 		public CBool StreamOnlyVisibleLayers { get; set;}

		[Ordinal(56)] [RED("workFreezingRadiusForInvisibleActors")] 		public CFloat WorkFreezingRadiusForInvisibleActors { get; set;}

		[Ordinal(57)] [RED("workSynchronization")] 		public CBool WorkSynchronization { get; set;}

		[Ordinal(58)] [RED("workResetInFreezing")] 		public CBool WorkResetInFreezing { get; set;}

		[Ordinal(59)] [RED("workFreezingDelay")] 		public CFloat WorkFreezingDelay { get; set;}

		[Ordinal(60)] [RED("workMaxFreezingTime")] 		public CFloat WorkMaxFreezingTime { get; set;}

		[Ordinal(61)] [RED("workAnimSpeedMulMin")] 		public CFloat WorkAnimSpeedMulMin { get; set;}

		[Ordinal(62)] [RED("workAnimSpeedMulMax")] 		public CFloat WorkAnimSpeedMulMax { get; set;}

		[Ordinal(63)] [RED("workMaxAnimOffset")] 		public CFloat WorkMaxAnimOffset { get; set;}

		[Ordinal(64)] [RED("lookAtConfig")] 		public SGameplayConfigLookAts LookAtConfig { get; set;}

		[Ordinal(65)] [RED("cameraHidePlayerDistMin")] 		public CFloat CameraHidePlayerDistMin { get; set;}

		[Ordinal(66)] [RED("cameraHidePlayerDistMax")] 		public CFloat CameraHidePlayerDistMax { get; set;}

		[Ordinal(67)] [RED("cameraHidePlayerSwordsDistMin")] 		public CFloat CameraHidePlayerSwordsDistMin { get; set;}

		[Ordinal(68)] [RED("cameraHidePlayerSwordsDistMax")] 		public CFloat CameraHidePlayerSwordsDistMax { get; set;}

		[Ordinal(69)] [RED("cameraHidePlayerSwordsAngleMin")] 		public CFloat CameraHidePlayerSwordsAngleMin { get; set;}

		[Ordinal(70)] [RED("cameraHidePlayerSwordsAngleMax")] 		public CFloat CameraHidePlayerSwordsAngleMax { get; set;}

		[Ordinal(71)] [RED("cameraPositionDamp")] 		public CBool CameraPositionDamp { get; set;}

		[Ordinal(72)] [RED("cameraPositionDampLength")] 		public CFloat CameraPositionDampLength { get; set;}

		[Ordinal(73)] [RED("cameraPositionDampLengthOffset")] 		public CFloat CameraPositionDampLengthOffset { get; set;}

		[Ordinal(74)] [RED("cameraPositionDampSpeed")] 		public CFloat CameraPositionDampSpeed { get; set;}

		[Ordinal(75)] [RED("processNpcsAndCameraCollisions")] 		public CBool ProcessNpcsAndCameraCollisions { get; set;}

		[Ordinal(76)] [RED("physicsTerrainAdditionalElevation")] 		public CFloat PhysicsTerrainAdditionalElevation { get; set;}

		[Ordinal(77)] [RED("physicsTerrainThickness")] 		public CFloat PhysicsTerrainThickness { get; set;}

		[Ordinal(78)] [RED("physicsKillingZVelocity")] 		public CFloat PhysicsKillingZVelocity { get; set;}

		[Ordinal(79)] [RED("physicsTerrainDebugMaxSlope")] 		public CFloat PhysicsTerrainDebugMaxSlope { get; set;}

		[Ordinal(80)] [RED("physicsTerrainDebugRange")] 		public CFloat PhysicsTerrainDebugRange { get; set;}

		[Ordinal(81)] [RED("physicsCollisionPredictionTime")] 		public CFloat PhysicsCollisionPredictionTime { get; set;}

		[Ordinal(82)] [RED("physicsCollisionPredictionSteps")] 		public CUInt32 PhysicsCollisionPredictionSteps { get; set;}

		[Ordinal(83)] [RED("physicsCCTMaxDisp")] 		public CFloat PhysicsCCTMaxDisp { get; set;}

		[Ordinal(84)] [RED("virtualRadiusTime")] 		public CFloat VirtualRadiusTime { get; set;}

		[Ordinal(85)] [RED("movingSwimmingOffset")] 		public CFloat MovingSwimmingOffset { get; set;}

		[Ordinal(86)] [RED("emergeSpeed")] 		public CFloat EmergeSpeed { get; set;}

		[Ordinal(87)] [RED("submergeSpeed")] 		public CFloat SubmergeSpeed { get; set;}

		[Ordinal(88)] [RED("terrainInfluenceLimitMin")] 		public CFloat TerrainInfluenceLimitMin { get; set;}

		[Ordinal(89)] [RED("terrainInfluenceLimitMax")] 		public CFloat TerrainInfluenceLimitMax { get; set;}

		[Ordinal(90)] [RED("terrainInfluenceMul")] 		public CFloat TerrainInfluenceMul { get; set;}

		[Ordinal(91)] [RED("slidingLimitMin")] 		public CFloat SlidingLimitMin { get; set;}

		[Ordinal(92)] [RED("slidingLimitMax")] 		public CFloat SlidingLimitMax { get; set;}

		[Ordinal(93)] [RED("slidingDamping")] 		public CFloat SlidingDamping { get; set;}

		[Ordinal(94)] [RED("maxPlatformDisplacement")] 		public CFloat MaxPlatformDisplacement { get; set;}

		[Ordinal(95)] [RED("showSegments")] 		public CBool ShowSegments { get; set;}

		[Ordinal(96)] [RED("showRotations")] 		public CBool ShowRotations { get; set;}

		[Ordinal(97)] [RED("showNodes")] 		public CBool ShowNodes { get; set;}

		[Ordinal(98)] [RED("curvePrecision")] 		public CInt32 CurvePrecision { get; set;}

		[Ordinal(99)] [RED("timeScale")] 		public CFloat TimeScale { get; set;}

		[Ordinal(100)] [RED("gcAfterCutscenesWithCamera")] 		public CBool GcAfterCutscenesWithCamera { get; set;}

		[Ordinal(101)] [RED("gcAfterNotGameplayScenes")] 		public CBool GcAfterNotGameplayScenes { get; set;}

		[Ordinal(102)] [RED("autosaveCooldown")] 		public CFloat AutosaveCooldown { get; set;}

		[Ordinal(103)] [RED("autosaveDelay")] 		public CFloat AutosaveDelay { get; set;}

		[Ordinal(104)] [RED("doNotClickMe")] 		public CBool DoNotClickMe { get; set;}

		[Ordinal(105)] [RED("disableResetInput")] 		public CBool DisableResetInput { get; set;}

		[Ordinal(106)] [RED("enableMeshFlushInScenes")] 		public CBool EnableMeshFlushInScenes { get; set;}

		[Ordinal(107)] [RED("enableSceneRewind")] 		public CBool EnableSceneRewind { get; set;}

		[Ordinal(108)] [RED("enableTextureFlushInScenes")] 		public CBool EnableTextureFlushInScenes { get; set;}

		[Ordinal(109)] [RED("enableAnimationFlushInScenes")] 		public CBool EnableAnimationFlushInScenes { get; set;}

		[Ordinal(110)] [RED("enableSimplePriorityLoadingInScenes")] 		public CBool EnableSimplePriorityLoadingInScenes { get; set;}

		[Ordinal(111)] [RED("useFrozenFrameInsteadOfBlackscreen")] 		public CBool UseFrozenFrameInsteadOfBlackscreen { get; set;}

		[Ordinal(112)] [RED("sceneIgnoreInputDuration")] 		public CFloat SceneIgnoreInputDuration { get; set;}

		[Ordinal(113)] [RED("movementTorsoDamp")] 		public CFloat MovementTorsoDamp { get; set;}

		[Ordinal(114)] [RED("movementRotDamp")] 		public CFloat MovementRotDamp { get; set;}

		[Ordinal(115)] [RED("movementSmoothing")] 		public CFloat MovementSmoothing { get; set;}

		[Ordinal(116)] [RED("movementSmoothingOnHorse")] 		public CFloat MovementSmoothingOnHorse { get; set;}

		[Ordinal(117)] [RED("idUseNewVoicePipeline")] 		public CBool IdUseNewVoicePipeline { get; set;}

		[Ordinal(118)] [RED("woundDistanceWeight")] 		public CFloat WoundDistanceWeight { get; set;}

		[Ordinal(119)] [RED("woundDirectionWeight")] 		public CFloat WoundDirectionWeight { get; set;}

		public SGameplayConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}