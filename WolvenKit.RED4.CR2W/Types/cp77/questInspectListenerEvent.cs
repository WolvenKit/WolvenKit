using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInspectListenerEvent : redEvent
	{
		[Ordinal(0)] [RED("listener")] public CHandle<questObjectInspectListener> Listener { get; set; }
		[Ordinal(1)] [RED("register")] public CBool Register { get; set; }

		public questInspectListenerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
