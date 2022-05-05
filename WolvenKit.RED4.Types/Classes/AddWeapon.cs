using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddWeapon : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("weapon")] 
		public CEnum<EquipmentPriority> Weapon
		{
			get => GetPropertyValue<CEnum<EquipmentPriority>>();
			set => SetPropertyValue<CEnum<EquipmentPriority>>(value);
		}

		public AddWeapon()
		{
			Weapon = Enums.EquipmentPriority.All;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
