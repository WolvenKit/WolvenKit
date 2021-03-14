using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnVisitedJournalEntryEvent : redEvent
	{
		private wCHandle<gameJournalEntry> _entry;

		[Ordinal(0)] 
		[RED("entry")] 
		public wCHandle<gameJournalEntry> Entry
		{
			get
			{
				if (_entry == null)
				{
					_entry = (wCHandle<gameJournalEntry>) CR2WTypeManager.Create("whandle:gameJournalEntry", "entry", cr2w, this);
				}
				return _entry;
			}
			set
			{
				if (_entry == value)
				{
					return;
				}
				_entry = value;
				PropertySet(this);
			}
		}

		public OnVisitedJournalEntryEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
