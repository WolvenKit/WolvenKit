using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLocomotionCustomActionEventDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioLocomotionCustomActionEventDictionaryItem> _entries;
		private CHandle<audioLocomotionCustomActionEventDictionaryItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioLocomotionCustomActionEventDictionaryItem> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<audioLocomotionCustomActionEventDictionaryItem>) CR2WTypeManager.Create("array:audioLocomotionCustomActionEventDictionaryItem", "entries", cr2w, this);
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
		public CHandle<audioLocomotionCustomActionEventDictionaryItem> EntryType
		{
			get
			{
				if (_entryType == null)
				{
					_entryType = (CHandle<audioLocomotionCustomActionEventDictionaryItem>) CR2WTypeManager.Create("handle:audioLocomotionCustomActionEventDictionaryItem", "entryType", cr2w, this);
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

		public audioLocomotionCustomActionEventDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
