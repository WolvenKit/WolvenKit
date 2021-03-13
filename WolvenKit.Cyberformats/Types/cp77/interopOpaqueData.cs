using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopOpaqueData : CVariable
	{
		[Ordinal(0)] [RED("description")] public CString Description { get; set; }
		[Ordinal(1)] [RED("payload")] public CString Payload { get; set; }
		[Ordinal(2)] [RED("version")] public CInt32 Version { get; set; }

		public interopOpaqueData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
