using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutlineRequestEvent : redEvent
	{
		[Ordinal(0)] [RED("outlineRequest")] public CHandle<OutlineRequest> OutlineRequest { get; set; }
		[Ordinal(1)] [RED("flag")] public CBool Flag { get; set; }

		public OutlineRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
