using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsSocket : scnSceneEvent
	{
		[Ordinal(6)] [RED("osockStamp")] public scnOutputSocketStamp OsockStamp { get; set; }

		public scneventsSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
