using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipmentSystemWeaponManipulationRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("requestType")] 
		public CEnum<EquipmentManipulationAction> RequestType
		{
			get => GetPropertyValue<CEnum<EquipmentManipulationAction>>();
			set => SetPropertyValue<CEnum<EquipmentManipulationAction>>(value);
		}

		[Ordinal(2)] 
		[RED("equipAnimType")] 
		public CEnum<gameEquipAnimationType> EquipAnimType
		{
			get => GetPropertyValue<CEnum<gameEquipAnimationType>>();
			set => SetPropertyValue<CEnum<gameEquipAnimationType>>(value);
		}

		[Ordinal(3)] 
		[RED("removeItemFromEquipSlot")] 
		public CBool RemoveItemFromEquipSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EquipmentSystemWeaponManipulationRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
