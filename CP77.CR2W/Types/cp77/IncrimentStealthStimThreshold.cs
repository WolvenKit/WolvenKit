using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IncrimentStealthStimThreshold : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("thresholdTimeout")] public CFloat ThresholdTimeout { get; set; }

		public IncrimentStealthStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
