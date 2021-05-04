using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationSharedData : CObject
	{
		[Ordinal(1)] [RED("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[Ordinal(2)] [RED("m_AutoJumpOnPredictionB")] 		public CBool M_AutoJumpOnPredictionB { get; set;}

		[Ordinal(3)] [RED("m_AutoJumpToWaterB")] 		public CBool M_AutoJumpToWaterB { get; set;}

		[Ordinal(4)] [RED("m_TimeSinceIdleF")] 		public CFloat M_TimeSinceIdleF { get; set;}

		[Ordinal(5)] [RED("m_SprintJumpTimePreparingF")] 		public CFloat M_SprintJumpTimePreparingF { get; set;}

		[Ordinal(6)] [RED("m_BehParamRightFootS")] 		public CName M_BehParamRightFootS { get; set;}

		[Ordinal(7)] [RED("m_IsRightFootForwardB")] 		public CBool M_IsRightFootForwardB { get; set;}

		[Ordinal(8)] [RED("m_JumpTypeE")] 		public CEnum<EJumpType> M_JumpTypeE { get; set;}

		[Ordinal(9)] [RED("m_LandingOnWater")] 		public CBool M_LandingOnWater { get; set;}

		[Ordinal(10)] [RED("m_JumpIsTooSoonToLandB")] 		public CBool M_JumpIsTooSoonToLandB { get; set;}

		[Ordinal(11)] [RED("m_FallHeightReachedF")] 		public CFloat M_FallHeightReachedF { get; set;}

		[Ordinal(12)] [RED("m_UsePantherJumpB")] 		public CBool M_UsePantherJumpB { get; set;}

		[Ordinal(13)] [RED("m_AirCollisionIsFrontal")] 		public CBool M_AirCollisionIsFrontal { get; set;}

		[Ordinal(14)] [RED("m_JumpDirectionForcedV")] 		public Vector M_JumpDirectionForcedV { get; set;}

		[Ordinal(15)] [RED("m_CanFallSetVelocityB")] 		public CBool M_CanFallSetVelocityB { get; set;}

		[Ordinal(16)] [RED("m_ShouldFlipFootOnLandB")] 		public CBool M_ShouldFlipFootOnLandB { get; set;}

		[Ordinal(17)] [RED("m_DontRecalcFootOnLandB")] 		public CBool M_DontRecalcFootOnLandB { get; set;}

		[Ordinal(18)] [RED("m_FromCriticalB")] 		public CBool M_FromCriticalB { get; set;}

		[Ordinal(19)] [RED("m_ClimbStateTypeE")] 		public CEnum<EClimbRequirementType> M_ClimbStateTypeE { get; set;}

		[Ordinal(20)] [RED("m_AirCollisionSideEnabledB")] 		public CBool M_AirCollisionSideEnabledB { get; set;}

		[Ordinal(21)] [RED("m_SkipLandAnimDistMaxF")] 		public CFloat M_SkipLandAnimDistMaxF { get; set;}

		[Ordinal(22)] [RED("m_SkipLandAnimTimeMaxF")] 		public CFloat M_SkipLandAnimTimeMaxF { get; set;}

		[Ordinal(23)] [RED("m_SkateGlobalC")] 		public CHandle<CExplorationSkatingGlobal> M_SkateGlobalC { get; set;}

		[Ordinal(24)] [RED("m_LastExplorationS")] 		public SExplorationQueryToken M_LastExplorationS { get; set;}

		[Ordinal(25)] [RED("m_LastExplorationValidB")] 		public CBool M_LastExplorationValidB { get; set;}

		[Ordinal(26)] [RED("m_AngleToExploreManualF")] 		public CFloat M_AngleToExploreManualF { get; set;}

		[Ordinal(27)] [RED("m_AngleToExploreAutoF")] 		public CFloat M_AngleToExploreAutoF { get; set;}

		[Ordinal(28)] [RED("hasToRecoverFromRagdoll")] 		public CBool HasToRecoverFromRagdoll { get; set;}

		[Ordinal(29)] [RED("m_TeleportTimeCurF")] 		public CFloat M_TeleportTimeCurF { get; set;}

		[Ordinal(30)] [RED("m_TeleportTimeMaxF")] 		public CFloat M_TeleportTimeMaxF { get; set;}

		[Ordinal(31)] [RED("terrainSlidePresetName")] 		public CName TerrainSlidePresetName { get; set;}

		[Ordinal(32)] [RED("terrainBlendSpeedCur")] 		public CFloat TerrainBlendSpeedCur { get; set;}

		[Ordinal(33)] [RED("terrainBlendSpeedTarget")] 		public CFloat TerrainBlendSpeedTarget { get; set;}

		[Ordinal(34)] [RED("terrainBlendTimeCur")] 		public CFloat TerrainBlendTimeCur { get; set;}

		[Ordinal(35)] [RED("terrainBlendTimeMax")] 		public CFloat TerrainBlendTimeMax { get; set;}

		[Ordinal(36)] [RED("m_JumpSwimRotationF")] 		public CFloat M_JumpSwimRotationF { get; set;}

		[Ordinal(37)] [RED("m_JumpToWaterAreaB")] 		public CBool M_JumpToWaterAreaB { get; set;}

		[Ordinal(38)] [RED("m_JumpToWaterForcedDirV")] 		public Vector M_JumpToWaterForcedDirV { get; set;}

		[Ordinal(39)] [RED("m_JumpToWaterRequireDirB")] 		public CBool M_JumpToWaterRequireDirB { get; set;}

		[Ordinal(40)] [RED("m_JumpToWaterRequireSprintB")] 		public CBool M_JumpToWaterRequireSprintB { get; set;}

		[Ordinal(41)] [RED("m_HeightFallenF")] 		public CFloat M_HeightFallenF { get; set;}

		[Ordinal(42)] [RED("lastPosition")] 		public Vector LastPosition { get; set;}

		[Ordinal(43)] [RED("landAddAdding")] 		public CBool LandAddAdding { get; set;}

		[Ordinal(44)] [RED("landAddCurrent")] 		public CFloat LandAddCurrent { get; set;}

		[Ordinal(45)] [RED("landAddCurve")] 		public CHandle<CCurve> LandAddCurve { get; set;}

		[Ordinal(46)] [RED("landAddCoef")] 		public CFloat LandAddCoef { get; set;}

		[Ordinal(47)] [RED("landAddCoefWalk")] 		public CFloat LandAddCoefWalk { get; set;}

		[Ordinal(48)] [RED("landAddTimeCoefWalk")] 		public CFloat LandAddTimeCoefWalk { get; set;}

		[Ordinal(49)] [RED("landAddTimeCur")] 		public CFloat LandAddTimeCur { get; set;}

		[Ordinal(50)] [RED("landAddSpeedCancel")] 		public CFloat LandAddSpeedCancel { get; set;}

		[Ordinal(51)] [RED("landAddTimeCoef")] 		public CFloat LandAddTimeCoef { get; set;}

		[Ordinal(52)] [RED("landAddTimeCoefFast")] 		public CFloat LandAddTimeCoefFast { get; set;}

		[Ordinal(53)] [RED("landAddBehVarName")] 		public CName LandAddBehVarName { get; set;}

		[Ordinal(54)] [RED("m_CameraModifyOffsetB")] 		public CBool M_CameraModifyOffsetB { get; set;}

		[Ordinal(55)] [RED("m_UsePrototypeAnimationsB")] 		public CBool M_UsePrototypeAnimationsB { get; set;}

		[Ordinal(56)] [RED("m_ForceOnlyJumpB")] 		public CBool M_ForceOnlyJumpB { get; set;}

		[Ordinal(57)] [RED("m_UseClimbB")] 		public CBool M_UseClimbB { get; set;}

		[Ordinal(58)] [RED("m_UsepushB")] 		public CBool M_UsepushB { get; set;}

		[Ordinal(59)] [RED("hackKnockBackAlways")] 		public CBool HackKnockBackAlways { get; set;}

		public CExplorationSharedData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}