using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorVectorStartEnd : IEvaluatorVector
	{
		[Ordinal(0)]  [RED("end")] public Vector4 End { get; set; }
		[Ordinal(1)]  [RED("start")] public Vector4 Start { get; set; }

		public CEvaluatorVectorStartEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
