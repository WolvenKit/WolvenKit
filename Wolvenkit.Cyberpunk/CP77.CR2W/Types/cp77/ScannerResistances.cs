using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerResistances : ScannerChunk
	{
		[Ordinal(0)]  [RED("resists")] public CArray<ScannerStatDetails> Resists { get; set; }

		public ScannerResistances(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
