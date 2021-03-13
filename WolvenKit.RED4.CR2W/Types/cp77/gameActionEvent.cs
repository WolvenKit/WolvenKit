using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionEvent : AIAIEvent
	{
		[Ordinal(2)] [RED("eventAction")] public CName EventAction { get; set; }
		[Ordinal(3)] [RED("internalEvent")] public CHandle<gameActionInternalEvent> InternalEvent { get; set; }

		public gameActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
