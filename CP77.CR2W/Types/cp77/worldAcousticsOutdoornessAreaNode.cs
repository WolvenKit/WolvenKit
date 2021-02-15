using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAcousticsOutdoornessAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] [RED("outdoor")] public CFloat Outdoor { get; set; }

		public worldAcousticsOutdoornessAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
