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
			get => GetProperty(ref _devices);
			set => SetProperty(ref _devices, value);
		}

		[Ordinal(1)] 
		[RED("systemType")] 
		public CEnum<EVirtualSystem> SystemType
		{
			get => GetProperty(ref _systemType);
			set => SetProperty(ref _systemType, value);
		}

		public DeviceCounter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
