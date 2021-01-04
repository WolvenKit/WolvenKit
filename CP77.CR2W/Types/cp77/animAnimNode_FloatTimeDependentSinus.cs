using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTimeDependentSinus : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("frequencyFactor")] public CFloat FrequencyFactor { get; set; }
		[Ordinal(1)]  [RED("max")] public CFloat Max { get; set; }
		[Ordinal(2)]  [RED("min")] public CFloat Min { get; set; }
		[Ordinal(3)]  [RED("phaseFactor")] public CFloat PhaseFactor { get; set; }

		public animAnimNode_FloatTimeDependentSinus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
