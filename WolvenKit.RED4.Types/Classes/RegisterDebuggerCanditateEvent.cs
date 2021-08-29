using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterDebuggerCanditateEvent : redEvent
	{
		private CWeakHandle<Device> _device;

		[Ordinal(0)] 
		[RED("device")] 
		public CWeakHandle<Device> Device
		{
			get => GetProperty(ref _device);
			set => SetProperty(ref _device, value);
		}
	}
}
