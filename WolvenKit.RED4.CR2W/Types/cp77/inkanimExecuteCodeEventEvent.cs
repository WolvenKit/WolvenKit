using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimExecuteCodeEventEvent : inkanimEvent
	{
		[Ordinal(1)] [RED("eventToExecute")] public CHandle<redEvent> EventToExecute { get; set; }

		public inkanimExecuteCodeEventEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
