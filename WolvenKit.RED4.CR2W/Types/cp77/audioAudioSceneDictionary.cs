using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioAudioSceneDictionaryItem> _entries;
		private CHandle<audioAudioSceneDictionaryItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioAudioSceneDictionaryItem> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<audioAudioSceneDictionaryItem>) CR2WTypeManager.Create("array:audioAudioSceneDictionaryItem", "entries", cr2w, this);
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
		public CHandle<audioAudioSceneDictionaryItem> EntryType
		{
			get
			{
				if (_entryType == null)
				{
					_entryType = (CHandle<audioAudioSceneDictionaryItem>) CR2WTypeManager.Create("handle:audioAudioSceneDictionaryItem", "entryType", cr2w, this);
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

		public audioAudioSceneDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
