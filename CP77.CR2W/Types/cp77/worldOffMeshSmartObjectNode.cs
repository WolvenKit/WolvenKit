using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldOffMeshSmartObjectNode : worldOffMeshConnectionNode
	{
		[Ordinal(11)] [RED("object")] public CHandle<gameSmartObjectDefinition> Object { get; set; }

		public worldOffMeshSmartObjectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
