using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerResistances : ScannerChunk
	{
		private CArray<ScannerStatDetails> _resists;

		[Ordinal(0)] 
		[RED("resists")] 
		public CArray<ScannerStatDetails> Resists
		{
			get => GetProperty(ref _resists);
			set => SetProperty(ref _resists, value);
		}
	}
}
