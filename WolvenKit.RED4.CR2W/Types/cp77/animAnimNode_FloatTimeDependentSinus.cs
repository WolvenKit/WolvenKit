using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTimeDependentSinus : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("min")] public CFloat Min { get; set; }
		[Ordinal(12)] [RED("max")] public CFloat Max { get; set; }
		[Ordinal(13)] [RED("frequencyFactor")] public CFloat FrequencyFactor { get; set; }
		[Ordinal(14)] [RED("phaseFactor")] public CFloat PhaseFactor { get; set; }

		public animAnimNode_FloatTimeDependentSinus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
