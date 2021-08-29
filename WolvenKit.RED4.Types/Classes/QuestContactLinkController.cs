using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestContactLinkController : BaseCodexLinkController
	{
		private inkTextWidgetReference _msgLabel;
		private inkWidgetReference _msgContainer;
		private CInt32 _msgCounter;
		private CHandle<gameJournalContact> _contactEntry;
		private CWeakHandle<gameJournalManager> _journalMgr;
		private CWeakHandle<PhoneSystem> _phoneSystem;

		[Ordinal(5)] 
		[RED("msgLabel")] 
		public inkTextWidgetReference MsgLabel
		{
			get => GetProperty(ref _msgLabel);
			set => SetProperty(ref _msgLabel, value);
		}

		[Ordinal(6)] 
		[RED("msgContainer")] 
		public inkWidgetReference MsgContainer
		{
			get => GetProperty(ref _msgContainer);
			set => SetProperty(ref _msgContainer, value);
		}

		[Ordinal(7)] 
		[RED("msgCounter")] 
		public CInt32 MsgCounter
		{
			get => GetProperty(ref _msgCounter);
			set => SetProperty(ref _msgCounter, value);
		}

		[Ordinal(8)] 
		[RED("contactEntry")] 
		public CHandle<gameJournalContact> ContactEntry
		{
			get => GetProperty(ref _contactEntry);
			set => SetProperty(ref _contactEntry, value);
		}

		[Ordinal(9)] 
		[RED("journalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		[Ordinal(10)] 
		[RED("phoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetProperty(ref _phoneSystem);
			set => SetProperty(ref _phoneSystem, value);
		}
	}
}
