using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvReflectionProbesGenParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("colorAmbient")] 		public SSimpleCurve ColorAmbient { get; set;}

		[Ordinal(3)] [RED("colorSceneMul")] 		public SSimpleCurve ColorSceneMul { get; set;}

		[Ordinal(4)] [RED("colorSceneAdd")] 		public SSimpleCurve ColorSceneAdd { get; set;}

		[Ordinal(5)] [RED("colorSkyMul")] 		public SSimpleCurve ColorSkyMul { get; set;}

		[Ordinal(6)] [RED("colorSkyAdd")] 		public SSimpleCurve ColorSkyAdd { get; set;}

		[Ordinal(7)] [RED("remapOffset")] 		public SSimpleCurve RemapOffset { get; set;}

		[Ordinal(8)] [RED("remapStrength")] 		public SSimpleCurve RemapStrength { get; set;}

		[Ordinal(9)] [RED("remapClamp")] 		public SSimpleCurve RemapClamp { get; set;}

		public CEnvReflectionProbesGenParameters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvReflectionProbesGenParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}