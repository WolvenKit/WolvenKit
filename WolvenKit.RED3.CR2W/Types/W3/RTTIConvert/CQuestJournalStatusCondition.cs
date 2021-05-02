using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestJournalStatusCondition : IQuestCondition
	{
		[Ordinal(1)] [RED("entry")] 		public CHandle<CJournalPath> Entry { get; set;}

		[Ordinal(2)] [RED("status")] 		public CEnum<EJournalStatus> Status { get; set;}

		[Ordinal(3)] [RED("inverted")] 		public CBool Inverted { get; set;}

		public CQuestJournalStatusCondition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestJournalStatusCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}