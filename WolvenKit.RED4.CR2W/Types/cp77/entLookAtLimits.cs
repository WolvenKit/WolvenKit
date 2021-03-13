using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLookAtLimits : CVariable
	{
		[Ordinal(0)] [RED("softLimitDegrees")] public CFloat SoftLimitDegrees { get; set; }
		[Ordinal(1)] [RED("hardLimitDegrees")] public CFloat HardLimitDegrees { get; set; }
		[Ordinal(2)] [RED("hardLimitDistance")] public CFloat HardLimitDistance { get; set; }
		[Ordinal(3)] [RED("backLimitDegrees")] public CFloat BackLimitDegrees { get; set; }

		public entLookAtLimits(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
