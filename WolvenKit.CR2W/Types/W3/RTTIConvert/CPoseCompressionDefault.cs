using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPoseCompressionDefault : IPoseCompression
	{
		[RED("firstRotBoneName")] 		public CString FirstRotBoneName { get; set;}

		[RED("lastRotBoneName")] 		public CString LastRotBoneName { get; set;}

		[RED("firstTransBoneName")] 		public CString FirstTransBoneName { get; set;}

		[RED("lastTransBoneName")] 		public CString LastTransBoneName { get; set;}

		[RED("firstRotBone")] 		public CInt32 FirstRotBone { get; set;}

		[RED("lastRotBone")] 		public CInt32 LastRotBone { get; set;}

		[RED("firstTransBone")] 		public CInt32 FirstTransBone { get; set;}

		[RED("lastTransBone")] 		public CInt32 LastTransBone { get; set;}

		[RED("compressTranslationType")] 		public CEnum<ECompressTranslationType> CompressTranslationType { get; set;}

		public CPoseCompressionDefault(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPoseCompressionDefault(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}