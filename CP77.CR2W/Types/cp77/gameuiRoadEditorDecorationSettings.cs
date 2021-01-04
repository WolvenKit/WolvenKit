using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRoadEditorDecorationSettings : CVariable
	{
		[Ordinal(0)]  [RED("libraryName")] public CName LibraryName { get; set; }
		[Ordinal(1)]  [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(2)]  [RED("repeatPatternDensity")] public CUInt32 RepeatPatternDensity { get; set; }
		[Ordinal(3)]  [RED("repeatPatternStartOffset")] public CUInt32 RepeatPatternStartOffset { get; set; }

		public gameuiRoadEditorDecorationSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
