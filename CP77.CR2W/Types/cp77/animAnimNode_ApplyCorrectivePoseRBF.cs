using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ApplyCorrectivePoseRBF : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("rbfCoefficient")] public CFloat RbfCoefficient { get; set; }
		[Ordinal(3)] [RED("rbfPowValue")] public CFloat RbfPowValue { get; set; }
		[Ordinal(4)] [RED("correctiveFrame")] public CFloat CorrectiveFrame { get; set; }
		[Ordinal(5)] [RED("correctives")] public CArray<animCorrectivePoseEntry> Correctives { get; set; }

		public animAnimNode_ApplyCorrectivePoseRBF(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
