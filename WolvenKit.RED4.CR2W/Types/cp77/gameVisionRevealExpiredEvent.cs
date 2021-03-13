using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionRevealExpiredEvent : redEvent
	{
		[Ordinal(0)] [RED("revealId")] public gameVisionModeSystemRevealIdentifier RevealId { get; set; }

		public gameVisionRevealExpiredEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
