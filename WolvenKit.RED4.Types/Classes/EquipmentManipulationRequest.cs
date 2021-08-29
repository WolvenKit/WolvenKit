using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentManipulationRequest : IScriptable
	{
		private CEnum<EquipmentManipulationRequestType> _requestType;
		private CEnum<EquipmentManipulationRequestSlot> _requestSlot;
		private CEnum<gameEquipAnimationType> _equipAnim;

		[Ordinal(0)] 
		[RED("requestType")] 
		public CEnum<EquipmentManipulationRequestType> RequestType
		{
			get => GetProperty(ref _requestType);
			set => SetProperty(ref _requestType, value);
		}

		[Ordinal(1)] 
		[RED("requestSlot")] 
		public CEnum<EquipmentManipulationRequestSlot> RequestSlot
		{
			get => GetProperty(ref _requestSlot);
			set => SetProperty(ref _requestSlot, value);
		}

		[Ordinal(2)] 
		[RED("equipAnim")] 
		public CEnum<gameEquipAnimationType> EquipAnim
		{
			get => GetProperty(ref _equipAnim);
			set => SetProperty(ref _equipAnim, value);
		}
	}
}
