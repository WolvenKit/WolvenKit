using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceOperationsContainer : IScriptable
	{
		[Ordinal(0)] 
		[RED("operations")] 
		public CArray<CHandle<DeviceOperationBase>> Operations
		{
			get => GetPropertyValue<CArray<CHandle<DeviceOperationBase>>>();
			set => SetPropertyValue<CArray<CHandle<DeviceOperationBase>>>(value);
		}

		[Ordinal(1)] 
		[RED("triggers")] 
		public CArray<CHandle<DeviceOperationsTrigger>> Triggers
		{
			get => GetPropertyValue<CArray<CHandle<DeviceOperationsTrigger>>>();
			set => SetPropertyValue<CArray<CHandle<DeviceOperationsTrigger>>>(value);
		}

		public DeviceOperationsContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
