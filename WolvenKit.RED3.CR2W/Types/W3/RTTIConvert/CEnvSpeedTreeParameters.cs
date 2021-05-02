using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvSpeedTreeParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("diffuse")] 		public SSimpleCurve Diffuse { get; set;}

		[Ordinal(3)] [RED("specularScale")] 		public SSimpleCurve SpecularScale { get; set;}

		[Ordinal(4)] [RED("translucencyScale")] 		public SSimpleCurve TranslucencyScale { get; set;}

		[Ordinal(5)] [RED("ambientOcclusionScale")] 		public SSimpleCurve AmbientOcclusionScale { get; set;}

		[Ordinal(6)] [RED("billboardsColor")] 		public SSimpleCurve BillboardsColor { get; set;}

		[Ordinal(7)] [RED("billboardsTranslucency")] 		public SSimpleCurve BillboardsTranslucency { get; set;}

		[Ordinal(8)] [RED("randomColorsTrees")] 		public CEnvSpeedTreeRandomColorParameters RandomColorsTrees { get; set;}

		[Ordinal(9)] [RED("randomColorsBranches")] 		public CEnvSpeedTreeRandomColorParameters RandomColorsBranches { get; set;}

		[Ordinal(10)] [RED("randomColorsGrass")] 		public CEnvSpeedTreeRandomColorParameters RandomColorsGrass { get; set;}

		[Ordinal(11)] [RED("randomColorsFallback")] 		public SSimpleCurve RandomColorsFallback { get; set;}

		[Ordinal(12)] [RED("pigmentBrightness")] 		public SSimpleCurve PigmentBrightness { get; set;}

		[Ordinal(13)] [RED("pigmentFloodStartDist")] 		public SSimpleCurve PigmentFloodStartDist { get; set;}

		[Ordinal(14)] [RED("pigmentFloodRange")] 		public SSimpleCurve PigmentFloodRange { get; set;}

		[Ordinal(15)] [RED("billboardsLightBleed")] 		public SSimpleCurve BillboardsLightBleed { get; set;}

		public CEnvSpeedTreeParameters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvSpeedTreeParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}