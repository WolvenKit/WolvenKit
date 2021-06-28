using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SJournalStatusEvent : SJournalEvent
	{
		[Ordinal(1)] [RED("oldStatus")] 		public CEnum<EJournalStatus> OldStatus { get; set;}

		[Ordinal(2)] [RED("newStatus")] 		public CEnum<EJournalStatus> NewStatus { get; set;}

		[Ordinal(3)] [RED("silent")] 		public CBool Silent { get; set;}

		public SJournalStatusEvent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}