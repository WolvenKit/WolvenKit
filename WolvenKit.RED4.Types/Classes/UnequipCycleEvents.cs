using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnequipCycleEvents : EquipmentBaseEvents
	{
		[Ordinal(0)] 
		[RED("stateMachineInstanceData")] 
		public gamestateMachineStateMachineInstanceData StateMachineInstanceData
		{
			get => GetPropertyValue<gamestateMachineStateMachineInstanceData>();
			set => SetPropertyValue<gamestateMachineStateMachineInstanceData>(value);
		}

		public UnequipCycleEvents()
		{
			StateMachineInstanceData = new();
		}
	}
}
