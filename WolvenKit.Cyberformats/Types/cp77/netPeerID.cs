using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class netPeerID : CVariable
	{
		[Ordinal(0)] [RED("value")] public CUInt8 Value { get; set; }

		public netPeerID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
