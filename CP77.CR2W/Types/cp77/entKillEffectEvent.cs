using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entKillEffectEvent : redEvent
	{
		[Ordinal(0)]  [RED("breakAllLoops")] public CBool BreakAllLoops { get; set; }
		[Ordinal(1)]  [RED("effectName")] public CName EffectName { get; set; }

		public entKillEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
