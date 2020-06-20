using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvNVSSAOParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("radius")] 		public SSimpleCurve Radius { get; set;}

		[RED("bias")] 		public SSimpleCurve Bias { get; set;}

		[RED("detailStrength")] 		public SSimpleCurve DetailStrength { get; set;}

		[RED("coarseStrength")] 		public SSimpleCurve CoarseStrength { get; set;}

		[RED("powerExponent")] 		public SSimpleCurve PowerExponent { get; set;}

		[RED("blurSharpness")] 		public SSimpleCurve BlurSharpness { get; set;}

		[RED("valueClamp")] 		public SSimpleCurve ValueClamp { get; set;}

		[RED("ssaoColor")] 		public SSimpleCurve SsaoColor { get; set;}

		[RED("nonAmbientInfluence")] 		public SSimpleCurve NonAmbientInfluence { get; set;}

		[RED("translucencyInfluence")] 		public SSimpleCurve TranslucencyInfluence { get; set;}

		public CEnvNVSSAOParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvNVSSAOParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}