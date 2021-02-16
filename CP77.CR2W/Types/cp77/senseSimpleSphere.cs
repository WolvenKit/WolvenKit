using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseSimpleSphere : senseIShape
	{
		[Ordinal(1)] [RED("sphere")] public Sphere Sphere { get; set; }

		public senseSimpleSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
