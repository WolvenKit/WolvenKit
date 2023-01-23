using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsDeviceRegisterCameraControlOnPuppetEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("component")] 
		public CHandle<gameDeviceCameraControlComponent> Component
		{
			get => GetPropertyValue<CHandle<gameDeviceCameraControlComponent>>();
			set => SetPropertyValue<CHandle<gameDeviceCameraControlComponent>>(value);
		}

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameeventsDeviceRegisterCameraControlOnPuppetEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
