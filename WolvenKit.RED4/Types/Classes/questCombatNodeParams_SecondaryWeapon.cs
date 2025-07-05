using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCombatNodeParams_SecondaryWeapon : questCombatNodeParams
	{
		[Ordinal(0)] 
		[RED("unEquip")] 
		public CBool UnEquip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCombatNodeParams_SecondaryWeapon()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
