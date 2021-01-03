using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameActionEvent : AIAIEvent
	{
		[Ordinal(0)]  [RED("eventAction")] public CName EventAction { get; set; }
		[Ordinal(1)]  [RED("internalEvent")] public CHandle<gameActionInternalEvent> InternalEvent { get; set; }

		public gameActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
