using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RemoveActiveContextEvent : redEvent
	{
		[Ordinal(0)] [RED("context")] public CEnum<gamedeviceRequestType> Context { get; set; }

		public RemoveActiveContextEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
