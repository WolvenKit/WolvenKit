using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvDialogLightParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("lightColor")] 		public SSimpleCurve LightColor { get; set;}

		[RED("lightColor2")] 		public SSimpleCurve LightColor2 { get; set;}

		[RED("lightColor3")] 		public SSimpleCurve LightColor3 { get; set;}

		public CEnvDialogLightParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEnvDialogLightParameters(cr2w);

	}
}