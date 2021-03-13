using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HearStimThreshold : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("thresholdNumber")] public CInt32 ThresholdNumber { get; set; }

		public HearStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
