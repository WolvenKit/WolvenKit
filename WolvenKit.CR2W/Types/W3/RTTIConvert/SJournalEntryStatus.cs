using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SJournalEntryStatus : CVariable
	{
		[RED("entry")] 		public CPtr<CJournalBase> Entry { get; set;}

		[RED("status")] 		public EJournalStatus Status { get; set;}

		[RED("unread")] 		public CBool Unread { get; set;}

		public SJournalEntryStatus(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SJournalEntryStatus(cr2w);

	}
}