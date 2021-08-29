using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioWeaponTailOverrides : audioInlinedAudioMetadata
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
	}
}
