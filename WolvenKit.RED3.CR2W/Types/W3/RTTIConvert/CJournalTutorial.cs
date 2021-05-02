using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalTutorial : CJournalChildBase
	{
		[Ordinal(1)] [RED("name")] 		public LocalizedString Name { get; set;}

		[Ordinal(2)] [RED("image")] 		public CString Image { get; set;}

		[Ordinal(3)] [RED("video")] 		public CString Video { get; set;}

		[Ordinal(4)] [RED("description")] 		public LocalizedString Description { get; set;}

		[Ordinal(5)] [RED("dlcLock")] 		public CName DlcLock { get; set;}

		[Ordinal(6)] [RED("active")] 		public CBool Active { get; set;}

		public CJournalTutorial(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}