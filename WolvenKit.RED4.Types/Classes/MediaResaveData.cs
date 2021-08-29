using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MediaResaveData : RedBaseClass
	{
		private MediaDeviceData _mediaDeviceData;

		[Ordinal(0)] 
		[RED("mediaDeviceData")] 
		public MediaDeviceData MediaDeviceData
		{
			get => GetProperty(ref _mediaDeviceData);
			set => SetProperty(ref _mediaDeviceData, value);
		}
	}
}
