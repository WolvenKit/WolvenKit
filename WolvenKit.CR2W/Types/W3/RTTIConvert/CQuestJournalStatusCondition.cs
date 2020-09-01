using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestJournalStatusCondition : IQuestCondition
	{
		[Ordinal(0)] [RED("entry")] 		public CHandle<CJournalPath> Entry { get; set;}

		[Ordinal(0)] [RED("status")] 		public CEnum<EJournalStatus> Status { get; set;}

		[Ordinal(0)] [RED("inverted")] 		public CBool Inverted { get; set;}

		public CQuestJournalStatusCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestJournalStatusCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}