using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseSimpleBox : senseIShape
	{
		[Ordinal(1)] [RED("box")] public Box Box { get; set; }

		public senseSimpleBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
