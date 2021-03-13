using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ApplyCorrectivePoseRBF : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("rbfCoefficient")] public CFloat RbfCoefficient { get; set; }
		[Ordinal(13)] [RED("rbfPowValue")] public CFloat RbfPowValue { get; set; }
		[Ordinal(14)] [RED("correctiveFrame")] public CFloat CorrectiveFrame { get; set; }
		[Ordinal(15)] [RED("correctives")] public CArray<animCorrectivePoseEntry> Correctives { get; set; }

		public animAnimNode_ApplyCorrectivePoseRBF(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
