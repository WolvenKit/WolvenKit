using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ToggleFocusClueEvent : redEvent
	{
		[Ordinal(0)]  [RED("clueIndex")] public CInt32 ClueIndex { get; set; }
		[Ordinal(1)]  [RED("investigationState")] public CEnum<EFocusClueInvestigationState> InvestigationState { get; set; }
		[Ordinal(2)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)]  [RED("updatePS")] public CBool UpdatePS { get; set; }

		public ToggleFocusClueEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
