using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseDeviceData : CVariable
	{
		private CEnum<EDeviceStatus> _deviceState;
		private CEnum<EDeviceDurabilityType> _durabilityType;
		private CString _deviceName;
		private CName _debugName;
		private wCHandle<gameObject> _hackOwner;

		[Ordinal(0)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get => GetProperty(ref _deviceState);
			set => SetProperty(ref _deviceState, value);
		}

		[Ordinal(1)] 
		[RED("durabilityType")] 
		public CEnum<EDeviceDurabilityType> DurabilityType
		{
			get => GetProperty(ref _durabilityType);
			set => SetProperty(ref _durabilityType, value);
		}

		[Ordinal(2)] 
		[RED("deviceName")] 
		public CString DeviceName
		{
			get => GetProperty(ref _deviceName);
			set => SetProperty(ref _deviceName, value);
		}

		[Ordinal(3)] 
		[RED("debugName")] 
		public CName DebugName
		{
			get => GetProperty(ref _debugName);
			set => SetProperty(ref _debugName, value);
		}

		[Ordinal(4)] 
		[RED("hackOwner")] 
		public wCHandle<gameObject> HackOwner
		{
			get => GetProperty(ref _hackOwner);
			set => SetProperty(ref _hackOwner, value);
		}

		public BaseDeviceData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
