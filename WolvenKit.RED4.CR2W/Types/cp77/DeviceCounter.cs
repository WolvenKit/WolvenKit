using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceCounter : CVariable
	{
		private CArray<CHandle<gameDeviceComponentPS>> _devices;
		private CEnum<EVirtualSystem> _systemType;

		[Ordinal(0)] 
		[RED("devices")] 
		public CArray<CHandle<gameDeviceComponentPS>> Devices
		{
			get
			{
				if (_devices == null)
				{
					_devices = (CArray<CHandle<gameDeviceComponentPS>>) CR2WTypeManager.Create("array:handle:gameDeviceComponentPS", "devices", cr2w, this);
				}
				return _devices;
			}
			set
			{
				if (_devices == value)
				{
					return;
				}
				_devices = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("systemType")] 
		public CEnum<EVirtualSystem> SystemType
		{
			get
			{
				if (_systemType == null)
				{
					_systemType = (CEnum<EVirtualSystem>) CR2WTypeManager.Create("EVirtualSystem", "systemType", cr2w, this);
				}
				return _systemType;
			}
			set
			{
				if (_systemType == value)
				{
					return;
				}
				_systemType = value;
				PropertySet(this);
			}
		}

		public DeviceCounter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
