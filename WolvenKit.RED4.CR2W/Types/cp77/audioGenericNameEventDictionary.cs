using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGenericNameEventDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioGenericNameEventItem> _entries;
		private CHandle<audioGenericNameEventItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioGenericNameEventItem> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<audioGenericNameEventItem>) CR2WTypeManager.Create("array:audioGenericNameEventItem", "entries", cr2w, this);
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
		public CHandle<audioGenericNameEventItem> EntryType
		{
			get
			{
				if (_entryType == null)
				{
					_entryType = (CHandle<audioGenericNameEventItem>) CR2WTypeManager.Create("handle:audioGenericNameEventItem", "entryType", cr2w, this);
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

		public audioGenericNameEventDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
