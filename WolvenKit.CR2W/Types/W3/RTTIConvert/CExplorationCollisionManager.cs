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
		[RED("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[RED("m_CollideWithNPCEventCenter")] 		public CName M_CollideWithNPCEventCenter { get; set;}

		[RED("m_CollideWithNPCEventLeft")] 		public CName M_CollideWithNPCEventLeft { get; set;}

		[RED("m_CollideWithNPCEventRight")] 		public CName M_CollideWithNPCEventRight { get; set;}

		[RED("m_CollideNameS")] 		public CName M_CollideNameS { get; set;}

		[RED("m_CollideBehGraphSideNameS")] 		public CName M_CollideBehGraphSideNameS { get; set;}

		[RED("m_CollideBehGraphStanceNameS")] 		public CName M_CollideBehGraphStanceNameS { get; set;}

		[RED("m_CollideAngleNameS")] 		public CName M_CollideAngleNameS { get; set;}

		[RED("m_CollideBehGraphStrengthRelNameS")] 		public CName M_CollideBehGraphStrengthRelNameS { get; set;}

		[RED("m_CollideBehGraphHeightN")] 		public CName M_CollideBehGraphHeightN { get; set;}

		[RED("m_CanCollideWithStaticaB")] 		public CBool M_CanCollideWithStaticaB { get; set;}

		[RED("m_VisualReactionToPushB")] 		public CBool M_VisualReactionToPushB { get; set;}

		[RED("m_SpeedToCollideWihNPCsF")] 		public CFloat M_SpeedToCollideWihNPCsF { get; set;}

		[RED("m_TimeCollidingToStopF")] 		public CFloat M_TimeCollidingToStopF { get; set;}

		[RED("m_TimeCollidingCurF")] 		public CFloat M_TimeCollidingCurF { get; set;}

		[RED("m_AcceptableZToBumpF")] 		public CFloat M_AcceptableZToBumpF { get; set;}

		[RED("playerHandHeightRange")] 		public CFloat PlayerHandHeightRange { get; set;}

		[RED("m_LandWaterMinDepthF")] 		public CFloat M_LandWaterMinDepthF { get; set;}

		[RED("m_CollisionGroupsNamesNArr", 2,0)] 		public CArray<CName> M_CollisionGroupsNamesNArr { get; set;}

		[RED("m_CollisionSightNArr", 2,0)] 		public CArray<CName> M_CollisionSightNArr { get; set;}

		[RED("m_CollisionObstaclesNArr", 2,0)] 		public CArray<CName> M_CollisionObstaclesNArr { get; set;}

		[RED("m_CollidingB")] 		public CBool M_CollidingB { get; set;}

		[RED("m_IsThereAnyCollisionB")] 		public CBool M_IsThereAnyCollisionB { get; set;}

		[RED("m_CollidingWithNpcB")] 		public CBool M_CollidingWithNpcB { get; set;}

		[RED("m_CollidingWithStaticsB")] 		public CBool M_CollidingWithStaticsB { get; set;}

		[RED("m_AngleToSideF")] 		public CFloat M_AngleToSideF { get; set;}

		[RED("m_CollidingAngleF")] 		public CFloat M_CollidingAngleF { get; set;}

		[RED("m_CollideCenterIfBothSidesB")] 		public CBool M_CollideCenterIfBothSidesB { get; set;}

		[RED("m_CollidingSideE")] 		public CEnum<ESideSelected> M_CollidingSideE { get; set;}

		[RED("m_CollidingSideLastE")] 		public CEnum<ESideSelected> M_CollidingSideLastE { get; set;}

		[RED("m_CollidingSideCooldownF")] 		public CFloat M_CollidingSideCooldownF { get; set;}

		[RED("forceFallEnabled")] 		public CBool ForceFallEnabled { get; set;}

		[RED("forceFallRequireCenter")] 		public CBool ForceFallRequireCenter { get; set;}

		[RED("forceFallRunning")] 		public CBool ForceFallRunning { get; set;}

		[RED("m_CollidingStrengthOtherF")] 		public CFloat M_CollidingStrengthOtherF { get; set;}

		[RED("m_CollidingStrengthRelativeF")] 		public CFloat M_CollidingStrengthRelativeF { get; set;}

		[RED("m_CollidingDirOtherV")] 		public Vector M_CollidingDirOtherV { get; set;}

		[RED("m_CollidingSpeedOtherV")] 		public Vector M_CollidingSpeedOtherV { get; set;}

		[RED("m_CollidingStrengthFadeSpeedF")] 		public CFloat M_CollidingStrengthFadeSpeedF { get; set;}

		[RED("m_CollidingIsLowB")] 		public CBool M_CollidingIsLowB { get; set;}

		[RED("m_CollidingLowMinHeightF")] 		public CFloat M_CollidingLowMinHeightF { get; set;}

		[RED("debugEnabled")] 		public CBool DebugEnabled { get; set;}

		[RED("m_UpV")] 		public Vector M_UpV { get; set;}

		[RED("m_ZeroV")] 		public Vector M_ZeroV { get; set;}

		[RED("lastWaterCheckPoint")] 		public Vector LastWaterCheckPoint { get; set;}

		public CExplorationCollisionManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationCollisionManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}