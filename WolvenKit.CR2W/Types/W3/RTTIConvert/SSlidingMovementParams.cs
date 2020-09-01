using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSlidingMovementParams : CVariable
	{
		[Ordinal(1)] [RED("m_TurnSpeedF")] 		public CFloat M_TurnSpeedF { get; set;}

		[Ordinal(2)] [RED("m_FrictionSquareF")] 		public CFloat M_FrictionSquareF { get; set;}

		[Ordinal(3)] [RED("m_FrictionLinearF")] 		public CFloat M_FrictionLinearF { get; set;}

		[Ordinal(4)] [RED("m_FrictionConstF")] 		public CFloat M_FrictionConstF { get; set;}

		[Ordinal(5)] [RED("m_FrictionConstExitF")] 		public CFloat M_FrictionConstExitF { get; set;}

		[Ordinal(6)] [RED("m_InputVisualTurnCoefF")] 		public CFloat M_InputVisualTurnCoefF { get; set;}

		[Ordinal(7)] [RED("m_GravityF")] 		public CFloat M_GravityF { get; set;}

		[Ordinal(8)] [RED("m_RestitutionF")] 		public CFloat M_RestitutionF { get; set;}

		[Ordinal(9)] [RED("m_InputAccelInfluenceF")] 		public CFloat M_InputAccelInfluenceF { get; set;}

		[Ordinal(10)] [RED("m_InputFrictionCoefMinF")] 		public CFloat M_InputFrictionCoefMinF { get; set;}

		[Ordinal(11)] [RED("m_InputFrictionCoefMaxF")] 		public CFloat M_InputFrictionCoefMaxF { get; set;}

		[Ordinal(12)] [RED("m_InputFrictionBlend")] 		public CFloat M_InputFrictionBlend { get; set;}

		[Ordinal(13)] [RED("m_InputStrafeCoefF")] 		public CFloat M_InputStrafeCoefF { get; set;}

		public SSlidingMovementParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSlidingMovementParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}