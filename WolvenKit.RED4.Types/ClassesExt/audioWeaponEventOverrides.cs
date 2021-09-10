namespace WolvenKit.RED4.Types
{
    [REDMeta]
    public class audioWeaponEventOverrides : RedBaseClass
    {
        [Ordinal(0)]
        [RED("entries")]
        public CArray<audioWeaponEventOverride> Entries
        {
            get => GetPropertyValue<CArray<audioWeaponEventOverride>>();
            set => SetPropertyValue<CArray<audioWeaponEventOverride>>(value);
        }

        [Ordinal(1)]
        [RED("entryType")]
        public CHandle<audioWeaponEventOverride> EntryType
        {
            get => GetPropertyValue<CHandle<audioWeaponEventOverride>>();
            set => SetPropertyValue<CHandle<audioWeaponEventOverride>>(value);
        }
    }

    [REDMeta]
    public class audioWeaponEventOverride : RedBaseClass
    {
        [RED("key")]
        public CName Key
        {
            get => GetPropertyValue<CName>();
            set => SetPropertyValue<CName>(value);
        }

        [RED("value")]
        public CName Value
        {
            get => GetPropertyValue<CName>();
            set => SetPropertyValue<CName>(value);
        }
    }
}
