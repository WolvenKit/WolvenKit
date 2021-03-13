using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorFloatCurve : IEvaluatorFloat
	{
		[Ordinal(0)] [RED("curves")] public curveData<CFloat> Curves { get; set; }
		[Ordinal(1)] [RED("numberOfCurveSamples")] public CUInt32 NumberOfCurveSamples { get; set; }

		public CEvaluatorFloatCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
