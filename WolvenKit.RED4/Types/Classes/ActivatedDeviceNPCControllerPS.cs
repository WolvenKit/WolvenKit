using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceNPCControllerPS : ActivatedDeviceControllerPS
	{
		[Ordinal(111)] 
		[RED("activatedDeviceNPCSetup")] 
		public ActivatedDeviceNPCSetup ActivatedDeviceNPCSetup
		{
			get => GetPropertyValue<ActivatedDeviceNPCSetup>();
			set => SetPropertyValue<ActivatedDeviceNPCSetup>(value);
		}

		public ActivatedDeviceNPCControllerPS()
		{
			ActivatedDeviceNPCSetup = new ActivatedDeviceNPCSetup();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
