using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gsmState_SessionPaused : gsmState_SessionStreamingAware
	{
		public gsmState_SessionPaused(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
