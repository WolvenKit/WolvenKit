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
			get
			{
				if (_eventDispatcher == null)
				{
					_eventDispatcher = (wCHandle<worlduiIWidgetGameController>) CR2WTypeManager.Create("whandle:worlduiIWidgetGameController", "eventDispatcher", cr2w, this);
				}
				return _eventDispatcher;
			}
			set
			{
				if (_eventDispatcher == value)
				{
					return;
				}
				_eventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("journalEntry")] 
		public wCHandle<gameJournalEntry> JournalEntry
		{
			get
			{
				if (_journalEntry == null)
				{
					_journalEntry = (wCHandle<gameJournalEntry>) CR2WTypeManager.Create("whandle:gameJournalEntry", "journalEntry", cr2w, this);
				}
				return _journalEntry;
			}
			set
			{
				if (_journalEntry == value)
				{
					return;
				}
				_journalEntry = value;
				PropertySet(this);
			}
		}

		public OpenMessengerNotificationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
