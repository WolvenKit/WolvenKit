using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopRTTIResourceDumpInfo : CVariable
	{
		[Ordinal(0)]  [RED("extension")] public CString Extension { get; set; }
		[Ordinal(1)]  [RED("deprecatedExtension")] public CString DeprecatedExtension { get; set; }
		[Ordinal(2)]  [RED("friendlyDescription")] public CString FriendlyDescription { get; set; }

		public interopRTTIResourceDumpInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
