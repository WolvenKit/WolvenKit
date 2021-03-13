using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldOffMeshSmartObjectNode : worldOffMeshConnectionNode
	{
		[Ordinal(13)] [RED("object")] public CHandle<gameSmartObjectDefinition> Object { get; set; }

		public worldOffMeshSmartObjectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
