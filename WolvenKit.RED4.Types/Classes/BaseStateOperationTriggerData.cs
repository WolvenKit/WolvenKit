using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseStateOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EDeviceStatus> State
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}
	}
}
