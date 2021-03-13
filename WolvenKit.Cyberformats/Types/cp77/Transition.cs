using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Transition : redEvent
	{
		[Ordinal(0)] [RED("listenerID")] public CUInt32 ListenerID { get; set; }

		public Transition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
