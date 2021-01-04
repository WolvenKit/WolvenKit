using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorColorStartEnd : IEvaluatorColor
	{
		[Ordinal(0)]  [RED("end")] public CColor End { get; set; }
		[Ordinal(1)]  [RED("start")] public CColor Start { get; set; }

		public CEvaluatorColorStartEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
