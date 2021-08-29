using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceNPCControllerPS : ActivatedDeviceControllerPS
	{
		private ActivatedDeviceNPCSetup _activatedDeviceNPCSetup;

		[Ordinal(108)] 
		[RED("activatedDeviceNPCSetup")] 
		public ActivatedDeviceNPCSetup ActivatedDeviceNPCSetup
		{
			get => GetProperty(ref _activatedDeviceNPCSetup);
			set => SetProperty(ref _activatedDeviceNPCSetup, value);
		}
	}
}
