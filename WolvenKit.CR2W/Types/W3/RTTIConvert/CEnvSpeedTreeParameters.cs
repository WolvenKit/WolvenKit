using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvSpeedTreeParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("diffuse")] 		public SSimpleCurve Diffuse { get; set;}

		[RED("specularScale")] 		public SSimpleCurve SpecularScale { get; set;}

		[RED("translucencyScale")] 		public SSimpleCurve TranslucencyScale { get; set;}

		[RED("ambientOcclusionScale")] 		public SSimpleCurve AmbientOcclusionScale { get; set;}

		[RED("billboardsColor")] 		public SSimpleCurve BillboardsColor { get; set;}

		[RED("billboardsTranslucency")] 		public SSimpleCurve BillboardsTranslucency { get; set;}

		[RED("randomColorsTrees")] 		public CEnvSpeedTreeRandomColorParameters RandomColorsTrees { get; set;}

		[RED("randomColorsBranches")] 		public CEnvSpeedTreeRandomColorParameters RandomColorsBranches { get; set;}

		[RED("randomColorsGrass")] 		public CEnvSpeedTreeRandomColorParameters RandomColorsGrass { get; set;}

		[RED("randomColorsFallback")] 		public SSimpleCurve RandomColorsFallback { get; set;}

		[RED("pigmentBrightness")] 		public SSimpleCurve PigmentBrightness { get; set;}

		[RED("pigmentFloodStartDist")] 		public SSimpleCurve PigmentFloodStartDist { get; set;}

		[RED("pigmentFloodRange")] 		public SSimpleCurve PigmentFloodRange { get; set;}

		[RED("billboardsLightBleed")] 		public SSimpleCurve BillboardsLightBleed { get; set;}

		public CEnvSpeedTreeParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvSpeedTreeParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}