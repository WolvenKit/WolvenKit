using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSplineAnimationCompression : IAnimationCompression
	{
		[Ordinal(0)] [RED("("positionTolerance")] 		public CFloat PositionTolerance { get; set;}

		[Ordinal(0)] [RED("("positionPolynomialDegree")] 		public CUInt16 PositionPolynomialDegree { get; set;}

		[Ordinal(0)] [RED("("rotationTolerance")] 		public CFloat RotationTolerance { get; set;}

		[Ordinal(0)] [RED("("rotationPolynomialDegree")] 		public CUInt16 RotationPolynomialDegree { get; set;}

		[Ordinal(0)] [RED("("scaleTolerance")] 		public CFloat ScaleTolerance { get; set;}

		[Ordinal(0)] [RED("("scalePolynomialDegree")] 		public CUInt16 ScalePolynomialDegree { get; set;}

		[Ordinal(0)] [RED("("floatTolerance")] 		public CFloat FloatTolerance { get; set;}

		[Ordinal(0)] [RED("("floatPolynomialDegree")] 		public CUInt16 FloatPolynomialDegree { get; set;}

		public CSplineAnimationCompression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSplineAnimationCompression(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}