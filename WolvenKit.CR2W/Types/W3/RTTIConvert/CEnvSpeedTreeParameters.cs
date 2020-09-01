using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvSpeedTreeParameters : CVariable
	{
		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("diffuse")] 		public SSimpleCurve Diffuse { get; set;}

		[Ordinal(0)] [RED("("specularScale")] 		public SSimpleCurve SpecularScale { get; set;}

		[Ordinal(0)] [RED("("translucencyScale")] 		public SSimpleCurve TranslucencyScale { get; set;}

		[Ordinal(0)] [RED("("ambientOcclusionScale")] 		public SSimpleCurve AmbientOcclusionScale { get; set;}

		[Ordinal(0)] [RED("("billboardsColor")] 		public SSimpleCurve BillboardsColor { get; set;}

		[Ordinal(0)] [RED("("billboardsTranslucency")] 		public SSimpleCurve BillboardsTranslucency { get; set;}

		[Ordinal(0)] [RED("("randomColorsTrees")] 		public CEnvSpeedTreeRandomColorParameters RandomColorsTrees { get; set;}

		[Ordinal(0)] [RED("("randomColorsBranches")] 		public CEnvSpeedTreeRandomColorParameters RandomColorsBranches { get; set;}

		[Ordinal(0)] [RED("("randomColorsGrass")] 		public CEnvSpeedTreeRandomColorParameters RandomColorsGrass { get; set;}

		[Ordinal(0)] [RED("("randomColorsFallback")] 		public SSimpleCurve RandomColorsFallback { get; set;}

		[Ordinal(0)] [RED("("pigmentBrightness")] 		public SSimpleCurve PigmentBrightness { get; set;}

		[Ordinal(0)] [RED("("pigmentFloodStartDist")] 		public SSimpleCurve PigmentFloodStartDist { get; set;}

		[Ordinal(0)] [RED("("pigmentFloodRange")] 		public SSimpleCurve PigmentFloodRange { get; set;}

		[Ordinal(0)] [RED("("billboardsLightBleed")] 		public SSimpleCurve BillboardsLightBleed { get; set;}

		public CEnvSpeedTreeParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvSpeedTreeParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}