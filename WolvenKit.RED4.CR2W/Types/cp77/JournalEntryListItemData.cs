using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalEntryListItemData : IScriptable
	{
		private wCHandle<gameJournalEntry> _entry;
		private CHandle<IScriptable> _extraData;

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

		[Ordinal(1)] 
		[RED("extraData")] 
		public CHandle<IScriptable> ExtraData
		{
			get
			{
				if (_extraData == null)
				{
					_extraData = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "extraData", cr2w, this);
				}
				return _extraData;
			}
			set
			{
				if (_extraData == value)
				{
					return;
				}
				_extraData = value;
				PropertySet(this);
			}
		}

		public JournalEntryListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
