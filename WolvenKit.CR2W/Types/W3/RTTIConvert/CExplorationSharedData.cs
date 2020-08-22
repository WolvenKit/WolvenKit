using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationSharedData : CObject
	{
		[RED("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[RED("m_AutoJumpOnPredictionB")] 		public CBool M_AutoJumpOnPredictionB { get; set;}

		[RED("m_AutoJumpToWaterB")] 		public CBool M_AutoJumpToWaterB { get; set;}

		[RED("m_TimeSinceIdleF")] 		public CFloat M_TimeSinceIdleF { get; set;}

		[RED("m_SprintJumpTimePreparingF")] 		public CFloat M_SprintJumpTimePreparingF { get; set;}

		[RED("m_BehParamRightFootS")] 		public CName M_BehParamRightFootS { get; set;}

		[RED("m_IsRightFootForwardB")] 		public CBool M_IsRightFootForwardB { get; set;}

		[RED("m_JumpTypeE")] 		public CEnum<EJumpType> M_JumpTypeE { get; set;}

		[RED("m_LandingOnWater")] 		public CBool M_LandingOnWater { get; set;}

		[RED("m_JumpIsTooSoonToLandB")] 		public CBool M_JumpIsTooSoonToLandB { get; set;}

		[RED("m_FallHeightReachedF")] 		public CFloat M_FallHeightReachedF { get; set;}

		[RED("m_UsePantherJumpB")] 		public CBool M_UsePantherJumpB { get; set;}

		[RED("m_AirCollisionIsFrontal")] 		public CBool M_AirCollisionIsFrontal { get; set;}

		[RED("m_JumpDirectionForcedV")] 		public Vector M_JumpDirectionForcedV { get; set;}

		[RED("m_CanFallSetVelocityB")] 		public CBool M_CanFallSetVelocityB { get; set;}

		[RED("m_ShouldFlipFootOnLandB")] 		public CBool M_ShouldFlipFootOnLandB { get; set;}

		[RED("m_DontRecalcFootOnLandB")] 		public CBool M_DontRecalcFootOnLandB { get; set;}

		[RED("m_FromCriticalB")] 		public CBool M_FromCriticalB { get; set;}

		[RED("m_ClimbStateTypeE")] 		public CEnum<EClimbRequirementType> M_ClimbStateTypeE { get; set;}

		[RED("m_AirCollisionSideEnabledB")] 		public CBool M_AirCollisionSideEnabledB { get; set;}

		[RED("m_SkipLandAnimDistMaxF")] 		public CFloat M_SkipLandAnimDistMaxF { get; set;}

		[RED("m_SkipLandAnimTimeMaxF")] 		public CFloat M_SkipLandAnimTimeMaxF { get; set;}

		[RED("m_SkateGlobalC")] 		public CHandle<CExplorationSkatingGlobal> M_SkateGlobalC { get; set;}

		[RED("m_LastExplorationS")] 		public SExplorationQueryToken M_LastExplorationS { get; set;}

		[RED("m_LastExplorationValidB")] 		public CBool M_LastExplorationValidB { get; set;}

		[RED("m_AngleToExploreManualF")] 		public CFloat M_AngleToExploreManualF { get; set;}

		[RED("m_AngleToExploreAutoF")] 		public CFloat M_AngleToExploreAutoF { get; set;}

		[RED("hasToRecoverFromRagdoll")] 		public CBool HasToRecoverFromRagdoll { get; set;}

		[RED("m_TeleportTimeCurF")] 		public CFloat M_TeleportTimeCurF { get; set;}

		[RED("m_TeleportTimeMaxF")] 		public CFloat M_TeleportTimeMaxF { get; set;}

		[RED("terrainSlidePresetName")] 		public CName TerrainSlidePresetName { get; set;}

		[RED("terrainBlendSpeedCur")] 		public CFloat TerrainBlendSpeedCur { get; set;}

		[RED("terrainBlendSpeedTarget")] 		public CFloat TerrainBlendSpeedTarget { get; set;}

		[RED("terrainBlendTimeCur")] 		public CFloat TerrainBlendTimeCur { get; set;}

		[RED("terrainBlendTimeMax")] 		public CFloat TerrainBlendTimeMax { get; set;}

		[RED("m_JumpSwimRotationF")] 		public CFloat M_JumpSwimRotationF { get; set;}

		[RED("m_JumpToWaterAreaB")] 		public CBool M_JumpToWaterAreaB { get; set;}

		[RED("m_JumpToWaterForcedDirV")] 		public Vector M_JumpToWaterForcedDirV { get; set;}

		[RED("m_JumpToWaterRequireDirB")] 		public CBool M_JumpToWaterRequireDirB { get; set;}

		[RED("m_JumpToWaterRequireSprintB")] 		public CBool M_JumpToWaterRequireSprintB { get; set;}

		[RED("m_HeightFallenF")] 		public CFloat M_HeightFallenF { get; set;}

		[RED("lastPosition")] 		public Vector LastPosition { get; set;}

		[RED("landAddAdding")] 		public CBool LandAddAdding { get; set;}

		[RED("landAddCurrent")] 		public CFloat LandAddCurrent { get; set;}

		[RED("landAddCurve")] 		public CHandle<CCurve> LandAddCurve { get; set;}

		[RED("landAddCoef")] 		public CFloat LandAddCoef { get; set;}

		[RED("landAddCoefWalk")] 		public CFloat LandAddCoefWalk { get; set;}

		[RED("landAddTimeCoefWalk")] 		public CFloat LandAddTimeCoefWalk { get; set;}

		[RED("landAddTimeCur")] 		public CFloat LandAddTimeCur { get; set;}

		[RED("landAddSpeedCancel")] 		public CFloat LandAddSpeedCancel { get; set;}

		[RED("landAddTimeCoef")] 		public CFloat LandAddTimeCoef { get; set;}

		[RED("landAddTimeCoefFast")] 		public CFloat LandAddTimeCoefFast { get; set;}

		[RED("landAddBehVarName")] 		public CName LandAddBehVarName { get; set;}

		[RED("m_CameraModifyOffsetB")] 		public CBool M_CameraModifyOffsetB { get; set;}

		[RED("m_UsePrototypeAnimationsB")] 		public CBool M_UsePrototypeAnimationsB { get; set;}

		[RED("m_ForceOnlyJumpB")] 		public CBool M_ForceOnlyJumpB { get; set;}

		[RED("m_UseClimbB")] 		public CBool M_UseClimbB { get; set;}

		[RED("m_UsepushB")] 		public CBool M_UsepushB { get; set;}

		[RED("hackKnockBackAlways")] 		public CBool HackKnockBackAlways { get; set;}

		public CExplorationSharedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationSharedData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}