using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIParametrizedResourceReference : AIResourceReference
	{
		[Ordinal(2)] [RED("overrides")] public LibTreeParametersForwarder Overrides { get; set; }

		public AIParametrizedResourceReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
