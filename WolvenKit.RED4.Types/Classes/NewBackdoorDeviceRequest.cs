using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NewBackdoorDeviceRequest : gameScriptableSystemRequest
	{
		private CHandle<ScriptableDeviceComponentPS> _device;

		[Ordinal(0)] 
		[RED("device")] 
		public CHandle<ScriptableDeviceComponentPS> Device
		{
			get => GetProperty(ref _device);
			set => SetProperty(ref _device, value);
		}
	}
}
