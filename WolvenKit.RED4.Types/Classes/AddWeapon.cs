using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddWeapon : AIbehaviortaskScript
	{
		private CEnum<EquipmentPriority> _weapon;

		[Ordinal(0)] 
		[RED("weapon")] 
		public CEnum<EquipmentPriority> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		public AddWeapon()
		{
			_weapon = new() { Value = Enums.EquipmentPriority.All };
		}
	}
}
