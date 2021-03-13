using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSplineAnimationCompression : IAnimationCompression
	{
		[Ordinal(1)] [RED("positionTolerance")] 		public CFloat PositionTolerance { get; set;}

		[Ordinal(2)] [RED("positionPolynomialDegree")] 		public CUInt16 PositionPolynomialDegree { get; set;}

		[Ordinal(3)] [RED("rotationTolerance")] 		public CFloat RotationTolerance { get; set;}

		[Ordinal(4)] [RED("rotationPolynomialDegree")] 		public CUInt16 RotationPolynomialDegree { get; set;}

		[Ordinal(5)] [RED("scaleTolerance")] 		public CFloat ScaleTolerance { get; set;}

		[Ordinal(6)] [RED("scalePolynomialDegree")] 		public CUInt16 ScalePolynomialDegree { get; set;}

		[Ordinal(7)] [RED("floatTolerance")] 		public CFloat FloatTolerance { get; set;}

		[Ordinal(8)] [RED("floatPolynomialDegree")] 		public CUInt16 FloatPolynomialDegree { get; set;}

		public CSplineAnimationCompression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSplineAnimationCompression(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}