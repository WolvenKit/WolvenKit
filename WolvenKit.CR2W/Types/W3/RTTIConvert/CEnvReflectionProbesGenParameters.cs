using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvReflectionProbesGenParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("colorAmbient")] 		public SSimpleCurve ColorAmbient { get; set;}

		[RED("colorSceneMul")] 		public SSimpleCurve ColorSceneMul { get; set;}

		[RED("colorSceneAdd")] 		public SSimpleCurve ColorSceneAdd { get; set;}

		[RED("colorSkyMul")] 		public SSimpleCurve ColorSkyMul { get; set;}

		[RED("colorSkyAdd")] 		public SSimpleCurve ColorSkyAdd { get; set;}

		[RED("remapOffset")] 		public SSimpleCurve RemapOffset { get; set;}

		[RED("remapStrength")] 		public SSimpleCurve RemapStrength { get; set;}

		[RED("remapClamp")] 		public SSimpleCurve RemapClamp { get; set;}

		public CEnvReflectionProbesGenParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvReflectionProbesGenParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}