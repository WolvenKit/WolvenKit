using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
