using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SVoiceWeightCurve : CVariable
	{
		[Ordinal(1)] [RED("("useCurve")] 		public CBool UseCurve { get; set;}

		[Ordinal(2)] [RED("("curve")] 		public SCurveData Curve { get; set;}

		[Ordinal(3)] [RED("("timeOffset")] 		public CFloat TimeOffset { get; set;}

		[Ordinal(4)] [RED("("valueMulPre")] 		public CFloat ValueMulPre { get; set;}

		[Ordinal(5)] [RED("("valueOffset")] 		public CFloat ValueOffset { get; set;}

		[Ordinal(6)] [RED("("valueMulPost")] 		public CFloat ValueMulPost { get; set;}

		public SVoiceWeightCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SVoiceWeightCurve(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}