using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorStateOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EDoorStatus> State
		{
			get => GetPropertyValue<CEnum<EDoorStatus>>();
			set => SetPropertyValue<CEnum<EDoorStatus>>(value);
		}
	}
}
