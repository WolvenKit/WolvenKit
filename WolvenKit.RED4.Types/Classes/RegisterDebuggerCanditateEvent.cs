using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterDebuggerCanditateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("device")] 
		public CWeakHandle<Device> Device
		{
			get => GetPropertyValue<CWeakHandle<Device>>();
			set => SetPropertyValue<CWeakHandle<Device>>(value);
		}
	}
}
