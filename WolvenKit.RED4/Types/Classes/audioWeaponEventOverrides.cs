using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioWeaponEventOverrides : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioWeaponEventOverride> Entries
		{
			get => GetPropertyValue<CArray<audioWeaponEventOverride>>();
			set => SetPropertyValue<CArray<audioWeaponEventOverride>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioWeaponEventOverride> EntryType
		{
			get => GetPropertyValue<CHandle<audioWeaponEventOverride>>();
			set => SetPropertyValue<CHandle<audioWeaponEventOverride>>(value);
		}

		public audioWeaponEventOverrides()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
