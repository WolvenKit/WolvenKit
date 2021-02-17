using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCompiledSmartObjectsNode : worldNode
	{
		[Ordinal(2)] [RED("resource")] public raRef<gameSmartObjectsCompiledResource> Resource { get; set; }

		public worldCompiledSmartObjectsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
