using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TeleportDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("teleport")] 
		public STeleportOperationData Teleport
		{
			get => GetPropertyValue<STeleportOperationData>();
			set => SetPropertyValue<STeleportOperationData>(value);
		}

		public TeleportDeviceOperation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
