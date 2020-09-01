using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationCollisionManager : CObject
	{
		[Ordinal(0)] [RED("("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[Ordinal(0)] [RED("("m_CollideWithNPCEventCenter")] 		public CName M_CollideWithNPCEventCenter { get; set;}

		[Ordinal(0)] [RED("("m_CollideWithNPCEventLeft")] 		public CName M_CollideWithNPCEventLeft { get; set;}

		[Ordinal(0)] [RED("("m_CollideWithNPCEventRight")] 		public CName M_CollideWithNPCEventRight { get; set;}

		[Ordinal(0)] [RED("("m_CollideNameS")] 		public CName M_CollideNameS { get; set;}

		[Ordinal(0)] [RED("("m_CollideBehGraphSideNameS")] 		public CName M_CollideBehGraphSideNameS { get; set;}

		[Ordinal(0)] [RED("("m_CollideBehGraphStanceNameS")] 		public CName M_CollideBehGraphStanceNameS { get; set;}

		[Ordinal(0)] [RED("("m_CollideAngleNameS")] 		public CName M_CollideAngleNameS { get; set;}

		[Ordinal(0)] [RED("("m_CollideBehGraphStrengthRelNameS")] 		public CName M_CollideBehGraphStrengthRelNameS { get; set;}

		[Ordinal(0)] [RED("("m_CollideBehGraphHeightN")] 		public CName M_CollideBehGraphHeightN { get; set;}

		[Ordinal(0)] [RED("("m_CanCollideWithStaticaB")] 		public CBool M_CanCollideWithStaticaB { get; set;}

		[Ordinal(0)] [RED("("m_VisualReactionToPushB")] 		public CBool M_VisualReactionToPushB { get; set;}

		[Ordinal(0)] [RED("("m_SpeedToCollideWihNPCsF")] 		public CFloat M_SpeedToCollideWihNPCsF { get; set;}

		[Ordinal(0)] [RED("("m_TimeCollidingToStopF")] 		public CFloat M_TimeCollidingToStopF { get; set;}

		[Ordinal(0)] [RED("("m_TimeCollidingCurF")] 		public CFloat M_TimeCollidingCurF { get; set;}

		[Ordinal(0)] [RED("("m_AcceptableZToBumpF")] 		public CFloat M_AcceptableZToBumpF { get; set;}

		[Ordinal(0)] [RED("("playerHandHeightRange")] 		public CFloat PlayerHandHeightRange { get; set;}

		[Ordinal(0)] [RED("("m_LandWaterMinDepthF")] 		public CFloat M_LandWaterMinDepthF { get; set;}

		[Ordinal(0)] [RED("("m_CollisionGroupsNamesNArr", 2,0)] 		public CArray<CName> M_CollisionGroupsNamesNArr { get; set;}

		[Ordinal(0)] [RED("("m_CollisionSightNArr", 2,0)] 		public CArray<CName> M_CollisionSightNArr { get; set;}

		[Ordinal(0)] [RED("("m_CollisionObstaclesNArr", 2,0)] 		public CArray<CName> M_CollisionObstaclesNArr { get; set;}

		[Ordinal(0)] [RED("("m_CollidingB")] 		public CBool M_CollidingB { get; set;}

		[Ordinal(0)] [RED("("m_IsThereAnyCollisionB")] 		public CBool M_IsThereAnyCollisionB { get; set;}

		[Ordinal(0)] [RED("("m_CollidingWithNpcB")] 		public CBool M_CollidingWithNpcB { get; set;}

		[Ordinal(0)] [RED("("m_CollidingWithStaticsB")] 		public CBool M_CollidingWithStaticsB { get; set;}

		[Ordinal(0)] [RED("("m_AngleToSideF")] 		public CFloat M_AngleToSideF { get; set;}

		[Ordinal(0)] [RED("("m_CollidingAngleF")] 		public CFloat M_CollidingAngleF { get; set;}

		[Ordinal(0)] [RED("("m_CollideCenterIfBothSidesB")] 		public CBool M_CollideCenterIfBothSidesB { get; set;}

		[Ordinal(0)] [RED("("m_CollidingSideE")] 		public CEnum<ESideSelected> M_CollidingSideE { get; set;}

		[Ordinal(0)] [RED("("m_CollidingSideLastE")] 		public CEnum<ESideSelected> M_CollidingSideLastE { get; set;}

		[Ordinal(0)] [RED("("m_CollidingSideCooldownF")] 		public CFloat M_CollidingSideCooldownF { get; set;}

		[Ordinal(0)] [RED("("forceFallEnabled")] 		public CBool ForceFallEnabled { get; set;}

		[Ordinal(0)] [RED("("forceFallRequireCenter")] 		public CBool ForceFallRequireCenter { get; set;}

		[Ordinal(0)] [RED("("forceFallRunning")] 		public CBool ForceFallRunning { get; set;}

		[Ordinal(0)] [RED("("m_CollidingStrengthOtherF")] 		public CFloat M_CollidingStrengthOtherF { get; set;}

		[Ordinal(0)] [RED("("m_CollidingStrengthRelativeF")] 		public CFloat M_CollidingStrengthRelativeF { get; set;}

		[Ordinal(0)] [RED("("m_CollidingDirOtherV")] 		public Vector M_CollidingDirOtherV { get; set;}

		[Ordinal(0)] [RED("("m_CollidingSpeedOtherV")] 		public Vector M_CollidingSpeedOtherV { get; set;}

		[Ordinal(0)] [RED("("m_CollidingStrengthFadeSpeedF")] 		public CFloat M_CollidingStrengthFadeSpeedF { get; set;}

		[Ordinal(0)] [RED("("m_CollidingIsLowB")] 		public CBool M_CollidingIsLowB { get; set;}

		[Ordinal(0)] [RED("("m_CollidingLowMinHeightF")] 		public CFloat M_CollidingLowMinHeightF { get; set;}

		[Ordinal(0)] [RED("("debugEnabled")] 		public CBool DebugEnabled { get; set;}

		[Ordinal(0)] [RED("("m_UpV")] 		public Vector M_UpV { get; set;}

		[Ordinal(0)] [RED("("m_ZeroV")] 		public Vector M_ZeroV { get; set;}

		[Ordinal(0)] [RED("("lastWaterCheckPoint")] 		public Vector LastWaterCheckPoint { get; set;}

		public CExplorationCollisionManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationCollisionManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}