using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ToggleClueConclusionEvent : redEvent
	{
		[Ordinal(0)]  [RED("clueID")] public CInt32 ClueID { get; set; }
		[Ordinal(1)]  [RED("toggleConclusion")] public CBool ToggleConclusion { get; set; }
		[Ordinal(2)]  [RED("updatePS")] public CBool UpdatePS { get; set; }

		public ToggleClueConclusionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
