using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvSpeedTreeRandomColorParameters : CVariable
	{
		[RED("luminanceWeights")] 		public SSimpleCurve LuminanceWeights { get; set;}

		[RED("randomColor0")] 		public SSimpleCurve RandomColor0 { get; set;}

		[RED("saturation0")] 		public SSimpleCurve Saturation0 { get; set;}

		[RED("randomColor1")] 		public SSimpleCurve RandomColor1 { get; set;}

		[RED("saturation1")] 		public SSimpleCurve Saturation1 { get; set;}

		[RED("randomColor2")] 		public SSimpleCurve RandomColor2 { get; set;}

		[RED("saturation2")] 		public SSimpleCurve Saturation2 { get; set;}

		public CEnvSpeedTreeRandomColorParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEnvSpeedTreeRandomColorParameters(cr2w);

	}
}