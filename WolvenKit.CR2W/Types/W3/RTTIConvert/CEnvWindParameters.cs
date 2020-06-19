using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvWindParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("windStrengthOverride")] 		public SSimpleCurve WindStrengthOverride { get; set;}

		[RED("cloudsVelocityOverride")] 		public SSimpleCurve CloudsVelocityOverride { get; set;}

		public CEnvWindParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvWindParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}