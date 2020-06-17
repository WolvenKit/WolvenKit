using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalQuestBlock : CQuestGraphBlock
	{
		[RED("questEntry")] 		public CHandle<CJournalPath> QuestEntry { get; set;}

		[RED("showInfoOnScreen")] 		public CBool ShowInfoOnScreen { get; set;}

		[RED("track")] 		public CBool Track { get; set;}

		[RED("enableAutoSave")] 		public CBool EnableAutoSave { get; set;}

		public CJournalQuestBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CJournalQuestBlock(cr2w);

	}
}