using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceNPCControllerPS : ActivatedDeviceControllerPS
	{
		[Ordinal(108)] 
		[RED("activatedDeviceNPCSetup")] 
		public ActivatedDeviceNPCSetup ActivatedDeviceNPCSetup
		{
			get => GetPropertyValue<ActivatedDeviceNPCSetup>();
			set => SetPropertyValue<ActivatedDeviceNPCSetup>(value);
		}

		public ActivatedDeviceNPCControllerPS()
		{
			ActivatedDeviceNPCSetup = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
