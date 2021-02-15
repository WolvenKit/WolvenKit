using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FixedPoint : CVariable
	{
		[Ordinal(0)] [RED("Bits")] public CInt32 Bits { get; set; }

		public FixedPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
