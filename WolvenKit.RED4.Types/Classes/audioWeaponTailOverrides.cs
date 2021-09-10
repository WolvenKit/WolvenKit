using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioWeaponTailOverrides : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioWeaponTailOverride> Entries
		{
			get => GetPropertyValue<CArray<audioWeaponTailOverride>>();
			set => SetPropertyValue<CArray<audioWeaponTailOverride>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioWeaponTailOverride> EntryType
		{
			get => GetPropertyValue<CHandle<audioWeaponTailOverride>>();
			set => SetPropertyValue<CHandle<audioWeaponTailOverride>>(value);
		}

		public audioWeaponTailOverrides()
		{
			Entries = new();
		}
	}
}
