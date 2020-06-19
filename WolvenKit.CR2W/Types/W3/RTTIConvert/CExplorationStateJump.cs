using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateJump : CExplorationStateAbstract
	{
		[RED("jumpEnabled")] 		public CBool JumpEnabled { get; set;}

		[RED("m_SlopeAngleMaxToJump")] 		public CFloat M_SlopeAngleMaxToJump { get; set;}

		[RED("m_UseGenericJumpB")] 		public CBool M_UseGenericJumpB { get; set;}

		[RED("m_AllowSprintJumpB")] 		public CBool M_AllowSprintJumpB { get; set;}

		[RED("m_JumpParmsGenericS")] 		public SJumpParams M_JumpParmsGenericS { get; set;}

		[RED("m_JumpParmsIdleS")] 		public SJumpParams M_JumpParmsIdleS { get; set;}

		[RED("m_JumpParmsIdleToWalkS")] 		public SJumpParams M_JumpParmsIdleToWalkS { get; set;}

		[RED("m_JumpParmsWalkS")] 		public SJumpParams M_JumpParmsWalkS { get; set;}

		[RED("m_JumpParmsWalkHighS")] 		public SJumpParams M_JumpParmsWalkHighS { get; set;}

		[RED("m_JumpParmsRunS")] 		public SJumpParams M_JumpParmsRunS { get; set;}

		[RED("m_JumpParmsSprintS")] 		public SJumpParams M_JumpParmsSprintS { get; set;}

		[RED("m_JumpParmsFallS")] 		public SJumpParams M_JumpParmsFallS { get; set;}

		[RED("m_JumpParmsHitS")] 		public SJumpParams M_JumpParmsHitS { get; set;}

		[RED("m_JumpParmsSlideS")] 		public SJumpParams M_JumpParmsSlideS { get; set;}

		[RED("m_JumpParmsVaultS")] 		public SJumpParams M_JumpParmsVaultS { get; set;}

		[RED("m_JumpParmsToWaterS")] 		public SJumpParams M_JumpParmsToWaterS { get; set;}

		[RED("m_JumpParmsKnockBackS")] 		public SJumpParams M_JumpParmsKnockBackS { get; set;}

		[RED("m_JumpParmsKnockBackFallS")] 		public SJumpParams M_JumpParmsKnockBackFallS { get; set;}

		[RED("m_JumpParmsSkateIdleS")] 		public SJumpParams M_JumpParmsSkateIdleS { get; set;}

		[RED("m_SprintJumpNeedsStaminaB")] 		public CBool M_SprintJumpNeedsStaminaB { get; set;}

		[RED("m_SprintJumpTimeExtraF")] 		public CFloat M_SprintJumpTimeExtraF { get; set;}

		[RED("m_SprintJumpTimeGapF")] 		public CFloat M_SprintJumpTimeGapF { get; set;}

		[RED("m_ConserveHorizontalCoefF")] 		public CFloat M_ConserveHorizontalCoefF { get; set;}

		[RED("m_ConserveVertUpCoefF")] 		public CFloat M_ConserveVertUpCoefF { get; set;}

		[RED("m_ConserveVertDownCoefF")] 		public CFloat M_ConserveVertDownCoefF { get; set;}

		[RED("m_ConserveHorizontalMaxF")] 		public CFloat M_ConserveHorizontalMaxF { get; set;}

		[RED("m_ConserveVertUpMaxF")] 		public CFloat M_ConserveVertUpMaxF { get; set;}

		[RED("m_ConserveVertDownMaxF")] 		public CFloat M_ConserveVertDownMaxF { get; set;}

		[RED("m_SpeedSqrMinToConserveF")] 		public CFloat M_SpeedSqrMinToConserveF { get; set;}

		[RED("m_ReactToHitCeilingB")] 		public CBool M_ReactToHitCeilingB { get; set;}

		[RED("m_BehEventPredictLandN")] 		public CName M_BehEventPredictLandN { get; set;}

		[RED("m_BehListenInertialJumpN")] 		public CName M_BehListenInertialJumpN { get; set;}

		[RED("m_BehListenFinishTakeOffN")] 		public CName M_BehListenFinishTakeOffN { get; set;}

		[RED("m_BehParamJumpTypeN")] 		public CName M_BehParamJumpTypeN { get; set;}

		[RED("m_BehEventPredictingS")] 		public CName M_BehEventPredictingS { get; set;}

		[RED("m_BehEventPredictTypeS")] 		public CName M_BehEventPredictTypeS { get; set;}

		[RED("m_BehParamIsHandledByAnimS")] 		public CName M_BehParamIsHandledByAnimS { get; set;}

		[RED("m_BehParamWalkOrSprintS")] 		public CName M_BehParamWalkOrSprintS { get; set;}

		[RED("m_BehParamNormalLandS")] 		public CName M_BehParamNormalLandS { get; set;}

		[RED("m_BehEventCeilingHit")] 		public CName M_BehEventCeilingHit { get; set;}

		[RED("m_InteractAlwaysB")] 		public CBool M_InteractAlwaysB { get; set;}

		[RED("m_InteractTimeMinFallF")] 		public CFloat M_InteractTimeMinFallF { get; set;}

		[RED("m_InteractTimeMinF")] 		public CFloat M_InteractTimeMinF { get; set;}

		[RED("m_InteractTimeMinVaultF")] 		public CFloat M_InteractTimeMinVaultF { get; set;}

		[RED("m_InteractHeightFallMaxF")] 		public CFloat M_InteractHeightFallMaxF { get; set;}

		[RED("m_InteractTimeAdjustingF")] 		public CFloat M_InteractTimeAdjustingF { get; set;}

		[RED("m_InteractDistanceExtraF")] 		public CFloat M_InteractDistanceExtraF { get; set;}

		[RED("m_InteractSpeedDiffAllowedF")] 		public CFloat M_InteractSpeedDiffAllowedF { get; set;}

		[RED("m_InteractOwnerOffsetV")] 		public Vector M_InteractOwnerOffsetV { get; set;}

		[RED("m_LockingJumpOnInteractionAreaB")] 		public CBool M_LockingJumpOnInteractionAreaB { get; set;}

		[RED("m_LockingJumpOnHorseAreaB")] 		public CBool M_LockingJumpOnHorseAreaB { get; set;}

		[RED("m_AllowJumpInSlopesB")] 		public CBool M_AllowJumpInSlopesB { get; set;}

		[RED("m_FallDistToUseHelpF")] 		public CFloat M_FallDistToUseHelpF { get; set;}

		[RED("m_FallRecoverMaxHeightUpF")] 		public CFloat M_FallRecoverMaxHeightUpF { get; set;}

		[RED("m_FallRecoverMaxHeightDownF")] 		public CFloat M_FallRecoverMaxHeightDownF { get; set;}

		[RED("m_FallRecoverMaxDistF")] 		public CFloat M_FallRecoverMaxDistF { get; set;}

		[RED("m_ForceIdleJumpOnColliisonB")] 		public CBool M_ForceIdleJumpOnColliisonB { get; set;}

		[RED("m_ForceIdleJumpHeightFreeF")] 		public CFloat M_ForceIdleJumpHeightFreeF { get; set;}

		[RED("m_ForceIdleJumpDistFreeF")] 		public CFloat M_ForceIdleJumpDistFreeF { get; set;}

		[RED("m_LandPredictedB")] 		public CBool M_LandPredictedB { get; set;}

		[RED("m_LandGroundPredictB")] 		public CBool M_LandGroundPredictB { get; set;}

		[RED("m_LandWaterPredictB")] 		public CBool M_LandWaterPredictB { get; set;}

		[RED("m_LandPredictTimeMin")] 		public CFloat M_LandPredictTimeMin { get; set;}

		[RED("m_LandPredictionTimeF")] 		public CFloat M_LandPredictionTimeF { get; set;}

		[RED("m_LandPredicedBlendF")] 		public CFloat M_LandPredicedBlendF { get; set;}

		[RED("m_SlopedLandZF")] 		public CFloat M_SlopedLandZF { get; set;}

		[RED("m_CameraDebugB")] 		public CBool M_CameraDebugB { get; set;}

		[RED("m_CameraTimeToEndF")] 		public CFloat M_CameraTimeToEndF { get; set;}

		[RED("cameraRoationName")] 		public CName CameraRoationName { get; set;}

		[RED("cameraToFallHeightNeed")] 		public CFloat CameraToFallHeightNeed { get; set;}

		[RED("m_CollideBehGraphSideNameS")] 		public CName M_CollideBehGraphSideNameS { get; set;}

		[RED("m_CooldownTotalF")] 		public CFloat M_CooldownTotalF { get; set;}

		public CExplorationStateJump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateJump(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}