using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentSystemWeaponManipulationRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<EquipmentManipulationAction> _requestType;
		private CEnum<gameEquipAnimationType> _equipAnimType;
		private CBool _removeItemFromEquipSlot;

		[Ordinal(1)] 
		[RED("requestType")] 
		public CEnum<EquipmentManipulationAction> RequestType
		{
			get => GetProperty(ref _requestType);
			set => SetProperty(ref _requestType, value);
		}

		[Ordinal(2)] 
		[RED("equipAnimType")] 
		public CEnum<gameEquipAnimationType> EquipAnimType
		{
			get => GetProperty(ref _equipAnimType);
			set => SetProperty(ref _equipAnimType, value);
		}

		[Ordinal(3)] 
		[RED("removeItemFromEquipSlot")] 
		public CBool RemoveItemFromEquipSlot
		{
			get => GetProperty(ref _removeItemFromEquipSlot);
			set => SetProperty(ref _removeItemFromEquipSlot, value);
		}
	}
}
