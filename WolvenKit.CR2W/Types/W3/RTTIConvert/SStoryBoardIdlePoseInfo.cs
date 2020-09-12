using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardIdlePoseInfo : CVariable
	{
		[Ordinal(1)] [RED("type")] 		public CInt32 Type { get; set;}

		[Ordinal(2)] [RED("cat1")] 		public CString Cat1 { get; set;}

		[Ordinal(3)] [RED("cat2")] 		public CString Cat2 { get; set;}

		[Ordinal(4)] [RED("cat3")] 		public CString Cat3 { get; set;}

		[Ordinal(5)] [RED("id")] 		public CName Id { get; set;}

		[Ordinal(6)] [RED("caption")] 		public CString Caption { get; set;}

		[Ordinal(7)] [RED("posename")] 		public CString Posename { get; set;}

		[Ordinal(8)] [RED("emoState")] 		public CString EmoState { get; set;}

		[Ordinal(9)] [RED("status")] 		public CString Status { get; set;}

		public SStoryBoardIdlePoseInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStoryBoardIdlePoseInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}