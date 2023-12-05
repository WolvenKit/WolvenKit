using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargedHotkeyItemCyberwareController : ChargedHotkeyItemBaseController
	{
		[Ordinal(44)] 
		[RED("currentStatPoolType")] 
		public CEnum<gamedataStatPoolType> CurrentStatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(45)] 
		[RED("psmBlackboardListener")] 
		public CHandle<redCallbackObject> PsmBlackboardListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(46)] 
		[RED("c_cyberdeckOverclockPerkType")] 
		public CEnum<gamedataNewPerkType> C_cyberdeckOverclockPerkType
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		[Ordinal(47)] 
		[RED("c_vehicleManeuversPerkType")] 
		public CEnum<gamedataNewPerkType> C_vehicleManeuversPerkType
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		[Ordinal(48)] 
		[RED("c_berserkKey")] 
		public CName C_berserkKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(49)] 
		[RED("c_cyberdeckKey")] 
		public CName C_cyberdeckKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(50)] 
		[RED("c_sandevistanKey")] 
		public CName C_sandevistanKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(51)] 
		[RED("c_capacityBoosterKey")] 
		public CName C_capacityBoosterKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ChargedHotkeyItemCyberwareController()
		{
			C_cyberdeckOverclockPerkType = Enums.gamedataNewPerkType.Intelligence_Central_Milestone_3;
			C_vehicleManeuversPerkType = Enums.gamedataNewPerkType.Cool_Left_Milestone_1;
			C_berserkKey = "Berserk";
			C_cyberdeckKey = "Cyberdeck";
			C_sandevistanKey = "Sandevistan";
			C_capacityBoosterKey = "CapacityBooster";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
