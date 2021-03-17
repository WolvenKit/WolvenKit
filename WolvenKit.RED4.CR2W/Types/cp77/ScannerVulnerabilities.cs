using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVulnerabilities : ScannerChunk
	{
		private CArray<Vulnerability> _vulnerabilities;

		[Ordinal(0)] 
		[RED("vulnerabilities")] 
		public CArray<Vulnerability> Vulnerabilities
		{
			get => GetProperty(ref _vulnerabilities);
			set => SetProperty(ref _vulnerabilities, value);
		}

		public ScannerVulnerabilities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
