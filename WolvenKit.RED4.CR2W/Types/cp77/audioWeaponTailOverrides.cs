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
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioWeaponTailOverride> EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}

		public audioWeaponTailOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
