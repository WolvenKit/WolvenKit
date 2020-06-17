using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWaveletAnimationCompression : IAnimationCompression
	{
		[RED("quantizationBits")] 		public CUInt8 QuantizationBits { get; set;}

		[RED("positionTolerance")] 		public CFloat PositionTolerance { get; set;}

		[RED("rotationTolerance")] 		public CFloat RotationTolerance { get; set;}

		[RED("scaleTolerance")] 		public CFloat ScaleTolerance { get; set;}

		public CWaveletAnimationCompression(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CWaveletAnimationCompression(cr2w);

	}
}