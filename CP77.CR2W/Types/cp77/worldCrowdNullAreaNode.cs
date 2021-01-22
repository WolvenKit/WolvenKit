using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCrowdNullAreaNode : worldAreaShapeNode
	{
		[Ordinal(0)]  [RED("IsForBlockade")] public CBool IsForBlockade { get; set; }

		public worldCrowdNullAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
