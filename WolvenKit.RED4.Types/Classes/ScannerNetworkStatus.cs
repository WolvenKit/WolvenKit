using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerNetworkStatus : ScannerChunk
	{
		private CEnum<ScannerNetworkState> _networkStatus;

		[Ordinal(0)] 
		[RED("networkStatus")] 
		public CEnum<ScannerNetworkState> NetworkStatus
		{
			get => GetProperty(ref _networkStatus);
			set => SetProperty(ref _networkStatus, value);
		}
	}
}
