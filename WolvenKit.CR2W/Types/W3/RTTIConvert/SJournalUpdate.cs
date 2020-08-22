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
		[RED("text")] 		public CString Text { get; set;}

		[RED("title")] 		public CString Title { get; set;}

		[RED("status")] 		public CEnum<EJournalStatus> Status { get; set;}

		[RED("journalEntry")] 		public CHandle<CJournalBase> JournalEntry { get; set;}

		[RED("iconPath")] 		public CString IconPath { get; set;}

		[RED("panelName")] 		public CName PanelName { get; set;}

		[RED("entryTag")] 		public CName EntryTag { get; set;}

		[RED("soundEvent")] 		public CString SoundEvent { get; set;}

		[RED("isQuestUpdate")] 		public CBool IsQuestUpdate { get; set;}

		[RED("displayTime")] 		public CFloat DisplayTime { get; set;}

		[RED("itemId")] 		public SItemUniqueId ItemId { get; set;}

		[RED("isItemUpdate")] 		public CBool IsItemUpdate { get; set;}

		public SJournalUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SJournalUpdate(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}