using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerDescription : ScannerChunk
	{
		[Ordinal(0)]  [RED("customDescriptions")] public CArray<CString> CustomDescriptions { get; set; }
		[Ordinal(1)]  [RED("defaultFluffDescription")] public CString DefaultFluffDescription { get; set; }

		public ScannerDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
