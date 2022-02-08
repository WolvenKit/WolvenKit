namespace WolvenKit.RED4.Types
{
    [REDClass]
    public partial class audioPlayerWeaponSettings
    {
        //either before or after weaponTailOverrides
        [Ordinal(18)]
        [RED("animEventOverrides")]
        public CHandle<audioWeaponEventOverrides> AnimEventOverrides
        {
            get => GetPropertyValue<CHandle<audioWeaponEventOverrides>>();
            set => SetPropertyValue<CHandle<audioWeaponEventOverrides>>(value);
        }
    }
}
