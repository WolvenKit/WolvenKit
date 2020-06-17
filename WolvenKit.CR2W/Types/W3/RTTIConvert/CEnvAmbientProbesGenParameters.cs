using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvAmbientProbesGenParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("colorAmbient")] 		public SSimpleCurve ColorAmbient { get; set;}

		[RED("colorSceneAdd")] 		public SSimpleCurve ColorSceneAdd { get; set;}

		[RED("colorSkyTop")] 		public SSimpleCurve ColorSkyTop { get; set;}

		[RED("colorSkyHorizon")] 		public SSimpleCurve ColorSkyHorizon { get; set;}

		[RED("skyShape")] 		public SSimpleCurve SkyShape { get; set;}

		public CEnvAmbientProbesGenParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEnvAmbientProbesGenParameters(cr2w);

	}
}