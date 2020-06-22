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
		[RED("m_BehaviorEventN")] 		public CName M_BehaviorEventN { get; set;}

		[RED("m_PredictionTimeF")] 		public CFloat M_PredictionTimeF { get; set;}

		[RED("m_VerticalMovementS")] 		public SVerticalMovementParams M_VerticalMovementS { get; set;}

		[RED("m_HorImpulseAtStartB")] 		public CBool M_HorImpulseAtStartB { get; set;}

		[RED("m_HorImpulseF")] 		public CFloat M_HorImpulseF { get; set;}

		[RED("m_HorMovementS")] 		public SPlaneMovementParameters M_HorMovementS { get; set;}

		[RED("m_TakeOffTimeF")] 		public CFloat M_TakeOffTimeF { get; set;}

		[RED("m_StartOrientTimeF")] 		public CFloat M_StartOrientTimeF { get; set;}

		[RED("m_UsePhysicJumpB")] 		public CBool M_UsePhysicJumpB { get; set;}

		[RED("m_ConserveCoefsB")] 		public CBool M_ConserveCoefsB { get; set;}

		[RED("m_ExternalDirectionForcedB")] 		public CBool M_ExternalDirectionForcedB { get; set;}

		[RED("m_AllowAirDisplacementControlB")] 		public CBool M_AllowAirDisplacementControlB { get; set;}

		[RED("m_StartDirectionAllowanceF")] 		public CFloat M_StartDirectionAllowanceF { get; set;}

		[RED("m_StartDirectionIgnoreF")] 		public CFloat M_StartDirectionIgnoreF { get; set;}

		[RED("m_OrientationSpeedF")] 		public CFloat M_OrientationSpeedF { get; set;}

		[RED("m_ConserveAddB")] 		public CBool M_ConserveAddB { get; set;}

		[RED("m_RecalcSpeedOnInertialB")] 		public CBool M_RecalcSpeedOnInertialB { get; set;}

		[RED("m_TimeToCheckCollisionsF")] 		public CFloat M_TimeToCheckCollisionsF { get; set;}

		[RED("m_TimeToPrepareForLandF")] 		public CFloat M_TimeToPrepareForLandF { get; set;}

		[RED("m_JumpTypeE")] 		public CEnum<EJumpType> M_JumpTypeE { get; set;}

		[RED("m_DontRecalcFootOnLand")] 		public CBool M_DontRecalcFootOnLand { get; set;}

		[RED("m_FlipFeetOnLandB")] 		public CBool M_FlipFeetOnLandB { get; set;}

		public SJumpParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SJumpParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}