using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationCollisionManager : CObject
	{
		[Ordinal(1)] [RED("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[Ordinal(2)] [RED("m_CollideWithNPCEventCenter")] 		public CName M_CollideWithNPCEventCenter { get; set;}

		[Ordinal(3)] [RED("m_CollideWithNPCEventLeft")] 		public CName M_CollideWithNPCEventLeft { get; set;}

		[Ordinal(4)] [RED("m_CollideWithNPCEventRight")] 		public CName M_CollideWithNPCEventRight { get; set;}

		[Ordinal(5)] [RED("m_CollideNameS")] 		public CName M_CollideNameS { get; set;}

		[Ordinal(6)] [RED("m_CollideBehGraphSideNameS")] 		public CName M_CollideBehGraphSideNameS { get; set;}

		[Ordinal(7)] [RED("m_CollideBehGraphStanceNameS")] 		public CName M_CollideBehGraphStanceNameS { get; set;}

		[Ordinal(8)] [RED("m_CollideAngleNameS")] 		public CName M_CollideAngleNameS { get; set;}

		[Ordinal(9)] [RED("m_CollideBehGraphStrengthRelNameS")] 		public CName M_CollideBehGraphStrengthRelNameS { get; set;}

		[Ordinal(10)] [RED("m_CollideBehGraphHeightN")] 		public CName M_CollideBehGraphHeightN { get; set;}

		[Ordinal(11)] [RED("m_CanCollideWithStaticaB")] 		public CBool M_CanCollideWithStaticaB { get; set;}

		[Ordinal(12)] [RED("m_VisualReactionToPushB")] 		public CBool M_VisualReactionToPushB { get; set;}

		[Ordinal(13)] [RED("m_SpeedToCollideWihNPCsF")] 		public CFloat M_SpeedToCollideWihNPCsF { get; set;}

		[Ordinal(14)] [RED("m_TimeCollidingToStopF")] 		public CFloat M_TimeCollidingToStopF { get; set;}

		[Ordinal(15)] [RED("m_TimeCollidingCurF")] 		public CFloat M_TimeCollidingCurF { get; set;}

		[Ordinal(16)] [RED("m_AcceptableZToBumpF")] 		public CFloat M_AcceptableZToBumpF { get; set;}

		[Ordinal(17)] [RED("playerHandHeightRange")] 		public CFloat PlayerHandHeightRange { get; set;}

		[Ordinal(18)] [RED("m_LandWaterMinDepthF")] 		public CFloat M_LandWaterMinDepthF { get; set;}

		[Ordinal(19)] [RED("m_CollisionGroupsNamesNArr", 2,0)] 		public CArray<CName> M_CollisionGroupsNamesNArr { get; set;}

		[Ordinal(20)] [RED("m_CollisionSightNArr", 2,0)] 		public CArray<CName> M_CollisionSightNArr { get; set;}

		[Ordinal(21)] [RED("m_CollisionObstaclesNArr", 2,0)] 		public CArray<CName> M_CollisionObstaclesNArr { get; set;}

		[Ordinal(22)] [RED("m_CollidingB")] 		public CBool M_CollidingB { get; set;}

		[Ordinal(23)] [RED("m_IsThereAnyCollisionB")] 		public CBool M_IsThereAnyCollisionB { get; set;}

		[Ordinal(24)] [RED("m_CollidingWithNpcB")] 		public CBool M_CollidingWithNpcB { get; set;}

		[Ordinal(25)] [RED("m_CollidingWithStaticsB")] 		public CBool M_CollidingWithStaticsB { get; set;}

		[Ordinal(26)] [RED("m_AngleToSideF")] 		public CFloat M_AngleToSideF { get; set;}

		[Ordinal(27)] [RED("m_CollidingAngleF")] 		public CFloat M_CollidingAngleF { get; set;}

		[Ordinal(28)] [RED("m_CollideCenterIfBothSidesB")] 		public CBool M_CollideCenterIfBothSidesB { get; set;}

		[Ordinal(29)] [RED("m_CollidingSideE")] 		public CEnum<ESideSelected> M_CollidingSideE { get; set;}

		[Ordinal(30)] [RED("m_CollidingSideLastE")] 		public CEnum<ESideSelected> M_CollidingSideLastE { get; set;}

		[Ordinal(31)] [RED("m_CollidingSideCooldownF")] 		public CFloat M_CollidingSideCooldownF { get; set;}

		[Ordinal(32)] [RED("forceFallEnabled")] 		public CBool ForceFallEnabled { get; set;}

		[Ordinal(33)] [RED("forceFallRequireCenter")] 		public CBool ForceFallRequireCenter { get; set;}

		[Ordinal(34)] [RED("forceFallRunning")] 		public CBool ForceFallRunning { get; set;}

		[Ordinal(35)] [RED("m_CollidingStrengthOtherF")] 		public CFloat M_CollidingStrengthOtherF { get; set;}

		[Ordinal(36)] [RED("m_CollidingStrengthRelativeF")] 		public CFloat M_CollidingStrengthRelativeF { get; set;}

		[Ordinal(37)] [RED("m_CollidingDirOtherV")] 		public Vector M_CollidingDirOtherV { get; set;}

		[Ordinal(38)] [RED("m_CollidingSpeedOtherV")] 		public Vector M_CollidingSpeedOtherV { get; set;}

		[Ordinal(39)] [RED("m_CollidingStrengthFadeSpeedF")] 		public CFloat M_CollidingStrengthFadeSpeedF { get; set;}

		[Ordinal(40)] [RED("m_CollidingIsLowB")] 		public CBool M_CollidingIsLowB { get; set;}

		[Ordinal(41)] [RED("m_CollidingLowMinHeightF")] 		public CFloat M_CollidingLowMinHeightF { get; set;}

		[Ordinal(42)] [RED("debugEnabled")] 		public CBool DebugEnabled { get; set;}

		[Ordinal(43)] [RED("m_UpV")] 		public Vector M_UpV { get; set;}

		[Ordinal(44)] [RED("m_ZeroV")] 		public Vector M_ZeroV { get; set;}

		[Ordinal(45)] [RED("lastWaterCheckPoint")] 		public Vector LastWaterCheckPoint { get; set;}

		public CExplorationCollisionManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationCollisionManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}