using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorColorMultiCurve : IEvaluatorColor
	{
		[Ordinal(0)]  [RED("curves")] public multiChannelCurve<CFloat> Curves { get; set; }
		[Ordinal(1)]  [RED("numberOfCurveSamples")] public CUInt32 NumberOfCurveSamples { get; set; }

		public CEvaluatorColorMultiCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
