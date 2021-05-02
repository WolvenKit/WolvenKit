using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenMessengerNotificationAction : GenericNotificationBaseAction
	{
		private wCHandle<worlduiIWidgetGameController> _eventDispatcher;
		private wCHandle<gameJournalEntry> _journalEntry;

		[Ordinal(0)] 
		[RED("eventDispatcher")] 
		public wCHandle<worlduiIWidgetGameController> EventDispatcher
		{
			get => GetProperty(ref _eventDispatcher);
			set => SetProperty(ref _eventDispatcher, value);
		}

		[Ordinal(1)] 
		[RED("journalEntry")] 
		public wCHandle<gameJournalEntry> JournalEntry
		{
			get => GetProperty(ref _journalEntry);
			set => SetProperty(ref _journalEntry, value);
		}

		public OpenMessengerNotificationAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
