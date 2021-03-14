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
			get
			{
				if (_vulnerabilities == null)
				{
					_vulnerabilities = (CArray<Vulnerability>) CR2WTypeManager.Create("array:Vulnerability", "vulnerabilities", cr2w, this);
				}
				return _vulnerabilities;
			}
			set
			{
				if (_vulnerabilities == value)
				{
					return;
				}
				_vulnerabilities = value;
				PropertySet(this);
			}
		}

		public ScannerVulnerabilities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
