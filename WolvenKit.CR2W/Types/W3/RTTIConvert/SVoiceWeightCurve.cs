using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SVoiceWeightCurve : CVariable
	{
		[RED("useCurve")] 		public CBool UseCurve { get; set;}

		[RED("curve")] 		public SCurveData Curve { get; set;}

		[RED("timeOffset")] 		public CFloat TimeOffset { get; set;}

		[RED("valueMulPre")] 		public CFloat ValueMulPre { get; set;}

		[RED("valueOffset")] 		public CFloat ValueOffset { get; set;}

		[RED("valueMulPost")] 		public CFloat ValueMulPost { get; set;}

		public SVoiceWeightCurve(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SVoiceWeightCurve(cr2w);

	}
}