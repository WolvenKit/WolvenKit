using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalQuestBlock : CQuestGraphBlock
	{
		[Ordinal(1)] [RED("questEntry")] 		public CHandle<CJournalPath> QuestEntry { get; set;}

		[Ordinal(2)] [RED("showInfoOnScreen")] 		public CBool ShowInfoOnScreen { get; set;}

		[Ordinal(3)] [RED("track")] 		public CBool Track { get; set;}

		[Ordinal(4)] [RED("enableAutoSave")] 		public CBool EnableAutoSave { get; set;}

		public CJournalQuestBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJournalQuestBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}