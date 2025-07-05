using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePoliceRadioSystem : gameIPoliceRadioSystem
	{
		[Ordinal(0)] 
		[RED("lastDistrictEntry")] 
		public CName LastDistrictEntry
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("isHeat1LineRequestOngoing")] 
		public CBool IsHeat1LineRequestOngoing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamePoliceRadioSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
