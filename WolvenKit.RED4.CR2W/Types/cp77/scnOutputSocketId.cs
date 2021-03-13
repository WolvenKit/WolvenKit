using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOutputSocketId : CVariable
	{
		[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
		[Ordinal(1)] [RED("osockStamp")] public scnOutputSocketStamp OsockStamp { get; set; }

		public scnOutputSocketId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
