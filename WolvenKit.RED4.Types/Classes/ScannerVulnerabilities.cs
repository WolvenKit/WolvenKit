using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVulnerabilities : ScannerChunk
	{
		private CArray<Vulnerability> _vulnerabilities;

		[Ordinal(0)] 
		[RED("vulnerabilities")] 
		public CArray<Vulnerability> Vulnerabilities
		{
			get => GetProperty(ref _vulnerabilities);
			set => SetProperty(ref _vulnerabilities, value);
		}
	}
}
