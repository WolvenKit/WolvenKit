using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvToneMappingCurveParameters : CVariable
	{
		[Ordinal(1)] [RED("shoulderStrength")] 		public SSimpleCurve ShoulderStrength { get; set;}

		[Ordinal(2)] [RED("linearStrength")] 		public SSimpleCurve LinearStrength { get; set;}

		[Ordinal(3)] [RED("linearAngle")] 		public SSimpleCurve LinearAngle { get; set;}

		[Ordinal(4)] [RED("toeStrength")] 		public SSimpleCurve ToeStrength { get; set;}

		[Ordinal(5)] [RED("toeNumerator")] 		public SSimpleCurve ToeNumerator { get; set;}

		[Ordinal(6)] [RED("toeDenominator")] 		public SSimpleCurve ToeDenominator { get; set;}

		public CEnvToneMappingCurveParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvToneMappingCurveParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}