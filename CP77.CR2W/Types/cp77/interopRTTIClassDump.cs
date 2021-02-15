using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopRTTIClassDump : CVariable
	{
		[Ordinal(0)] [RED("classNames")] public CArray<CString> ClassNames { get; set; }
		[Ordinal(1)] [RED("descriptiveNames")] public CArray<CString> DescriptiveNames { get; set; }
		[Ordinal(2)] [RED("resourceInfos")] public CArray<interopRTTIResourceDumpInfo> ResourceInfos { get; set; }
		[Ordinal(3)] [RED("entries")] public CArray<interopRTTIClassDumpEntry> Entries { get; set; }

		public interopRTTIClassDump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
