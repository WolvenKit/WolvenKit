using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorStateOperationTriggerData : DeviceOperationTriggerData
	{
		private CEnum<EDoorStatus> _state;

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EDoorStatus> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
