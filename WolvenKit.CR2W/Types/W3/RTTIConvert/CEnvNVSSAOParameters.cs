using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvNVSSAOParameters : CVariable
	{
		[Ordinal(0)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("radius")] 		public SSimpleCurve Radius { get; set;}

		[Ordinal(0)] [RED("bias")] 		public SSimpleCurve Bias { get; set;}

		[Ordinal(0)] [RED("detailStrength")] 		public SSimpleCurve DetailStrength { get; set;}

		[Ordinal(0)] [RED("coarseStrength")] 		public SSimpleCurve CoarseStrength { get; set;}

		[Ordinal(0)] [RED("powerExponent")] 		public SSimpleCurve PowerExponent { get; set;}

		[Ordinal(0)] [RED("blurSharpness")] 		public SSimpleCurve BlurSharpness { get; set;}

		[Ordinal(0)] [RED("valueClamp")] 		public SSimpleCurve ValueClamp { get; set;}

		[Ordinal(0)] [RED("ssaoColor")] 		public SSimpleCurve SsaoColor { get; set;}

		[Ordinal(0)] [RED("nonAmbientInfluence")] 		public SSimpleCurve NonAmbientInfluence { get; set;}

		[Ordinal(0)] [RED("translucencyInfluence")] 		public SSimpleCurve TranslucencyInfluence { get; set;}

		public CEnvNVSSAOParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvNVSSAOParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}