using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerResistances : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("resists")] 
		public CArray<ScannerStatDetails> Resists
		{
			get => GetPropertyValue<CArray<ScannerStatDetails>>();
			set => SetPropertyValue<CArray<ScannerStatDetails>>(value);
		}

		public ScannerResistances()
		{
			Resists = new();
		}
	}
}
