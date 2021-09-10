using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVulnerabilities : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("vulnerabilities")] 
		public CArray<Vulnerability> Vulnerabilities
		{
			get => GetPropertyValue<CArray<Vulnerability>>();
			set => SetPropertyValue<CArray<Vulnerability>>(value);
		}

		public ScannerVulnerabilities()
		{
			Vulnerabilities = new();
		}
	}
}
