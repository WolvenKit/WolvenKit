using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEventOverrideDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioEventOverrideDictionaryItem> _entries;
		private CHandle<audioEventOverrideDictionaryItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioEventOverrideDictionaryItem> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<audioEventOverrideDictionaryItem>) CR2WTypeManager.Create("array:audioEventOverrideDictionaryItem", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioEventOverrideDictionaryItem> EntryType
		{
			get
			{
				if (_entryType == null)
				{
					_entryType = (CHandle<audioEventOverrideDictionaryItem>) CR2WTypeManager.Create("handle:audioEventOverrideDictionaryItem", "entryType", cr2w, this);
				}
				return _entryType;
			}
			set
			{
				if (_entryType == value)
				{
					return;
				}
				_entryType = value;
				PropertySet(this);
			}
		}

		public audioEventOverrideDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
