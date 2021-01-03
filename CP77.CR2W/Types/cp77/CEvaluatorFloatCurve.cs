using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorFloatCurve : IEvaluatorFloat
	{
		[Ordinal(0)]  [RED("curves")] public curveData<CFloat> Curves { get; set; }
		[Ordinal(1)]  [RED("numberOfCurveSamples")] public CUInt32 NumberOfCurveSamples { get; set; }

		public CEvaluatorFloatCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
