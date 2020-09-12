using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvBloomNewParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("brightPassWeights")] 		public SSimpleCurve BrightPassWeights { get; set;}

		[Ordinal(3)] [RED("color")] 		public SSimpleCurve Color { get; set;}

		[Ordinal(4)] [RED("dirtColor")] 		public SSimpleCurve DirtColor { get; set;}

		[Ordinal(5)] [RED("threshold")] 		public SSimpleCurve Threshold { get; set;}

		[Ordinal(6)] [RED("thresholdRange")] 		public SSimpleCurve ThresholdRange { get; set;}

		[Ordinal(7)] [RED("brightnessMax")] 		public SSimpleCurve BrightnessMax { get; set;}

		[Ordinal(8)] [RED("shaftsColor")] 		public SSimpleCurve ShaftsColor { get; set;}

		[Ordinal(9)] [RED("shaftsRadius")] 		public SSimpleCurve ShaftsRadius { get; set;}

		[Ordinal(10)] [RED("shaftsShapeExp")] 		public SSimpleCurve ShaftsShapeExp { get; set;}

		[Ordinal(11)] [RED("shaftsShapeInvSquare")] 		public SSimpleCurve ShaftsShapeInvSquare { get; set;}

		[Ordinal(12)] [RED("shaftsThreshold")] 		public SSimpleCurve ShaftsThreshold { get; set;}

		[Ordinal(13)] [RED("shaftsThresholdRange")] 		public SSimpleCurve ShaftsThresholdRange { get; set;}

		public CEnvBloomNewParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvBloomNewParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}