using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StealthStimThreshold : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("stealthThresholdNumber")] public CInt32 StealthThresholdNumber { get; set; }

		public StealthStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
