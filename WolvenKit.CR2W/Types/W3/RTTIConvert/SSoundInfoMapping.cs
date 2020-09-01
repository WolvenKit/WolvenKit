using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSoundInfoMapping : CVariable
	{
		[Ordinal(1)] [RED("("soundTypeIdentification")] 		public CName SoundTypeIdentification { get; set;}

		[Ordinal(2)] [RED("("soundSizeIdentification")] 		public CName SoundSizeIdentification { get; set;}

		[Ordinal(3)] [RED("("boneIndexes", 2,0)] 		public CArray<CInt32> BoneIndexes { get; set;}

		[Ordinal(4)] [RED("("isDefault")] 		public CBool IsDefault { get; set;}

		public SSoundInfoMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSoundInfoMapping(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}