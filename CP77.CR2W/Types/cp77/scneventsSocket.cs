using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scneventsSocket : scnSceneEvent
	{
		[Ordinal(0)]  [RED("osockStamp")] public scnOutputSocketStamp OsockStamp { get; set; }

		public scneventsSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
