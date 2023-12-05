using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargedHotkeyItemGadgetController : ChargedHotkeyItemBaseController
	{
		[Ordinal(44)] 
		[RED("currentStatPoolType")] 
		public CEnum<gamedataStatPoolType> CurrentStatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(45)] 
		[RED("c_grenadeKey")] 
		public CName C_grenadeKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(46)] 
		[RED("c_projectileLauncherKey")] 
		public CName C_projectileLauncherKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(47)] 
		[RED("c_opticalCamoKey")] 
		public CName C_opticalCamoKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(48)] 
		[RED("c_cwMaskKey")] 
		public CName C_cwMaskKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(49)] 
		[RED("opticalCamoTags")] 
		public CArray<CName> OpticalCamoTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(50)] 
		[RED("currentCombatState")] 
		public CEnum<gamePSMCombat> CurrentCombatState
		{
			get => GetPropertyValue<CEnum<gamePSMCombat>>();
			set => SetPropertyValue<CEnum<gamePSMCombat>>(value);
		}

		[Ordinal(51)] 
		[RED("combatStateCallback")] 
		public CHandle<redCallbackObject> CombatStateCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(52)] 
		[RED("c_grenadeFlashSalePerkType")] 
		public CEnum<gamedataNewPerkType> C_grenadeFlashSalePerkType
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		public ChargedHotkeyItemGadgetController()
		{
			C_grenadeKey = "Grenade";
			C_projectileLauncherKey = "ProjectileLauncher";
			C_opticalCamoKey = "OpticalCamo";
			C_cwMaskKey = "CWMask";
			OpticalCamoTags = new();
			C_grenadeFlashSalePerkType = Enums.gamedataNewPerkType.Tech_Left_Perk_3_3;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
