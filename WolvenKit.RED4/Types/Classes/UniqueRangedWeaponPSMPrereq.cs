using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UniqueRangedWeaponPSMPrereq : PlayerStateMachinePrereq
	{
		[Ordinal(4)] 
		[RED("weaponRequiredTag")] 
		public CName WeaponRequiredTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public UniqueRangedWeaponPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
