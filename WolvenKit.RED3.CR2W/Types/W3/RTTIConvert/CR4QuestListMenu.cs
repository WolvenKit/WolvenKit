using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4QuestListMenu : CR4Menu
	{
		[Ordinal(1)] [RED("KEY_QUEST_LIST")] 		public CString KEY_QUEST_LIST { get; set;}

		[Ordinal(2)] [RED("REWARDS_SIZE")] 		public CInt32 REWARDS_SIZE { get; set;}

		[Ordinal(3)] [RED("m_journalManager")] 		public CHandle<CWitcherJournalManager> M_journalManager { get; set;}

		[Ordinal(4)] [RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[Ordinal(5)] [RED("allQuests", 2,0)] 		public CArray<CHandle<CJournalBase>> AllQuests { get; set;}

		[Ordinal(6)] [RED("_currentQuestID")] 		public CInt32 _currentQuestID { get; set;}

		public CR4QuestListMenu(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4QuestListMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}