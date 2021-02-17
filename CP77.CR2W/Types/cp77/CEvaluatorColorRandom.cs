using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorColorRandom : IEvaluatorColor
	{
		[Ordinal(0)] [RED("min")] public CColor Min { get; set; }
		[Ordinal(1)] [RED("max")] public CColor Max { get; set; }
		[Ordinal(2)] [RED("randomPerChannel")] public CBool RandomPerChannel { get; set; }

		public CEvaluatorColorRandom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
