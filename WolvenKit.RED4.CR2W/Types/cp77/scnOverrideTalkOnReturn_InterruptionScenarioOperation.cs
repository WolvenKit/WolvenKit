using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOverrideTalkOnReturn_InterruptionScenarioOperation : scnIInterruptionScenarioOperation
	{
		[Ordinal(0)] [RED("talkOnReturn")] public CBool TalkOnReturn { get; set; }

		public scnOverrideTalkOnReturn_InterruptionScenarioOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
