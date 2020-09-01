using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvBloomNewParameters : CVariable
	{
		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("brightPassWeights")] 		public SSimpleCurve BrightPassWeights { get; set;}

		[Ordinal(0)] [RED("("color")] 		public SSimpleCurve Color { get; set;}

		[Ordinal(0)] [RED("("dirtColor")] 		public SSimpleCurve DirtColor { get; set;}

		[Ordinal(0)] [RED("("threshold")] 		public SSimpleCurve Threshold { get; set;}

		[Ordinal(0)] [RED("("thresholdRange")] 		public SSimpleCurve ThresholdRange { get; set;}

		[Ordinal(0)] [RED("("brightnessMax")] 		public SSimpleCurve BrightnessMax { get; set;}

		[Ordinal(0)] [RED("("shaftsColor")] 		public SSimpleCurve ShaftsColor { get; set;}

		[Ordinal(0)] [RED("("shaftsRadius")] 		public SSimpleCurve ShaftsRadius { get; set;}

		[Ordinal(0)] [RED("("shaftsShapeExp")] 		public SSimpleCurve ShaftsShapeExp { get; set;}

		[Ordinal(0)] [RED("("shaftsShapeInvSquare")] 		public SSimpleCurve ShaftsShapeInvSquare { get; set;}

		[Ordinal(0)] [RED("("shaftsThreshold")] 		public SSimpleCurve ShaftsThreshold { get; set;}

		[Ordinal(0)] [RED("("shaftsThresholdRange")] 		public SSimpleCurve ShaftsThresholdRange { get; set;}

		public CEnvBloomNewParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvBloomNewParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}