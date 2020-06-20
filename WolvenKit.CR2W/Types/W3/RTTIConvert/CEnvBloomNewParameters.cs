using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvBloomNewParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("brightPassWeights")] 		public SSimpleCurve BrightPassWeights { get; set;}

		[RED("color")] 		public SSimpleCurve Color { get; set;}

		[RED("dirtColor")] 		public SSimpleCurve DirtColor { get; set;}

		[RED("threshold")] 		public SSimpleCurve Threshold { get; set;}

		[RED("thresholdRange")] 		public SSimpleCurve ThresholdRange { get; set;}

		[RED("brightnessMax")] 		public SSimpleCurve BrightnessMax { get; set;}

		[RED("shaftsColor")] 		public SSimpleCurve ShaftsColor { get; set;}

		[RED("shaftsRadius")] 		public SSimpleCurve ShaftsRadius { get; set;}

		[RED("shaftsShapeExp")] 		public SSimpleCurve ShaftsShapeExp { get; set;}

		[RED("shaftsShapeInvSquare")] 		public SSimpleCurve ShaftsShapeInvSquare { get; set;}

		[RED("shaftsThreshold")] 		public SSimpleCurve ShaftsThreshold { get; set;}

		[RED("shaftsThresholdRange")] 		public SSimpleCurve ShaftsThresholdRange { get; set;}

		public CEnvBloomNewParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvBloomNewParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}