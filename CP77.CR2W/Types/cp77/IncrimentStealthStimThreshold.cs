using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IncrimentStealthStimThreshold : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("thresholdTimeout")] public CFloat ThresholdTimeout { get; set; }

		public IncrimentStealthStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
