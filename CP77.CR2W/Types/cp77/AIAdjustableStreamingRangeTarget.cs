using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIAdjustableStreamingRangeTarget : gameObject
	{
		[Ordinal(40)] [RED("minStreamingDistance")] public CFloat MinStreamingDistance { get; set; }

		public AIAdjustableStreamingRangeTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
