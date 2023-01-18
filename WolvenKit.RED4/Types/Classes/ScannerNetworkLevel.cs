using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerNetworkLevel : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("networkLevel")] 
		public CInt32 NetworkLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ScannerNetworkLevel()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
