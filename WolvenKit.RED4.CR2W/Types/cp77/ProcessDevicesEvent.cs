using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProcessDevicesEvent : redEvent
	{
		private CArray<CHandle<gameDeviceComponentPS>> _devices;

		[Ordinal(0)] 
		[RED("devices")] 
		public CArray<CHandle<gameDeviceComponentPS>> Devices
		{
			get => GetProperty(ref _devices);
			set => SetProperty(ref _devices, value);
		}

		public ProcessDevicesEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
