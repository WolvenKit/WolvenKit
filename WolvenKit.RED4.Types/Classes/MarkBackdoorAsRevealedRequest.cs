using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MarkBackdoorAsRevealedRequest : gameScriptableSystemRequest
	{
		private CHandle<SharedGameplayPS> _device;

		[Ordinal(0)] 
		[RED("device")] 
		public CHandle<SharedGameplayPS> Device
		{
			get => GetProperty(ref _device);
			set => SetProperty(ref _device, value);
		}
	}
}
