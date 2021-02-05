using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entKillEffectEvent : redEvent
	{
		[Ordinal(0)]  [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(1)]  [RED("breakAllLoops")] public CBool BreakAllLoops { get; set; }

		public entKillEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
