
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPlayerVehicleDisplayOverride_Record
	{
        [RED("activeState")]
        [REDProperty(IsIgnored = true)]
        public CName ActiveState
        {
            get => GetPropertyValue<CName>();
            set => SetPropertyValue<CName>(value);
        }

        [RED("defaultState")]
        [REDProperty(IsIgnored = true)]
        public CName DefaultState
        {
            get => GetPropertyValue<CName>();
            set => SetPropertyValue<CName>(value);
        }

        [RED("forcedFavorite")]
        [REDProperty(IsIgnored = true)]
        public CBool ForcedFavorite
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [RED("icon")]
        [REDProperty(IsIgnored = true)]
        public CName Icon
        {
            get => GetPropertyValue<CName>();
            set => SetPropertyValue<CName>(value);
        }
	}
}
