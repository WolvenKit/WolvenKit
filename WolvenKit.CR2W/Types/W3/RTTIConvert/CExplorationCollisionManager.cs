using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationCollisionManager : CObject
	{
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

		[RED("m_AcceptableZToBumpF")] 		public CFloat M_AcceptableZToBumpF { get; set;}

		[RED("playerHandHeightRange")] 		public CFloat PlayerHandHeightRange { get; set;}

		[RED("m_AngleToSideF")] 		public CFloat M_AngleToSideF { get; set;}

		[RED("m_CollideCenterIfBothSidesB")] 		public CBool M_CollideCenterIfBothSidesB { get; set;}

		[RED("m_CollidingStrengthFadeSpeedF")] 		public CFloat M_CollidingStrengthFadeSpeedF { get; set;}

		[RED("m_CollidingLowMinHeightF")] 		public CFloat M_CollidingLowMinHeightF { get; set;}

		[RED("debugEnabled")] 		public CBool DebugEnabled { get; set;}

		public CExplorationCollisionManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationCollisionManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}