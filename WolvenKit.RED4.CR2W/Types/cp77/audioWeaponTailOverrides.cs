using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponTailOverrides : audioInlinedAudioMetadata
	{
		private CArray<audioWeaponTailOverride> _entries;
		private CHandle<audioWeaponTailOverride> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioWeaponTailOverride> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<audioWeaponTailOverride>) CR2WTypeManager.Create("array:audioWeaponTailOverride", "entries", cr2w, this);
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
		public CHandle<audioWeaponTailOverride> EntryType
		{
			get
			{
				if (_entryType == null)
				{
					_entryType = (CHandle<audioWeaponTailOverride>) CR2WTypeManager.Create("handle:audioWeaponTailOverride", "entryType", cr2w, this);
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

		public audioWeaponTailOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
