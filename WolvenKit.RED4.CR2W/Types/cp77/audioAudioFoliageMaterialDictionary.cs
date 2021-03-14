using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioFoliageMaterialDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioAudioFoliageMaterialDictionaryItem> _entries;
		private CHandle<audioAudioFoliageMaterialDictionaryItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioAudioFoliageMaterialDictionaryItem> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<audioAudioFoliageMaterialDictionaryItem>) CR2WTypeManager.Create("array:audioAudioFoliageMaterialDictionaryItem", "entries", cr2w, this);
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
		public CHandle<audioAudioFoliageMaterialDictionaryItem> EntryType
		{
			get
			{
				if (_entryType == null)
				{
					_entryType = (CHandle<audioAudioFoliageMaterialDictionaryItem>) CR2WTypeManager.Create("handle:audioAudioFoliageMaterialDictionaryItem", "entryType", cr2w, this);
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

		public audioAudioFoliageMaterialDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
