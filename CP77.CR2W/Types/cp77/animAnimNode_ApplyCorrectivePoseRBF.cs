using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ApplyCorrectivePoseRBF : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("correctiveFrame")] public CFloat CorrectiveFrame { get; set; }
		[Ordinal(1)]  [RED("correctives")] public CArray<animCorrectivePoseEntry> Correctives { get; set; }
		[Ordinal(2)]  [RED("rbfCoefficient")] public CFloat RbfCoefficient { get; set; }
		[Ordinal(3)]  [RED("rbfPowValue")] public CFloat RbfPowValue { get; set; }

		public animAnimNode_ApplyCorrectivePoseRBF(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
