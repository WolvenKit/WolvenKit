using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalQuest : CJournalContainer
	{
		[Ordinal(1)] [RED("type")] 		public CEnum<eQuestType> Type { get; set;}

		[Ordinal(2)] [RED("contentType")] 		public CEnum<EJournalContentType> ContentType { get; set;}

		[Ordinal(3)] [RED("world")] 		public CUInt32 World { get; set;}

		[Ordinal(4)] [RED("huntingQuestPath")] 		public CHandle<CJournalPath> HuntingQuestPath { get; set;}

		[Ordinal(5)] [RED("title")] 		public LocalizedString Title { get; set;}

		[Ordinal(6)] [RED("questPhase")] 		public CSoft<CQuestPhase> QuestPhase { get; set;}

		public CJournalQuest(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJournalQuest(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}