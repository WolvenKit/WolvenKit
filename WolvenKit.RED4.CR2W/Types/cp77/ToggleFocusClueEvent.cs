using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleFocusClueEvent : redEvent
	{
		[Ordinal(0)] [RED("clueIndex")] public CInt32 ClueIndex { get; set; }
		[Ordinal(1)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(2)] [RED("investigationState")] public CEnum<EFocusClueInvestigationState> InvestigationState { get; set; }
		[Ordinal(3)] [RED("updatePS")] public CBool UpdatePS { get; set; }

		public ToggleFocusClueEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
