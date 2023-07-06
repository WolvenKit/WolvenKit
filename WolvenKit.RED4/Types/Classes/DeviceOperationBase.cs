using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class DeviceOperationBase : IScriptable
	{
		[Ordinal(0)] 
		[RED("operationName")] 
		public CName OperationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("executeOnce")] 
		public CBool ExecuteOnce
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("toggleOperations")] 
		public CArray<SToggleDeviceOperationData> ToggleOperations
		{
			get => GetPropertyValue<CArray<SToggleDeviceOperationData>>();
			set => SetPropertyValue<CArray<SToggleDeviceOperationData>>(value);
		}

		[Ordinal(4)] 
		[RED("disableDevice")] 
		public CBool DisableDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DeviceOperationBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
