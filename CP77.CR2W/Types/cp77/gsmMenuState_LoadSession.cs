using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gsmMenuState_LoadSession : gsmMenuState
	{
		public gsmMenuState_LoadSession(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
