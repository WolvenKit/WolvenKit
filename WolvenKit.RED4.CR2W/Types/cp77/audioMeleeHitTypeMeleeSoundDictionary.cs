using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeHitTypeMeleeSoundDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioMeleeHitTypeMeleeSoundDictionaryItem> _entries;
		private CHandle<audioMeleeHitTypeMeleeSoundDictionaryItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioMeleeHitTypeMeleeSoundDictionaryItem> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<audioMeleeHitTypeMeleeSoundDictionaryItem>) CR2WTypeManager.Create("array:audioMeleeHitTypeMeleeSoundDictionaryItem", "entries", cr2w, this);
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
		public CHandle<audioMeleeHitTypeMeleeSoundDictionaryItem> EntryType
		{
			get
			{
				if (_entryType == null)
				{
					_entryType = (CHandle<audioMeleeHitTypeMeleeSoundDictionaryItem>) CR2WTypeManager.Create("handle:audioMeleeHitTypeMeleeSoundDictionaryItem", "entryType", cr2w, this);
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

		public audioMeleeHitTypeMeleeSoundDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
