using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseDeviceData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		[Ordinal(1)] 
		[RED("durabilityType")] 
		public CEnum<EDeviceDurabilityType> DurabilityType
		{
			get => GetPropertyValue<CEnum<EDeviceDurabilityType>>();
			set => SetPropertyValue<CEnum<EDeviceDurabilityType>>(value);
		}

		[Ordinal(2)] 
		[RED("deviceName")] 
		public CString DeviceName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("debugName")] 
		public CName DebugName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("hackOwner")] 
		public CWeakHandle<gameObject> HackOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public BaseDeviceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
