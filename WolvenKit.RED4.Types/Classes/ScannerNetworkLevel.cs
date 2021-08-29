using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerNetworkLevel : ScannerChunk
	{
		private CInt32 _networkLevel;

		[Ordinal(0)] 
		[RED("networkLevel")] 
		public CInt32 NetworkLevel
		{
			get => GetProperty(ref _networkLevel);
			set => SetProperty(ref _networkLevel, value);
		}
	}
}
