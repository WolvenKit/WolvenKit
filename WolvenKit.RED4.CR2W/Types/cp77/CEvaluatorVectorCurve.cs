using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorVectorCurve : IEvaluatorVector
	{
		[Ordinal(2)] [RED("curves")] public curveData<Vector4> Curves { get; set; }
		[Ordinal(3)] [RED("numberOfCurveSamples")] public CUInt32 NumberOfCurveSamples { get; set; }

		public CEvaluatorVectorCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
