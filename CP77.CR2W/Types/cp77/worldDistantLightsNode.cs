using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDistantLightsNode : worldNode
	{
		[Ordinal(2)] [RED("data")] public raRef<CDistantLightsResource> Data { get; set; }

		public worldDistantLightsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
