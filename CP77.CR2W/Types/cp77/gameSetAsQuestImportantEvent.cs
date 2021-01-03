using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSetAsQuestImportantEvent : redEvent
	{
		[Ordinal(0)]  [RED("isImportant")] public CBool IsImportant { get; set; }
		[Ordinal(1)]  [RED("propagateToSlaves")] public CBool PropagateToSlaves { get; set; }

		public gameSetAsQuestImportantEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
