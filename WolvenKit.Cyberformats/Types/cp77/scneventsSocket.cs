using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsSocket : scnSceneEvent
	{
		[Ordinal(6)] [RED("osockStamp")] public scnOutputSocketStamp OsockStamp { get; set; }

		public scneventsSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
