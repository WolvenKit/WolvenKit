using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleWeaponUsed_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("weapon")] 
		public CEnum<questVehicleWeaponQuestID> Weapon
		{
			get => GetPropertyValue<CEnum<questVehicleWeaponQuestID>>();
			set => SetPropertyValue<CEnum<questVehicleWeaponQuestID>>(value);
		}

		public questVehicleWeaponUsed_ConditionType()
		{
			VehicleRef = new() { Names = new() };
		}
	}
}
