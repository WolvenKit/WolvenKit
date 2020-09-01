using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SJournalUpdate : CVariable
	{
		[Ordinal(0)] [RED("("text")] 		public CString Text { get; set;}

		[Ordinal(0)] [RED("("title")] 		public CString Title { get; set;}

		[Ordinal(0)] [RED("("status")] 		public CEnum<EJournalStatus> Status { get; set;}

		[Ordinal(0)] [RED("("journalEntry")] 		public CHandle<CJournalBase> JournalEntry { get; set;}

		[Ordinal(0)] [RED("("iconPath")] 		public CString IconPath { get; set;}

		[Ordinal(0)] [RED("("panelName")] 		public CName PanelName { get; set;}

		[Ordinal(0)] [RED("("entryTag")] 		public CName EntryTag { get; set;}

		[Ordinal(0)] [RED("("soundEvent")] 		public CString SoundEvent { get; set;}

		[Ordinal(0)] [RED("("isQuestUpdate")] 		public CBool IsQuestUpdate { get; set;}

		[Ordinal(0)] [RED("("displayTime")] 		public CFloat DisplayTime { get; set;}

		[Ordinal(0)] [RED("("itemId")] 		public SItemUniqueId ItemId { get; set;}

		[Ordinal(0)] [RED("("isItemUpdate")] 		public CBool IsItemUpdate { get; set;}

		public SJournalUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SJournalUpdate(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}