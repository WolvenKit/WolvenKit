using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvAmbientProbesGenParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("colorAmbient")] 		public SSimpleCurve ColorAmbient { get; set;}

		[Ordinal(3)] [RED("colorSceneAdd")] 		public SSimpleCurve ColorSceneAdd { get; set;}

		[Ordinal(4)] [RED("colorSkyTop")] 		public SSimpleCurve ColorSkyTop { get; set;}

		[Ordinal(5)] [RED("colorSkyHorizon")] 		public SSimpleCurve ColorSkyHorizon { get; set;}

		[Ordinal(6)] [RED("skyShape")] 		public SSimpleCurve SkyShape { get; set;}

		public CEnvAmbientProbesGenParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvAmbientProbesGenParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}