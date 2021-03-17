using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestContactLinkController : BaseCodexLinkController
	{
		private inkTextWidgetReference _msgLabel;
		private inkWidgetReference _msgContainer;
		private CInt32 _msgCounter;
		private CHandle<gameJournalContact> _contactEntry;
		private wCHandle<gameJournalManager> _journalMgr;
		private wCHandle<PhoneSystem> _phoneSystem;

		[Ordinal(4)] 
		[RED("msgLabel")] 
		public inkTextWidgetReference MsgLabel
		{
			get => GetProperty(ref _msgLabel);
			set => SetProperty(ref _msgLabel, value);
		}

		[Ordinal(5)] 
		[RED("msgContainer")] 
		public inkWidgetReference MsgContainer
		{
			get => GetProperty(ref _msgContainer);
			set => SetProperty(ref _msgContainer, value);
		}

		[Ordinal(6)] 
		[RED("msgCounter")] 
		public CInt32 MsgCounter
		{
			get => GetProperty(ref _msgCounter);
			set => SetProperty(ref _msgCounter, value);
		}

		[Ordinal(7)] 
		[RED("contactEntry")] 
		public CHandle<gameJournalContact> ContactEntry
		{
			get => GetProperty(ref _contactEntry);
			set => SetProperty(ref _contactEntry, value);
		}

		[Ordinal(8)] 
		[RED("journalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		[Ordinal(9)] 
		[RED("phoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get => GetProperty(ref _phoneSystem);
			set => SetProperty(ref _phoneSystem, value);
		}

		public QuestContactLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
