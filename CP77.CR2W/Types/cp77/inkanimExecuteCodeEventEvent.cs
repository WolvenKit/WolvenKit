using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkanimExecuteCodeEventEvent : inkanimEvent
	{
		[Ordinal(0)]  [RED("eventToExecute")] public CHandle<redEvent> EventToExecute { get; set; }

		public inkanimExecuteCodeEventEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
