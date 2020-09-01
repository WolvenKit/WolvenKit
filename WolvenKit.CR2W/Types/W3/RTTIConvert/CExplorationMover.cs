using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationMover : CObject
	{
		[Ordinal(0)] [RED("("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[Ordinal(0)] [RED("("m_InputO")] 		public CHandle<CExplorationInput> M_InputO { get; set;}

		[Ordinal(0)] [RED("("m_WorldPositionV")] 		public Vector M_WorldPositionV { get; set;}

		[Ordinal(0)] [RED("("m_DisplacementLastFrameV")] 		public Vector M_DisplacementLastFrameV { get; set;}

		[Ordinal(0)] [RED("("m_PlaneMovementParamsS")] 		public SPlaneMovementParameters M_PlaneMovementParamsS { get; set;}

		[Ordinal(0)] [RED("("m_VerticalMovementParamsS")] 		public SVerticalMovementParams M_VerticalMovementParamsS { get; set;}

		[Ordinal(0)] [RED("("m_SlidingParamsS")] 		public SSlidingMovementParams M_SlidingParamsS { get; set;}

		[Ordinal(0)] [RED("("m_SkatingParamsS")] 		public SSkatingMovementParams M_SkatingParamsS { get; set;}

		[Ordinal(0)] [RED("("m_SkatingLevelParamsS")] 		public SSkatingLevelParams M_SkatingLevelParamsS { get; set;}

		[Ordinal(0)] [RED("("m_SkatingTurnPerSpeedF")] 		public CFloat M_SkatingTurnPerSpeedF { get; set;}

		[Ordinal(0)] [RED("("m_SkatingSpeedTotalMaxF")] 		public CFloat M_SkatingSpeedTotalMaxF { get; set;}

		[Ordinal(0)] [RED("("m_SkatingTurnPerSpeedCurF")] 		public CFloat M_SkatingTurnPerSpeedCurF { get; set;}

		[Ordinal(0)] [RED("("m_SkatingTurnPerSpeedBlendF")] 		public CFloat M_SkatingTurnPerSpeedBlendF { get; set;}

		[Ordinal(0)] [RED("("m_SlidingFrictionBlendedF")] 		public CFloat M_SlidingFrictionBlendedF { get; set;}

		[Ordinal(0)] [RED("("m_SkateTurnDecelCoefF")] 		public CFloat M_SkateTurnDecelCoefF { get; set;}

		[Ordinal(0)] [RED("("m_SkateTurnBrakeCoefF")] 		public CFloat M_SkateTurnBrakeCoefF { get; set;}

		[Ordinal(0)] [RED("("m_VelocityV")] 		public Vector M_VelocityV { get; set;}

		[Ordinal(0)] [RED("("m_VelocityNormalizedV")] 		public Vector M_VelocityNormalizedV { get; set;}

		[Ordinal(0)] [RED("("m_SpeedF")] 		public CFloat M_SpeedF { get; set;}

		[Ordinal(0)] [RED("("m_SpeedHeadingF")] 		public CFloat M_SpeedHeadingF { get; set;}

		[Ordinal(0)] [RED("("m_SpeedVerticalF")] 		public CFloat M_SpeedVerticalF { get; set;}

		[Ordinal(0)] [RED("("m_DisplacementV")] 		public Vector M_DisplacementV { get; set;}

		[Ordinal(0)] [RED("("m_RotationDeltaEA")] 		public EulerAngles M_RotationDeltaEA { get; set;}

		[Ordinal(0)] [RED("("m_SpeedLastF")] 		public CFloat M_SpeedLastF { get; set;}

		[Ordinal(0)] [RED("("m_AccelerationLastF")] 		public CFloat M_AccelerationLastF { get; set;}

		[Ordinal(0)] [RED("("m_SlideMaxSpeedSafeF")] 		public CFloat M_SlideMaxSpeedSafeF { get; set;}

		[Ordinal(0)] [RED("("m_SlideMaxSpeedToFallF")] 		public CFloat M_SlideMaxSpeedToFallF { get; set;}

		[Ordinal(0)] [RED("("m_SlideMaxSpeedF")] 		public CFloat M_SlideMaxSpeedF { get; set;}

		[Ordinal(0)] [RED("("m_UseMaterialsB")] 		public CBool M_UseMaterialsB { get; set;}

		[Ordinal(0)] [RED("("m_SlidingLimitMinF")] 		public CFloat M_SlidingLimitMinF { get; set;}

		[Ordinal(0)] [RED("("m_SlidingLimitMaxF")] 		public CFloat M_SlidingLimitMaxF { get; set;}

		[Ordinal(0)] [RED("("m_MaterialFrictionMultF")] 		public CFloat M_MaterialFrictionMultF { get; set;}

		[Ordinal(0)] [RED("("m_CoefMinMaterialF")] 		public CFloat M_CoefMinMaterialF { get; set;}

		[Ordinal(0)] [RED("("m_SlideNormalRealV")] 		public Vector M_SlideNormalRealV { get; set;}

		[Ordinal(0)] [RED("("m_SlideNormalV")] 		public Vector M_SlideNormalV { get; set;}

		[Ordinal(0)] [RED("("m_SlideDirV")] 		public Vector M_SlideDirV { get; set;}

		[Ordinal(0)] [RED("("m_SlideRealangleF")] 		public CFloat M_SlideRealangleF { get; set;}

		[Ordinal(0)] [RED("("m_SlideComputedThisFrameB")] 		public CBool M_SlideComputedThisFrameB { get; set;}

		[Ordinal(0)] [RED("("m_SlideWideComputedThisFrameB")] 		public CBool M_SlideWideComputedThisFrameB { get; set;}

		[Ordinal(0)] [RED("("m_SlideWideCoefGlobalF")] 		public CFloat M_SlideWideCoefGlobalF { get; set;}

		[Ordinal(0)] [RED("("m_WideNormalAverageV")] 		public Vector M_WideNormalAverageV { get; set;}

		[Ordinal(0)] [RED("("m_WideNormalGlobalV")] 		public Vector M_WideNormalGlobalV { get; set;}

		[Ordinal(0)] [RED("("m_SlideWideCoefAverageF")] 		public CFloat M_SlideWideCoefAverageF { get; set;}

		[Ordinal(0)] [RED("("m_SlideWideCoefRealGlobalF")] 		public CFloat M_SlideWideCoefRealGlobalF { get; set;}

		[Ordinal(0)] [RED("("m_SlideWideCoefRealAverageF")] 		public CFloat M_SlideWideCoefRealAverageF { get; set;}

		[Ordinal(0)] [RED("("m_SlideTerrainWideDistFwdF")] 		public CFloat M_SlideTerrainWideDistFwdF { get; set;}

		[Ordinal(0)] [RED("("m_SlideTerrainWideDistBwdF")] 		public CFloat M_SlideTerrainWideDistBwdF { get; set;}

		[Ordinal(0)] [RED("("m_SlideTerrainWideDistHorizF")] 		public CFloat M_SlideTerrainWideDistHorizF { get; set;}

		[Ordinal(0)] [RED("("gravityCurve")] 		public CHandle<CCurve> GravityCurve { get; set;}

		[Ordinal(0)] [RED("("superSlide")] 		public CBool SuperSlide { get; set;}

		[Ordinal(0)] [RED("("m_TurnThisFrameF")] 		public CFloat M_TurnThisFrameF { get; set;}

		[Ordinal(0)] [RED("("m_BankingNeedsUpdatingB")] 		public CBool M_BankingNeedsUpdatingB { get; set;}

		[Ordinal(0)] [RED("("m_BankingTargetF")] 		public CFloat M_BankingTargetF { get; set;}

		[Ordinal(0)] [RED("("m_BankingSpeedF")] 		public CFloat M_BankingSpeedF { get; set;}

		[Ordinal(0)] [RED("("m_BankingSpeedDefaultF")] 		public CFloat M_BankingSpeedDefaultF { get; set;}

		[Ordinal(0)] [RED("("m_OrientToInputMaxHeadingF")] 		public CFloat M_OrientToInputMaxHeadingF { get; set;}

		[Ordinal(0)] [RED("("m_MACVelocityDampedV")] 		public Vector M_MACVelocityDampedV { get; set;}

		[Ordinal(0)] [RED("("m_MACVelocityDamSpeedF")] 		public CFloat M_MACVelocityDamSpeedF { get; set;}

		[Ordinal(0)] [RED("("m_CustomIsAnimatedB")] 		public CBool M_CustomIsAnimatedB { get; set;}

		[Ordinal(0)] [RED("("m_BoneRightFootN")] 		public CName M_BoneRightFootN { get; set;}

		[Ordinal(0)] [RED("("m_BoneLeftFootN")] 		public CName M_BoneLeftFootN { get; set;}

		[Ordinal(0)] [RED("("m_BoneIndexRightFootI")] 		public CInt32 M_BoneIndexRightFootI { get; set;}

		[Ordinal(0)] [RED("("m_BoneIndexLeftFootI")] 		public CInt32 M_BoneIndexLeftFootI { get; set;}

		[Ordinal(0)] [RED("("m_UpV")] 		public Vector M_UpV { get; set;}

		[Ordinal(0)] [RED("("m_ZeroV")] 		public Vector M_ZeroV { get; set;}

		public CExplorationMover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationMover(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}