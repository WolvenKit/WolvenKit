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
			get => GetProperty(ref _entry);
			set => SetProperty(ref _entry, value);
		}

		[Ordinal(1)] 
		[RED("extraData")] 
		public CHandle<IScriptable> ExtraData
		{
			get => GetProperty(ref _extraData);
			set => SetProperty(ref _extraData, value);
		}

		public JournalEntryListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
