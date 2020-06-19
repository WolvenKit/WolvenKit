using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardIdlePoseInfo : CVariable
	{
		[RED("type")] 		public CInt32 Type { get; set;}

		[RED("cat1")] 		public CString Cat1 { get; set;}

		[RED("cat2")] 		public CString Cat2 { get; set;}

		[RED("cat3")] 		public CString Cat3 { get; set;}

		[RED("id")] 		public CName Id { get; set;}

		[RED("caption")] 		public CString Caption { get; set;}

		[RED("posename")] 		public CString Posename { get; set;}

		[RED("emoState")] 		public CString EmoState { get; set;}

		[RED("status")] 		public CString Status { get; set;}

		public SStoryBoardIdlePoseInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStoryBoardIdlePoseInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}