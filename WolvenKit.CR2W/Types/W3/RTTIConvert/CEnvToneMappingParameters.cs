using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvToneMappingParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("skyLuminanceCustomValue")] 		public SSimpleCurve SkyLuminanceCustomValue { get; set;}

		[RED("skyLuminanceCustomAmount")] 		public SSimpleCurve SkyLuminanceCustomAmount { get; set;}

		[RED("luminanceLimitShape")] 		public SSimpleCurve LuminanceLimitShape { get; set;}

		[RED("luminanceLimitMin")] 		public SSimpleCurve LuminanceLimitMin { get; set;}

		[RED("luminanceLimitMax")] 		public SSimpleCurve LuminanceLimitMax { get; set;}

		[RED("rejectThreshold")] 		public SSimpleCurve RejectThreshold { get; set;}

		[RED("rejectSmoothExtent")] 		public SSimpleCurve RejectSmoothExtent { get; set;}

		[RED("newToneMapCurveParameters")] 		public CEnvToneMappingCurveParameters NewToneMapCurveParameters { get; set;}

		[RED("newToneMapWhitepoint")] 		public SSimpleCurve NewToneMapWhitepoint { get; set;}

		[RED("newToneMapPostScale")] 		public SSimpleCurve NewToneMapPostScale { get; set;}

		[RED("exposureScale")] 		public SSimpleCurve ExposureScale { get; set;}

		[RED("postScale")] 		public SSimpleCurve PostScale { get; set;}

		public CEnvToneMappingParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvToneMappingParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}