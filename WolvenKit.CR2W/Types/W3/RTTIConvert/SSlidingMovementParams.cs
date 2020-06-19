using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSlidingMovementParams : CVariable
	{
		[RED("m_TurnSpeedF")] 		public CFloat M_TurnSpeedF { get; set;}

		[RED("m_FrictionSquareF")] 		public CFloat M_FrictionSquareF { get; set;}

		[RED("m_FrictionLinearF")] 		public CFloat M_FrictionLinearF { get; set;}

		[RED("m_FrictionConstF")] 		public CFloat M_FrictionConstF { get; set;}

		[RED("m_FrictionConstExitF")] 		public CFloat M_FrictionConstExitF { get; set;}

		[RED("m_InputVisualTurnCoefF")] 		public CFloat M_InputVisualTurnCoefF { get; set;}

		[RED("m_GravityF")] 		public CFloat M_GravityF { get; set;}

		[RED("m_RestitutionF")] 		public CFloat M_RestitutionF { get; set;}

		[RED("m_InputAccelInfluenceF")] 		public CFloat M_InputAccelInfluenceF { get; set;}

		[RED("m_InputFrictionCoefMinF")] 		public CFloat M_InputFrictionCoefMinF { get; set;}

		[RED("m_InputFrictionCoefMaxF")] 		public CFloat M_InputFrictionCoefMaxF { get; set;}

		[RED("m_InputFrictionBlend")] 		public CFloat M_InputFrictionBlend { get; set;}

		[RED("m_InputStrafeCoefF")] 		public CFloat M_InputStrafeCoefF { get; set;}

		public SSlidingMovementParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSlidingMovementParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}