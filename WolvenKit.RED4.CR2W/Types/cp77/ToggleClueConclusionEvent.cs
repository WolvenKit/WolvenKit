using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleClueConclusionEvent : redEvent
	{
		[Ordinal(0)] [RED("toggleConclusion")] public CBool ToggleConclusion { get; set; }
		[Ordinal(1)] [RED("clueID")] public CInt32 ClueID { get; set; }
		[Ordinal(2)] [RED("updatePS")] public CBool UpdatePS { get; set; }

		public ToggleClueConclusionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
