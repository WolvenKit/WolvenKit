using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioKeyUiSoundDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioKeyUiSoundPairDictionaryItem> _entries;
		private CHandle<audioKeyUiSoundPairDictionaryItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioKeyUiSoundPairDictionaryItem> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<audioKeyUiSoundPairDictionaryItem>) CR2WTypeManager.Create("array:audioKeyUiSoundPairDictionaryItem", "entries", cr2w, this);
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
		public CHandle<audioKeyUiSoundPairDictionaryItem> EntryType
		{
			get
			{
				if (_entryType == null)
				{
					_entryType = (CHandle<audioKeyUiSoundPairDictionaryItem>) CR2WTypeManager.Create("handle:audioKeyUiSoundPairDictionaryItem", "entryType", cr2w, this);
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

		public audioKeyUiSoundDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
