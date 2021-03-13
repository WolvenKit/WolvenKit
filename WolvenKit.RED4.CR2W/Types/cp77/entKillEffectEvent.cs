using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entKillEffectEvent : redEvent
	{
		[Ordinal(0)] [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(1)] [RED("breakAllLoops")] public CBool BreakAllLoops { get; set; }

		public entKillEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
