using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayBinkDeviceOperation : DeviceOperationBase
	{
		private SBinkperationData _bink;

		[Ordinal(5)] 
		[RED("bink")] 
		public SBinkperationData Bink
		{
			get => GetProperty(ref _bink);
			set => SetProperty(ref _bink, value);
		}
	}
}
