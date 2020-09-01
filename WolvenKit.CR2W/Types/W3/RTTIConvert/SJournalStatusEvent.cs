using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SJournalStatusEvent : SJournalEvent
	{
		[Ordinal(0)] [RED("("oldStatus")] 		public CEnum<EJournalStatus> OldStatus { get; set;}

		[Ordinal(0)] [RED("("newStatus")] 		public CEnum<EJournalStatus> NewStatus { get; set;}

		[Ordinal(0)] [RED("("silent")] 		public CBool Silent { get; set;}

		public SJournalStatusEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SJournalStatusEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}