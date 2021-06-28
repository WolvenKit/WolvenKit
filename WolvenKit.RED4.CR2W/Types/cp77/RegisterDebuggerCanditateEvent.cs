using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterDebuggerCanditateEvent : redEvent
	{
		private wCHandle<Device> _device;

		[Ordinal(0)] 
		[RED("device")] 
		public wCHandle<Device> Device
		{
			get => GetProperty(ref _device);
			set => SetProperty(ref _device, value);
		}

		public RegisterDebuggerCanditateEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
