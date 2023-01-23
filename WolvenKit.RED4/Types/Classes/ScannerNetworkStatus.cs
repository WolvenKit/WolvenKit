using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerNetworkStatus : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("networkStatus")] 
		public CEnum<ScannerNetworkState> NetworkStatus
		{
			get => GetPropertyValue<CEnum<ScannerNetworkState>>();
			set => SetPropertyValue<CEnum<ScannerNetworkState>>(value);
		}

		public ScannerNetworkStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
