using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvToneMappingParameters : CVariable
	{
		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("skyLuminanceCustomValue")] 		public SSimpleCurve SkyLuminanceCustomValue { get; set;}

		[Ordinal(0)] [RED("("skyLuminanceCustomAmount")] 		public SSimpleCurve SkyLuminanceCustomAmount { get; set;}

		[Ordinal(0)] [RED("("luminanceLimitShape")] 		public SSimpleCurve LuminanceLimitShape { get; set;}

		[Ordinal(0)] [RED("("luminanceLimitMin")] 		public SSimpleCurve LuminanceLimitMin { get; set;}

		[Ordinal(0)] [RED("("luminanceLimitMax")] 		public SSimpleCurve LuminanceLimitMax { get; set;}

		[Ordinal(0)] [RED("("rejectThreshold")] 		public SSimpleCurve RejectThreshold { get; set;}

		[Ordinal(0)] [RED("("rejectSmoothExtent")] 		public SSimpleCurve RejectSmoothExtent { get; set;}

		[Ordinal(0)] [RED("("newToneMapCurveParameters")] 		public CEnvToneMappingCurveParameters NewToneMapCurveParameters { get; set;}

		[Ordinal(0)] [RED("("newToneMapWhitepoint")] 		public SSimpleCurve NewToneMapWhitepoint { get; set;}

		[Ordinal(0)] [RED("("newToneMapPostScale")] 		public SSimpleCurve NewToneMapPostScale { get; set;}

		[Ordinal(0)] [RED("("exposureScale")] 		public SSimpleCurve ExposureScale { get; set;}

		[Ordinal(0)] [RED("("postScale")] 		public SSimpleCurve PostScale { get; set;}

		public CEnvToneMappingParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvToneMappingParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}