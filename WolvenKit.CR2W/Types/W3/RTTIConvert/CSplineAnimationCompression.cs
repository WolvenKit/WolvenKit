using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSplineAnimationCompression : IAnimationCompression
	{
		[RED("positionTolerance")] 		public CFloat PositionTolerance { get; set;}

		[RED("positionPolynomialDegree")] 		public CUInt16 PositionPolynomialDegree { get; set;}

		[RED("rotationTolerance")] 		public CFloat RotationTolerance { get; set;}

		[RED("rotationPolynomialDegree")] 		public CUInt16 RotationPolynomialDegree { get; set;}

		[RED("scaleTolerance")] 		public CFloat ScaleTolerance { get; set;}

		[RED("scalePolynomialDegree")] 		public CUInt16 ScalePolynomialDegree { get; set;}

		[RED("floatTolerance")] 		public CFloat FloatTolerance { get; set;}

		[RED("floatPolynomialDegree")] 		public CUInt16 FloatPolynomialDegree { get; set;}

		public CSplineAnimationCompression(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSplineAnimationCompression(cr2w);

	}
}