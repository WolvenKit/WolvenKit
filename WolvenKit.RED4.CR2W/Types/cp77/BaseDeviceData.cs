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
			get
			{
				if (_deviceState == null)
				{
					_deviceState = (CEnum<EDeviceStatus>) CR2WTypeManager.Create("EDeviceStatus", "deviceState", cr2w, this);
				}
				return _deviceState;
			}
			set
			{
				if (_deviceState == value)
				{
					return;
				}
				_deviceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("durabilityType")] 
		public CEnum<EDeviceDurabilityType> DurabilityType
		{
			get
			{
				if (_durabilityType == null)
				{
					_durabilityType = (CEnum<EDeviceDurabilityType>) CR2WTypeManager.Create("EDeviceDurabilityType", "durabilityType", cr2w, this);
				}
				return _durabilityType;
			}
			set
			{
				if (_durabilityType == value)
				{
					return;
				}
				_durabilityType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("deviceName")] 
		public CString DeviceName
		{
			get
			{
				if (_deviceName == null)
				{
					_deviceName = (CString) CR2WTypeManager.Create("String", "deviceName", cr2w, this);
				}
				return _deviceName;
			}
			set
			{
				if (_deviceName == value)
				{
					return;
				}
				_deviceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("debugName")] 
		public CName DebugName
		{
			get
			{
				if (_debugName == null)
				{
					_debugName = (CName) CR2WTypeManager.Create("CName", "debugName", cr2w, this);
				}
				return _debugName;
			}
			set
			{
				if (_debugName == value)
				{
					return;
				}
				_debugName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hackOwner")] 
		public wCHandle<gameObject> HackOwner
		{
			get
			{
				if (_hackOwner == null)
				{
					_hackOwner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "hackOwner", cr2w, this);
				}
				return _hackOwner;
			}
			set
			{
				if (_hackOwner == value)
				{
					return;
				}
				_hackOwner = value;
				PropertySet(this);
			}
		}

		public BaseDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
