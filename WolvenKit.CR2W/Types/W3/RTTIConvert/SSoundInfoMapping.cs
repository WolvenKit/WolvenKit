using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSoundInfoMapping : CVariable
	{
		[RED("soundTypeIdentification")] 		public CName SoundTypeIdentification { get; set;}

		[RED("soundSizeIdentification")] 		public CName SoundSizeIdentification { get; set;}

		[RED("boneIndexes", 2,0)] 		public CArray<CInt32> BoneIndexes { get; set;}

		[RED("isDefault")] 		public CBool IsDefault { get; set;}

		public SSoundInfoMapping(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SSoundInfoMapping(cr2w);

	}
}