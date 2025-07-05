using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questToggleWeaponEnabled_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("playerVehicle")] 
		public CBool PlayerVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("val")] 
		public CBool Val
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("weapon")] 
		public CEnum<questVehicleWeaponQuestID> Weapon
		{
			get => GetPropertyValue<CEnum<questVehicleWeaponQuestID>>();
			set => SetPropertyValue<CEnum<questVehicleWeaponQuestID>>(value);
		}

		public questToggleWeaponEnabled_NodeType()
		{
			VehicleRef = new gameEntityReference { Names = new() };
			Val = true;
			Weapon = Enums.questVehicleWeaponQuestID.All;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
