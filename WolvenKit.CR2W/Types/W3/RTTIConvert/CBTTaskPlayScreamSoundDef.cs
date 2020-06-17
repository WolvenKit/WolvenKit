using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayScreamSoundDef : IBehTreeTaskDefinition
	{
		[RED("minFrequency")] 		public CFloat MinFrequency { get; set;}

		[RED("maxFrequency")] 		public CFloat MaxFrequency { get; set;}

		public CBTTaskPlayScreamSoundDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskPlayScreamSoundDef(cr2w);

	}
}