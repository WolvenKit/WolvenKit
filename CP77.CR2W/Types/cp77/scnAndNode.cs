using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnAndNode : scnSceneGraphNode
	{
		[Ordinal(3)] [RED("numInSockets")] public CUInt32 NumInSockets { get; set; }

		public scnAndNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
