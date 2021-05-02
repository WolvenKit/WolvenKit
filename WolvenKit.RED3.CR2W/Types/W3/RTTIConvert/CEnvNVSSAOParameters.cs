using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvNVSSAOParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("radius")] 		public SSimpleCurve Radius { get; set;}

		[Ordinal(3)] [RED("bias")] 		public SSimpleCurve Bias { get; set;}

		[Ordinal(4)] [RED("detailStrength")] 		public SSimpleCurve DetailStrength { get; set;}

		[Ordinal(5)] [RED("coarseStrength")] 		public SSimpleCurve CoarseStrength { get; set;}

		[Ordinal(6)] [RED("powerExponent")] 		public SSimpleCurve PowerExponent { get; set;}

		[Ordinal(7)] [RED("blurSharpness")] 		public SSimpleCurve BlurSharpness { get; set;}

		[Ordinal(8)] [RED("valueClamp")] 		public SSimpleCurve ValueClamp { get; set;}

		[Ordinal(9)] [RED("ssaoColor")] 		public SSimpleCurve SsaoColor { get; set;}

		[Ordinal(10)] [RED("nonAmbientInfluence")] 		public SSimpleCurve NonAmbientInfluence { get; set;}

		[Ordinal(11)] [RED("translucencyInfluence")] 		public SSimpleCurve TranslucencyInfluence { get; set;}

		public CEnvNVSSAOParameters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvNVSSAOParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}