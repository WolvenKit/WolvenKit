using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RegisterDebuggerCanditateEvent : redEvent
	{
		[Ordinal(0)]  [RED("device")] public wCHandle<Device> Device { get; set; }

		public RegisterDebuggerCanditateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
