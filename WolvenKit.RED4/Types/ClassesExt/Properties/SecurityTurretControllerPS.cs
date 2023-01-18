namespace WolvenKit.RED4.Types
{
    public partial class SecurityTurretControllerPS
    {
        [RED("engineeringCheck")]
        public CHandle<EngineeringSkillCheck> EngineeringCheck
        {
            get => GetPropertyValue<CHandle<EngineeringSkillCheck>>();
            set => SetPropertyValue<CHandle<EngineeringSkillCheck>>(value);
        }

        [RED("demolitionCheck")]
        public CHandle<DemolitionSkillCheck> DemolitionCheck
        {
            get => GetPropertyValue<CHandle<DemolitionSkillCheck>>();
            set => SetPropertyValue<CHandle<DemolitionSkillCheck>>(value);
        }
    }
}
