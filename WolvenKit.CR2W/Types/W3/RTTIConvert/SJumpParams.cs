using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SJumpParams : CVariable
	{
		[Ordinal(1)] [RED("("m_BehaviorEventN")] 		public CName M_BehaviorEventN { get; set;}

		[Ordinal(2)] [RED("("m_PredictionTimeF")] 		public CFloat M_PredictionTimeF { get; set;}

		[Ordinal(3)] [RED("("m_VerticalMovementS")] 		public SVerticalMovementParams M_VerticalMovementS { get; set;}

		[Ordinal(4)] [RED("("m_HorImpulseAtStartB")] 		public CBool M_HorImpulseAtStartB { get; set;}

		[Ordinal(5)] [RED("("m_HorImpulseF")] 		public CFloat M_HorImpulseF { get; set;}

		[Ordinal(6)] [RED("("m_HorMovementS")] 		public SPlaneMovementParameters M_HorMovementS { get; set;}

		[Ordinal(7)] [RED("("m_TakeOffTimeF")] 		public CFloat M_TakeOffTimeF { get; set;}

		[Ordinal(8)] [RED("("m_StartOrientTimeF")] 		public CFloat M_StartOrientTimeF { get; set;}

		[Ordinal(9)] [RED("("m_UsePhysicJumpB")] 		public CBool M_UsePhysicJumpB { get; set;}

		[Ordinal(10)] [RED("("m_ConserveCoefsB")] 		public CBool M_ConserveCoefsB { get; set;}

		[Ordinal(11)] [RED("("m_ExternalDirectionForcedB")] 		public CBool M_ExternalDirectionForcedB { get; set;}

		[Ordinal(12)] [RED("("m_AllowAirDisplacementControlB")] 		public CBool M_AllowAirDisplacementControlB { get; set;}

		[Ordinal(13)] [RED("("m_StartDirectionAllowanceF")] 		public CFloat M_StartDirectionAllowanceF { get; set;}

		[Ordinal(14)] [RED("("m_StartDirectionIgnoreF")] 		public CFloat M_StartDirectionIgnoreF { get; set;}

		[Ordinal(15)] [RED("("m_OrientationSpeedF")] 		public CFloat M_OrientationSpeedF { get; set;}

		[Ordinal(16)] [RED("("m_ConserveAddB")] 		public CBool M_ConserveAddB { get; set;}

		[Ordinal(17)] [RED("("m_RecalcSpeedOnInertialB")] 		public CBool M_RecalcSpeedOnInertialB { get; set;}

		[Ordinal(18)] [RED("("m_TimeToCheckCollisionsF")] 		public CFloat M_TimeToCheckCollisionsF { get; set;}

		[Ordinal(19)] [RED("("m_TimeToPrepareForLandF")] 		public CFloat M_TimeToPrepareForLandF { get; set;}

		[Ordinal(20)] [RED("("m_JumpTypeE")] 		public CEnum<EJumpType> M_JumpTypeE { get; set;}

		[Ordinal(21)] [RED("("m_DontRecalcFootOnLand")] 		public CBool M_DontRecalcFootOnLand { get; set;}

		[Ordinal(22)] [RED("("m_FlipFeetOnLandB")] 		public CBool M_FlipFeetOnLandB { get; set;}

		public SJumpParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SJumpParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}