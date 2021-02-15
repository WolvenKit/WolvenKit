using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnEndNode : scnSceneGraphNode
	{
		[Ordinal(3)] [RED("type")] public CEnum<scnEndNodeNsType> Type { get; set; }

		public scnEndNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
