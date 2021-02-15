using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameFxResource : CVariable
	{
		[Ordinal(0)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }

		public gameFxResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
