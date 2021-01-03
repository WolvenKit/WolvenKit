using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerDescription : ScannerChunk
	{
		[Ordinal(0)]  [RED("customDescriptions")] public CArray<CString> CustomDescriptions { get; set; }
		[Ordinal(1)]  [RED("defaultFluffDescription")] public CString DefaultFluffDescription { get; set; }

		public ScannerDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
