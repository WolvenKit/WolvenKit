using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NewBackdoorDeviceRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("device")] 
		public CHandle<ScriptableDeviceComponentPS> Device
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceComponentPS>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceComponentPS>>(value);
		}
	}
}
