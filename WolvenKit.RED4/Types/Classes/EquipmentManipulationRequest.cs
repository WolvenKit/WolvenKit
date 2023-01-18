using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipmentManipulationRequest : IScriptable
	{
		[Ordinal(0)] 
		[RED("requestType")] 
		public CEnum<EquipmentManipulationRequestType> RequestType
		{
			get => GetPropertyValue<CEnum<EquipmentManipulationRequestType>>();
			set => SetPropertyValue<CEnum<EquipmentManipulationRequestType>>(value);
		}

		[Ordinal(1)] 
		[RED("requestSlot")] 
		public CEnum<EquipmentManipulationRequestSlot> RequestSlot
		{
			get => GetPropertyValue<CEnum<EquipmentManipulationRequestSlot>>();
			set => SetPropertyValue<CEnum<EquipmentManipulationRequestSlot>>(value);
		}

		[Ordinal(2)] 
		[RED("equipAnim")] 
		public CEnum<gameEquipAnimationType> EquipAnim
		{
			get => GetPropertyValue<CEnum<gameEquipAnimationType>>();
			set => SetPropertyValue<CEnum<gameEquipAnimationType>>(value);
		}

		public EquipmentManipulationRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
