using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnOpenCodexAtEntryEvent : redEvent
	{
		private wCHandle<gameJournalCodexEntry> _entry;

		[Ordinal(0)] 
		[RED("entry")] 
		public wCHandle<gameJournalCodexEntry> Entry
		{
			get
			{
				if (_entry == null)
				{
					_entry = (wCHandle<gameJournalCodexEntry>) CR2WTypeManager.Create("whandle:gameJournalCodexEntry", "entry", cr2w, this);
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

		public OnOpenCodexAtEntryEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
