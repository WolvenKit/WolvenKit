using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameVisionRevealExpiredEvent : redEvent
	{
		[Ordinal(0)]  [RED("revealId")] public gameVisionModeSystemRevealIdentifier RevealId { get; set; }

		public gameVisionRevealExpiredEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
