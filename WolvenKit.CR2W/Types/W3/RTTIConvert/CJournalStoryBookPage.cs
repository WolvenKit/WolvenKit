using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalStoryBookPage : CJournalContainer
	{
		[RED("title")] 		public LocalizedString Title { get; set;}

		[RED("world")] 		public CUInt32 World { get; set;}

		[RED("active")] 		public CBool Active { get; set;}

		public CJournalStoryBookPage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJournalStoryBookPage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}